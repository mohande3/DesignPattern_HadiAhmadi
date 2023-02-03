

using Builder5_StepBuilder;

var request = new HttpWebRequestBuilder()
    .Post()
    .WithBody("My Body") // این منطقی نیست
    .Build();