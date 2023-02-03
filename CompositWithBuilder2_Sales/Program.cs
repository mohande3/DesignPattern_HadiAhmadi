
using CompositWithBuilder2_Sales;

var oBuild = new SalesGroupBuilder("Group Header")
    .AddMembers()
    .AddGroup()
    .Build();
