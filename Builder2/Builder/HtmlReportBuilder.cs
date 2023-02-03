namespace Builder2.Builder
{
    internal class HtmlReportBuilder : IReportBuilder
    {
        public void AddAuthor(string author)
        {
            throw new NotImplementedException();    
        }

        public void AddDescription(string description)
        {
            throw new NotImplementedException();
        }

        public void AddTitle(string title)
        {
            throw new NotImplementedException();
        }

        public Document Build()
        {
            return new HtmlDocument();
        }
    }
}
