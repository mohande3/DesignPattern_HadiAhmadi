
using Builder4_UrlBuilder;

var url = new UrlBuilder()
    .WithScheme("ftp")
    .WithHost("192.168.1.1")
    .WithPort(1010)
    .WithQueryString(new QueryStringBuilder().AddParam("page", "12"))
    .WithQueryStringAction(query=>query.AddParam("page","1").AddParam("sort","desc"))
    .Build();

Console.WriteLine($"URL CREATED : {url}");
