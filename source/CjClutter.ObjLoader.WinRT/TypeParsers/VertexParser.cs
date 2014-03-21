using System;
using CjClutter.ObjLoader.WinRT.Common;
using CjClutter.ObjLoader.WinRT.Data.DataStore;
using CjClutter.ObjLoader.WinRT.Data.VertexData;
using CjClutter.ObjLoader.WinRT.TypeParsers.Interfaces;

namespace CjClutter.ObjLoader.WinRT.TypeParsers
{
    public class VertexParser : TypeParserBase, IVertexParser
    {
        private readonly IVertexDataStore _vertexDataStore;

        public VertexParser(IVertexDataStore vertexDataStore)
        {
            _vertexDataStore = vertexDataStore;
        }

        protected override string Keyword
        {
            get { return "v"; }
        }

        public override void Parse(string line)
        {
            string[] parts = line.Split(new[]{' '}, StringSplitOptions.RemoveEmptyEntries);

            var x = parts[0].ParseInvariantFloat();
            var y = parts[1].ParseInvariantFloat();
            var z = parts[2].ParseInvariantFloat();

            var vertex = new Vertex(x, y, z);
            _vertexDataStore.AddVertex(vertex);
        }
    }
}