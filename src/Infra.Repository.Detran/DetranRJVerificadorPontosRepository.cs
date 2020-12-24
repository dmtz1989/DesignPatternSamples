using DesignPatternSamples.Application.DTO;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternSamples.Infra.Repository.Detran
{
    public class DetranRJVerificadorPontosRepository : DetranVerificadorPontosRepositoryCrawlerBase
    {
        private readonly ILogger _Logger;

        public DetranRJVerificadorPontosRepository(ILogger<DetranRJVerificadorPontosRepository> logger)
        {
            _Logger = logger;
        }

        protected override Task<IEnumerable<PontosMotorista>> PadronizarResultado(string html)
        {
            _Logger.LogDebug($"Padronizando o Resultado {html}.");
            return Task.FromResult<IEnumerable<PontosMotorista>>(new List<PontosMotorista>());
        }

        protected override Task<string> RealizarAcesso(Veiculo veiculo)
        {
            _Logger.LogDebug($"Consultando débitos do veículo placa {veiculo.Placa} para o estado de RJ.");
            return Task.FromResult("CONTEUDO DO SITE DO DETRAN/RJ");
        }
    }
}
