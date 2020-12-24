using DesignPatternSamples.Application.DTO;
using DesignPatternSamples.Application.Repository;
using DesignPatternSamples.Application.Services;
using DesignPatternSamples.Infra.Repository.Detran;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternSamples.Application.Implementations
{
    public class DetranVerificadorPontosServices : IDetranVerificadorPontosService
    {
        private readonly IDetranVerificadorDebitosFactory _Factory;

        public DetranVerificadorPontosServices(IDetranVerificadorPontosFactory factory)
        {
            _Factory = (IDetranVerificadorDebitosFactory)factory;
        }

        public Task<IEnumerable<PontosMotorista>> ConsultarPontos(Veiculo veiculo)
        {
            IDetranVerificadorPontosRepository repository = (IDetranVerificadorPontosRepository)_Factory.Create(veiculo.UF);
            return repository.ConsultarPontos(veiculo);
        }
    }
}
