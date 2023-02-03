

using Builder2.Builder;
using Builder2.Builder.Decoratoes;

var builder = new HtmlReportBuilder();
var csvGeneratorDecorator = new ProfitReportGenerator(builder);
csvGeneratorDecorator.ReportFromVsc("... address file");

var document = builder.Build(); 
// show document
