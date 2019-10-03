using System;
using System.Threading.Tasks;
using Grpc.Core;
using Grpc.Net.Client;

namespace GrpcSample.Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Enable support for unencrypted HTTP2  
            AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);

            // The port number here must match the port of the gRPC server
            var channel = GrpcChannel.ForAddress(
                "http://localhost:50051", new GrpcChannelOptions {Credentials = ChannelCredentials.Insecure});

            var client = new Greeter.GreeterClient(channel);

            var reply = await client.SayHelloAsync(
                new HelloRequest { Name = "GreeterClient" });

            Console.WriteLine("Greeting: " + reply.Message);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
