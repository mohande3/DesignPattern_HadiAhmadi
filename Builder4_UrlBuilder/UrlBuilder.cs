using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder4_UrlBuilder
{
    internal class UrlBuilder
    {
        private string _scheme = "http";
        private string _host = "localhost";
        private string? _port = string.Empty;
        private string _queryString = string.Empty;

        public UrlBuilder WithScheme(string scheme)
        {
            _scheme = scheme;
            return this;
        }
        public string Build()
            => $"{_scheme}://{_host}:{_port}/{_queryString}";
    }
}
