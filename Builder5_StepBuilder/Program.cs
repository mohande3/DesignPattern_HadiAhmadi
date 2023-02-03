

using Builder5_StepBuilder;

var request = new HttpWebRequestBuilder()
    .Get()
    .WithBody("My Body") // این منطقی نیست
    .Build();