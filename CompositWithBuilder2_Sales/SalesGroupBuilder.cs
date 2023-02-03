using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositWithBuilder2_Sales
{
    internal class SalesGroupBuilder
    {

        private SalesGroup _root;

        public SalesGroupBuilder(string nameGroup)
        {
            _root = new SalesGroup();
            _root.NameGroup = nameGroup;
        }

        public SalesGroupBuilder AddMembers()
        {
            return this;
        }

        public SalesGroupBuilder AddGroup()
        {
            return this;
        }

        public SalesGroup Build()
        {
            return _root;
        }

    }
}
