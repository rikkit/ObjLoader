using CjClutter.ObjLoader.WinRT.Data.VertexData;

namespace CjClutter.ObjLoader.WinRT.Data.DataStore
{
    public interface IVertexDataStore
    {
        void AddVertex(Vertex vertex);
    }
}