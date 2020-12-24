using DesignPatternSamples.Application.DTO;
using DesignPatternSamples.Application.Services;
using Microsoft.Extensions.Caching.Distributed;
using System.Collections.Generic;
using System.Threading.Tasks;
using Workbench.IDistributedCache.Extensions;

namespace DesignPatternSamples.Application.Decorators
{
    public class DetranVerificadorPontosDecoratorCache : IDetranVerificadorPontosService
    {
        private readonly IDetranVerificadorPontosService _Inner;
        private readonly IDistributedCache _Cache;

        public DetranVerificadorPontosDecoratorCache(
            IDetranVerificadorDebitosService inner,
            IDistributedCache cache)
        {
            _Inner = (IDetranVerificadorPontosService)inner;
            _Cache = cache;
        }

        public Task<IEnumerable<PontosMotorista>> ConsultarPontos(Veiculo veiculo)
        {
            return Task.FromResult(_Cache.GetOrCreate($"{veiculo.UF}_{veiculo.Placa}", () => _Inner.ConsultarPontos(veiculo).Result));
        }
    }
}