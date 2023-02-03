using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Builder5_StepBuilder.BuilderStep2
{
    internal interface IHttpWebRequestStepBuilder
    {
        IHttpWebRequestStepBuilder Build();
    }
    internal interface IHttpWebRequestMethodStepBuilder
    {
        IHttpWebRequestStepBuilder Get();
        IHttpWebRequestContentStepBuilder Post();
        IHttpWebRequestContentStepBuilder Put();
    }

    internal interface IHttpWebRequestContentStepBuilder
    {
        IHttpWebRequestStepBuilder WithBody();
    }

    internal class HttpWebRequestStepBuilder :
        IHttpWebRequestStepBuilder,
        IHttpWebRequestMethodStepBuilder,
        IHttpWebRequestContentStepBuilder
    {

        private HttpWebRequestStepBuilder() { }
        public static IHttpWebRequestMethodStepBuilder NewRequest()
        {
            return new HttpWebRequestStepBuilder();
        }

        public IHttpWebRequestStepBuilder Build()
        {
            throw new NotImplementedException();
        }

        public IHttpWebRequestStepBuilder Get()
        {
            throw new NotImplementedException();
        }

        public IHttpWebRequestContentStepBuilder Post()
        {
            throw new NotImplementedException();
        }

        public IHttpWebRequestContentStepBuilder Put()
        {
            throw new NotImplementedException();
        }

        public IHttpWebRequestStepBuilder WithBody()
        {
            throw new NotImplementedException();
        }
    }
}
