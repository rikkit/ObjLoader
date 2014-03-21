using System.IO;
using System.Threading.Tasks;
using Windows.Storage.Streams;
using CjClutter.ObjLoader.WinRT.Data.DataStore;
using CjClutter.ObjLoader.WinRT.TypeParsers;

namespace CjClutter.ObjLoader.WinRT.Loaders
{
    public interface IAsyncMaterialStreamProvider
    {
        Task<IRandomAccessStream> Open(string materialFilePath);
    }

    public class ObjLoaderFactory : IObjLoaderFactory
    {
        public IObjLoader Create()
        {
            return Create(new AsyncMaterialStreamProvider());
        }

        public IObjLoader Create(IAsyncMaterialStreamProvider asyncMaterialStreamProvider)
        {
            var dataStore = new DataStore();
            
            var faceParser = new FaceParser(dataStore);
            var groupParser = new GroupParser(dataStore);
            var normalParser = new NormalParser(dataStore);
            var textureParser = new TextureParser(dataStore);
            var vertexParser = new VertexParser(dataStore);

            var materialLibraryLoader = new MaterialLibraryLoader(dataStore);
            var materialLibraryLoaderFacade = new MaterialLibraryLoaderFacade(materialLibraryLoader, asyncMaterialStreamProvider);
            var materialLibraryParser = new MaterialLibraryParser(materialLibraryLoaderFacade);
            var useMaterialParser = new UseMaterialParser(dataStore);

            return new ObjLoader(dataStore, faceParser, groupParser, normalParser, textureParser, vertexParser, materialLibraryParser, useMaterialParser);
        }
    }
}