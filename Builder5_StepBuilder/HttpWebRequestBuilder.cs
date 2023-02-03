namespace Builder5_StepBuilder
{
    internal interface IHttpWebRequestBuilder
    {
        IHttpWebRequestBuilder Build();
    }
    internal interface IHttpWebRequestMethodBuilder : IHttpWebRequestBuilder
    {
        IHttpWebRequestBuilder Get();
        IHttpWebRequestBuilderWithBody Post();
        IHttpWebRequestBuilderWithBody Put();
    }

    internal interface IHttpWebRequestBuilderWithBody : IHttpWebRequestBuilder
    {
        IHttpWebRequestBuilderWithBody WithBody(string content);
    }

    internal class HttpWebRequestBuilder : IHttpWebRequestMethodBuilder, IHttpWebRequestBuilderWithBody
    {

        private HttpMethod _method;

        public IHttpWebRequestBuilder Get()
        {
            _method = HttpMethod.Get;
            return this;
        }
        public IHttpWebRequestBuilderWithBody Post()
        {
            _method = HttpMethod.Post;
            return this;
        }
        public IHttpWebRequestBuilderWithBody Put()
        {
            _method = HttpMethod.Put;
            return this;
        }

        public IHttpWebRequestBuilderWithBody WithBody(string content)
        {
            return this;
        }

        public IHttpWebRequestBuilder Build()
        {
            throw new NotImplementedException();
        }
    }
}
