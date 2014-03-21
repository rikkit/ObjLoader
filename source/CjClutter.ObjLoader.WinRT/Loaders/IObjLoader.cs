using System.IO;
using Windows.Storage.Streams;

namespace CjClutter.ObjLoader.WinRT.Loaders
{
    public interface IObjLoader
    {
        LoadResult Load(IRandomAccessStream lineStream);
    }
}