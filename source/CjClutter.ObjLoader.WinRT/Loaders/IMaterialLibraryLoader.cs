using System.IO;

namespace CjClutter.ObjLoader.WinRT.Loaders
{
    public interface IMaterialLibraryLoader
    {
        void Load(Stream lineStream);
    }
}