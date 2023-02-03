using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositWithBuilder01_TagHelper
{
    internal class XmlDocumentBuilder
    {
        private readonly TagNode _rootNode;

        public XmlDocumentBuilder(string rootName)
        {
            _rootNode = new TagNode(rootName);
        }

        public TagNode Build()
        {
            return _rootNode;
        }
    }
}
