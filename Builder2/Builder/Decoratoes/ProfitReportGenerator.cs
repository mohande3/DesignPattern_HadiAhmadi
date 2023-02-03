using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder2.Builder.Decoratoes
{
    internal class ProfitReportGenerator
    {
        private readonly IReportBuilder _reportBuiler;

        public ProfitReportGenerator(IReportBuilder reportBuiler)
        {
            _reportBuiler = reportBuiler;
        }

        public void ReportFromVsc(string pathFile)
        {
            //-- Read iFile
            _reportBuiler.AddTitle("REport from SVC");
            _reportBuiler.AddAuthor("Mr Mohande3 Khademi");
            _reportBuiler.AddDescription("This is a report from csv file for generation");
        }
    }
}
