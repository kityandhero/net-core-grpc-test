// See https://aka.ms/new-console-template for more information

//var channel = GrpcChannel.ForAddress("https://localhost:5001");

//var client = new Greeter.GreeterClient(channel);
//var reply = await client.SayHelloAsync(
//    new HelloRequest { Name = "晓晨" });
//Console.WriteLine("Greeter 服务返回数据: " + reply.Message);
//Console.ReadKey();

using Grpc.Net.Client;
using SimpleGrpcClient;

var channel = GrpcChannel.ForAddress("https://localhost:7181");
var client = new Greeter.GreeterClient(channel);

var reply = await client.SayHelloAsync(
    new HelloRequest { Name = "晓晨" }
);

Console.WriteLine("Greeter 服务返回数据: " + reply.Message);
Console.ReadKey();