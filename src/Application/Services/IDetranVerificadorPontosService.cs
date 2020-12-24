using DesignPatternSamples.Application.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Application.Services
{
    public interface IDetranVerificadorPontosService
    {
        Task<IEnumerable<PontosMotorista>> ConsultarPontos(Veiculo veiculo);
    }
}
