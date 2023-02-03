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
        private QueryStringBuilder _queryStringBuilder;

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

        public UrlBuilder WithPort(int port)
        {
            _port = $":{port}";
            return this;
        }

        public UrlBuilder WithQueryString(QueryStringBuilder queryStringBuilder)
        {
            _queryStringBuilder = queryStringBuilder;
            return this;
        }

        public UrlBuilder WithQueryStringAction(Action<QueryStringBuilder> queryStringBuilderConfig)
        {
            if (_queryStringBuilder == null)
                _queryStringBuilder = new QueryStringBuilder();

            queryStringBuilderConfig.Invoke(_queryStringBuilder);
            
            return this;
        }


        public string Build()
        {
            var str = _queryStringBuilder?.Build();
            return $"{_scheme}://{_host}{_port}{str}";
        }
    }
}
