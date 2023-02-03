
using CompositWithBuilder01_TagHelper;

var tag = new XmlDocumentBuilder("Root")
    .AddAttribute("class", "show")
    .AddChild(ch => ch.AddChild("child2").AddChild("child3").Build())
    .Build();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine(tag.Render());