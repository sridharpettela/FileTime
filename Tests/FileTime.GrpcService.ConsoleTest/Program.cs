using Grpc.Net.Client;
using System;
using FileTime.GrpcService;
using System.Threading.Tasks;

namespace FileTime.GrpcService.ConsoleTest
{
	class Program
	{
		static async Task Main(string[] args)
		{
			// The port number(5001) must match the port of the gRPC server.
			using var channel = GrpcChannel.ForAddress("https://localhost:5001");
			var client = new Filer.FilerClient(channel);
			var reply = await client.FilerLoginAsync(
				new FilerLoginRequest() { EmailAddress = "sridharpettela@gmail.com",Password = "1234124124"});
			Console.WriteLine("Greeting: " + reply.EmailAddress);
			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}
    }
}
