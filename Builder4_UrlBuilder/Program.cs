
using Builder4_UrlBuilder;

var url = new UrlBuilder()
    .WithScheme("ftp")
    .WithHost("192.168.1.1")
    .WithPort(1010)
    .WithQueryString(new QueryStringBuilder().AddParam("page", "12"))
    .Build();

Console.WriteLine($"URL CREATED : {url}");
