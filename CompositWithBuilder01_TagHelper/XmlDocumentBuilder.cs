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
        private TagNode _currentParent;

        public XmlDocumentBuilder() : this("") { }
        public XmlDocumentBuilder(string rootName)
        {
            _rootNode = new TagNode(rootName);
            _currentNode = _rootNode;
            _currentParent = _rootNode;
        }

        public XmlDocumentBuilder AddChild(string name)
        {
            var tag = new TagNode(name);
            _currentNode.Add(tag);
            _currentParent = _currentNode;
            _currentNode = tag;
            return this;
        }
        public XmlDocumentBuilder AddChild(Action<XmlDocumentBuilder> builder)
        {
            //var tag = new TagNode(name);
            //_currentNode.Add(tag);
            //_currentParent = _currentNode;
            //_currentNode = tag;
            var xmlBuilder = new XmlDocumentBuilder();
            builder(xmlBuilder);
            var x = xmlBuilder.Build();
            _currentNode.Add(x);
            return this;
        }
        public XmlDocumentBuilder AddSibling(string name)
        {
            var tag = new TagNode(name);
            _currentParent.Add(tag);
            _currentNode = tag;
            return this;
        }
        public XmlDocumentBuilder AddAttribute(string key,string value)
        {
            _currentNode.AddAttribute(key, value);
            return this;
        }

        public TagNode Build()
        {
            return _rootNode;
        }
    }
}
