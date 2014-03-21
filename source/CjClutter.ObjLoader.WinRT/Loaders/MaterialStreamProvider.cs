using System;
using System.IO;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Streams;

namespace CjClutter.ObjLoader.WinRT.Loaders
{
    public class AsyncMaterialStreamProvider : IAsyncMaterialStreamProvider
    {
        public async Task<IRandomAccessStream> Open(string materialFilePath)
        {
            var file = await StorageFile.GetFileFromPathAsync(materialFilePath);

            return await file.OpenReadAsync();
        }
    }

    public class AsyncMaterialNullStreamProvider : IAsyncMaterialStreamProvider
    {
        public Task<IRandomAccessStream> Open(string materialFilePath)
        {
            return null;
        }
    }
}