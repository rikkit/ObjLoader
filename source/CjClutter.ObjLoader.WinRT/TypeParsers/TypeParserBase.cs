using CjClutter.ObjLoader.WinRT.Common;
using CjClutter.ObjLoader.WinRT.TypeParsers.Interfaces;

namespace CjClutter.ObjLoader.WinRT.TypeParsers
{
    public abstract class TypeParserBase : ITypeParser
    {
        protected abstract string Keyword { get; }

        public bool CanParse(string keyword)
        {
            return keyword.EqualsInvariantCultureIgnoreCase(Keyword);
        }

        public abstract void Parse(string line);
    }
}