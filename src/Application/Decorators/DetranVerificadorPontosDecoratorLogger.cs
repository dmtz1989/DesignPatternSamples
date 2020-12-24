using DesignPatternSamples.Application.DTO;
using DesignPatternSamples.Application.Services;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace DesignPatternSamples.Application.Decorators
{
    public class DetranVerificadorPontosDecoratorLogger : IDetranVerificadorPontosService
    {
        private readonly IDetranVerificadorPontosService _Inner;
        private readonly ILogger<DetranVerificadorPontosDecoratorLogger> _Logger;

        public DetranVerificadorPontosDecoratorLogger(
            IDetranVerificadorPontosService inner,
            ILogger<DetranVerificadorPontosDecoratorLogger> logger)
        {
            _Inner = inner;
            _Logger = logger;
        }

        public async Task<IEnumerable<PontosMotorista>> ConsultarPontos(Veiculo veiculo)
        {
            Stopwatch watch = Stopwatch.StartNew();
            _Logger.LogInformation($"Iniciando a execução do método ConsultarPontos({veiculo})");
            var result = await _Inner.ConsultarPontos(veiculo);
            watch.Stop();
            _Logger.LogInformation($"Encerrando a execução do método ConsultarPontos({veiculo}) {watch.ElapsedMilliseconds}ms");
            return result;
        }
    }
}