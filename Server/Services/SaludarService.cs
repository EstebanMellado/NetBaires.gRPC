using System;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using Saludo;

namespace Server.Services
{
    public class SaludarService : Saludar.SaludarBase
    {
        private readonly ILogger<SaludarService> _logger;
        public SaludarService(ILogger<SaludarService> logger)
        {
            _logger = logger;
        }

        public override Task<SaludoResponse> DecirHola(SaludoRequest request, ServerCallContext context)
        {
            Console.WriteLine("Parametro recibido={0}", request.Nombre);
            return Task.FromResult(new SaludoResponse
            {
                Saludo = "Hola " + request.Nombre
            });
        }
    }
}
