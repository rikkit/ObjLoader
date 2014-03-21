using System.Threading.Tasks;

namespace CjClutter.ObjLoader.WinRT.Loaders
{
    public interface IMaterialLibraryLoaderFacade
    {
        Task Load(string materialFileName);
    }
}