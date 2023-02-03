using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder5_StepBuilder.BuilderStep2
{
    internal  interface IHttpWebRequestStepBuilder
    {
        IHttpWebRequestStepBuilder Get();
        IHttpWebRequestStepBuilder Post();
        IHttpWebRequestStepBuilder Put();
        IHttpWebRequestStepBuilder Build();
    }

    internal interface IHttpWebRequestContentStepBuilder
    {
        IHttpWebRequestContentStepBuilder WithBody();
    }

    internal class HttpWebRequestStepBuilder : IHttpWebRequestStepBuilder, IHttpWebRequestContentStepBuilder
    {
        public IHttpWebRequestStepBuilder Build()
        {
            throw new NotImplementedException();
        }

        public IHttpWebRequestStepBuilder Get()
        {
            throw new NotImplementedException();
        }

        public IHttpWebRequestStepBuilder Post()
        {
            throw new NotImplementedException();
        }

        public IHttpWebRequestStepBuilder Put()
        {
            throw new NotImplementedException();
        }

        public IHttpWebRequestContentStepBuilder WithBody()
        {
            throw new NotImplementedException();
        }
    }
}
