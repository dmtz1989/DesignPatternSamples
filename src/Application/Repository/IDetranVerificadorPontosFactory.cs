using System;

namespace DesignPatternSamples.Infra.Repository.Detran
{
    public interface IDetranVerificadorPontosFactory
    {
        public IDetranVerificadorPontosFactory Register(string UF, Type repository);
        public IDetranVerificadorPontosFactory Create(string UF);
        
    }
}