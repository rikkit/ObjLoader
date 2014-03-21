using CjClutter.ObjLoader.WinRT.Common;
using CjClutter.ObjLoader.WinRT.Data.DataStore;
using CjClutter.ObjLoader.WinRT.Data.VertexData;
using CjClutter.ObjLoader.WinRT.TypeParsers.Interfaces;

namespace CjClutter.ObjLoader.WinRT.TypeParsers
{
    public class TextureParser : TypeParserBase, ITextureParser
    {
        private readonly ITextureDataStore _textureDataStore;

        public TextureParser(ITextureDataStore textureDataStore)
        {
            _textureDataStore = textureDataStore;
        }

        protected override string Keyword
        {
            get { return "vt"; }
        }

        public override void Parse(string line)
        {
            string[] parts = line.Split(' ');

            float x = parts[0].ParseInvariantFloat();
            float y = parts[1].ParseInvariantFloat();

            var texture = new Texture(x, y);
            _textureDataStore.AddTexture(texture);
        }
    }
}