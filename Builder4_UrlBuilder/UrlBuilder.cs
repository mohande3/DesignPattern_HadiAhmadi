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
        private Dictionary<string, string> _queryString = new Dictionary<string, string>();

        public UrlBuilder WithScheme(string scheme)
        {
            _scheme = scheme;
            return this;
        }

        public UrlBuilder WithHost(string host)
        {
            _host = host;
            return this;
        }

        public UrlBuilder WithPort(string port)
        {
            _port = port;
            return this;
        }

        public UrlBuilder WithQueryString(string key, string value)
        {
            _queryString.Add(key, value);
            return this;
        }


        public string Build()
            => $"{_scheme}://{_host}:{_port}/{_queryString}";
    }
}
