using Grpc.Net.Client;
using GrpcService;
using System;
using System.Threading;

namespace ClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greeter.GreeterClient(channel);

            var reply = client.SayHello(
                new HelloRequest { Name = "Test" });

            Console.WriteLine("From Server: " + reply.Message);
        }
    }
}
