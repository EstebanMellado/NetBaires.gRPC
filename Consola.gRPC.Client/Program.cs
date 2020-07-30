using Grpc.Net.Client;
using Saludo;
using System;
using System.Threading.Tasks;

namespace Consola.gRPC.Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // The port number(5001) must match the port of the gRPC server.
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Saludar.SaludarClient(channel);

            var reply = await client.DecirHolaAsync(
                              new SaludoRequest { Nombre = "NetBaires 2020" });

            Console.WriteLine("**************  Respuesta: " + reply.Saludo);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
