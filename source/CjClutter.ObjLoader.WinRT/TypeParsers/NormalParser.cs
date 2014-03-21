using CjClutter.ObjLoader.WinRT.Common;
using CjClutter.ObjLoader.WinRT.Data.DataStore;
using CjClutter.ObjLoader.WinRT.Data.VertexData;
using CjClutter.ObjLoader.WinRT.TypeParsers.Interfaces;

namespace CjClutter.ObjLoader.WinRT.TypeParsers
{
    public class NormalParser : TypeParserBase, INormalParser
    {
        private readonly INormalDataStore _normalDataStore;

        public NormalParser(INormalDataStore normalDataStore)
        {
            _normalDataStore = normalDataStore;
        }

        protected override string Keyword
        {
            get { return "vn"; }
        }

        public override void Parse(string line)
        {
            string[] parts = line.Split(' ');

            float x = parts[0].ParseInvariantFloat();
            float y = parts[1].ParseInvariantFloat();
            float z = parts[2].ParseInvariantFloat();

            var normal = new Normal(x, y, z);
            _normalDataStore.AddNormal(normal);
        }
    }
}