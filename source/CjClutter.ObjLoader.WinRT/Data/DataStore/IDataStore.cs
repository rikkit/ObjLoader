using System.Collections.Generic;
using CjClutter.ObjLoader.WinRT.Data.Elements;
using CjClutter.ObjLoader.WinRT.Data.VertexData;

namespace CjClutter.ObjLoader.WinRT.Data.DataStore
{
    public interface IDataStore 
    {
        IList<Vertex> Vertices { get; }
        IList<Texture> Textures { get; }
        IList<Normal> Normals { get; }
        IList<Material> Materials { get; }
        IList<Group> Groups { get; }
    }
}