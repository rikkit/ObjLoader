using System.Collections.Generic;
using CjClutter.ObjLoader.WinRT.Data;
using CjClutter.ObjLoader.WinRT.Data.Elements;
using CjClutter.ObjLoader.WinRT.Data.VertexData;

namespace CjClutter.ObjLoader.WinRT.Loaders
{
    public class LoadResult  
    {
        public IList<Vertex> Vertices { get; set; }
        public IList<Texture> Textures { get; set; }
        public IList<Normal> Normals { get; set; }
        public IList<Group> Groups { get; set; }
        public IList<Material> Materials { get; set; }
    }
}