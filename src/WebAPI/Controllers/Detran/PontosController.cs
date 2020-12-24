using AutoMapper;
using DesignPatternSamples.Application.DTO;
using DesignPatternSamples.Application.Services;
using DesignPatternSamples.WebAPI.Models;
using DesignPatternSamples.WebAPI.Models.Detran;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternSamples.WebAPI.Controllers.Detran
{
    [Route("api/Detran/[controller]")]
    [ApiController]
    public class PontosController : ControllerBase
    {
        private readonly IMapper _Mapper;
        private readonly IDetranVerificadorPontosService _DetranVerificadorPontosServices;

        public PontosController(IMapper mapper, IDetranVerificadorPontosService detranVerificadorPontosServices)
        {
            _Mapper = mapper;
            _DetranVerificadorPontosServices = detranVerificadorPontosServices;
        }

        [HttpGet()]
        [ProducesResponseType(typeof(SuccessResultModel<IEnumerable<PontosVeiculoModel>>), StatusCodes.Status200OK)]
        public async Task<ActionResult> Get([FromQuery] VeiculoModel model)
        {
            var debitos = await _DetranVerificadorPontosServices.ConsultarPontos(_Mapper.Map<Veiculo>(model));

            var result = new SuccessResultModel<IEnumerable<PontosVeiculoModel>>(_Mapper.Map<IEnumerable<PontosVeiculoModel>>(debitos));

            return Ok(result);
        }
    }
}