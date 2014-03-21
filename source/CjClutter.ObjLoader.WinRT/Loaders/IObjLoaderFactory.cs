namespace CjClutter.ObjLoader.WinRT.Loaders
{
    public interface IObjLoaderFactory
    {
        IObjLoader Create(IAsyncMaterialStreamProvider asyncMaterialStreamProvider);
        IObjLoader Create();
    }
}