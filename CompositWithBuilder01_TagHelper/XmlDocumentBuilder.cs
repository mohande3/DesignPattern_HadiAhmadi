using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositWithBuilder01_TagHelper
{
    internal class XmlDocumentBuilder
    {
        private TagNode _rootNode;
        private TagNode _currentNode;

        public XmlDocumentBuilder(string rootName)
        {
            _rootNode = new TagNode(rootName);
            _currentNode = _rootNode;
        }

        public XmlDocumentBuilder AddChild(string name)
        {
            var tag = new TagNode(name);
            _currentNode.Add(tag);
            _currentNode = tag;
            return this;
        }
        public XmlDocumentBuilder AddAttribute(string key,string value)
        {
            _rootNode.AddAttribute(key, value);
            return this;
        }

        public TagNode Build()
        {
            return _rootNode;
        }
    }
}
