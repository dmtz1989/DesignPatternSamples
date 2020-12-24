using DesignPatternSamples.Application.DTO;
using DesignPatternSamples.Application.Repository;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternSamples.Infra.Repository.Detran
{
    public class DetranSPVerificadorPontosRepository : IDetranVerificadorPontosRepository
    {
        private readonly ILogger _Logger;

        public DetranSPVerificadorPontosRepository(ILogger<DetranSPVerificadorPontosRepository> logger)
        {
            _Logger = logger;
        }

        public Task<IEnumerable<PontosMotorista>> ConsultarDebitos(Veiculo veiculo)
        {
            _Logger.LogDebug($"Consultando Pontos do Motorista placa {veiculo.Placa} para o estado de SP.");
            return Task.FromResult<IEnumerable<PontosMotorista>>(new List<PontosMotorista>() { new PontosMotorista() });
        }

        public Task<IEnumerable<PontosMotorista>> ConsultarPontos(Veiculo veiculo)
        {
            throw new System.NotImplementedException();
        }
    }
}
