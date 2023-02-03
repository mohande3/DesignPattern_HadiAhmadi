
using CompositWithBuilder01_TagHelper;

var tag = new TagNode("Root");
tag.AddValue("This is a Value");
tag.AddAttribute("class", "show");

var childClass = new TagNode("children");
childClass.AddValue("New Value For Child Class");

tag.Add(childClass);

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine(tag.Render());
