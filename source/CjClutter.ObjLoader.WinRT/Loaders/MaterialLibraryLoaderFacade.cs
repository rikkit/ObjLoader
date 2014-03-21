using System.IO;
using System.Threading.Tasks;

namespace CjClutter.ObjLoader.WinRT.Loaders
{
    public class MaterialLibraryLoaderFacade : IMaterialLibraryLoaderFacade
    {
        private readonly IMaterialLibraryLoader _loader;
        private readonly IAsyncMaterialStreamProvider _asyncMaterialStreamProvider;

        public MaterialLibraryLoaderFacade(IMaterialLibraryLoader loader, IAsyncMaterialStreamProvider asyncMaterialStreamProvider)
        {
            _loader = loader;
            _asyncMaterialStreamProvider = asyncMaterialStreamProvider;
        }

        public async Task Load(string materialFileName)
        {
            using (var stream = await _asyncMaterialStreamProvider.Open(materialFileName))
            {
                if (stream != null)
                {
                    var managedStream = stream.AsStreamForRead();

                    _loader.Load(managedStream);    
                }
            }
        }
    }
}