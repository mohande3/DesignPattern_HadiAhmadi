namespace Builder2.Builder
{
    internal interface IReportBuilder
    {
        void AddTitle(string title);    
        void AddDescription(string description);    
        void AddAuthor(string author);


        Document Build();

    }
}
