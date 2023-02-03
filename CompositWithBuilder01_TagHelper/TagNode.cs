using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositWithBuilder01_TagHelper
{
    internal class TagNode
    {
        private readonly string _name;
        private readonly List<TagNode> _children = new List<TagNode>();
        private readonly StringBuilder _attributes;
        private string _value = string.Empty;

        public TagNode(string name)
        {
            _name = name;
            _attributes = new StringBuilder();
        }

        public void Add(TagNode tag) => _children.Add(tag);
        public void AddAttribute(string attribute, string value)
        {
            _attributes.Append($" {attribute}='{value}'");
        }

        public void AddValue(string value) { _value = value; }

        public StringBuilder Render(StringBuilder resultBuilder)
        {
            resultBuilder.Append($"\t<{_name} {_attributes}>\n");
            foreach (var child in _children)
                child.Render(resultBuilder);

            resultBuilder.Append($"\t{_value}\n");
            resultBuilder.Append($"\t</{_name}>\n");
            return resultBuilder;
        }

        public string Render()
        {
            return Render(new StringBuilder()).ToString();
        }
    }
}
