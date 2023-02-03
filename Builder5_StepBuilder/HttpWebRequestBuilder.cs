namespace Builder5_StepBuilder
{
    internal class HttpWebRequestBuilder
    {
        private HttpMethod _method;

        public HttpWebRequestBuilder Get()
        {
            _method = HttpMethod.Get;
            return this;
        }
        public HttpWebRequestBuilder Post()
        {
            _method = HttpMethod.Post;
            return this;
        }
        public HttpWebRequestBuilder Put()
        {
            _method = HttpMethod.Put;
            return this;
        }

        public HttpWebRequestBuilder WithBody(string content)
        {
            return this;
        }

        public HttpRequestMessage Build()
        {
            return null;
        }
    }
}
