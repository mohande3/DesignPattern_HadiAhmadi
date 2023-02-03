using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder4_UrlBuilder
{
    internal class QueryStringBuilder
    {
        private Dictionary<string, string> _parameters =
            new Dictionary<string, string>();

        public QueryStringBuilder AddParam(string key, string value)
        {
            _parameters.Add(key, value);
            return this;
        }

        public string Build()
        {
            var strBuilder = new StringBuilder();
            int i = 0;
            foreach (var parameter in _parameters)
            {
                if (i == 0)
                    strBuilder.AppendLine($"{parameter.Key}={parameter.Key}");
                else
                    strBuilder.AppendLine($"&{parameter.Key}={parameter.Key}");

            }

            var str = strBuilder.ToString();
            if (string.IsNullOrEmpty(str))
            {
                return "";
            }
            else
                return $"?{str}";
        }
    }
}
