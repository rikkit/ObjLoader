using CjClutter.ObjLoader.WinRT.Data.DataStore;
using CjClutter.ObjLoader.WinRT.TypeParsers.Interfaces;

namespace CjClutter.ObjLoader.WinRT.TypeParsers
{
    public class UseMaterialParser : TypeParserBase, IUseMaterialParser
    {
        private readonly IElementGroup _elementGroup;

        public UseMaterialParser(IElementGroup elementGroup)
        {
            _elementGroup = elementGroup;
        }

        protected override string Keyword
        {
            get { return "usemtl"; }
        }

        public override void Parse(string line)
        {
            _elementGroup.SetMaterial(line);
        }
    }
}