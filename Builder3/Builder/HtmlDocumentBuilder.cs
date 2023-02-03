using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Builder3.Builder
{
    internal class HtmlDocumentBuilder
    {
        public HtmlDocumentBuilder AddTitle(string title)
        {
            //-- work
            return this;
        }

        public HtmlDocumentBuilder AddTable(string content)
        {
            //-- work
            return this;
        }
        public HtmlDocumentBuilder AddParagraph(string content)
        {
            //-- work
            return this;
        }

        public string Build() => "";

    }
}
