using System.Collections.Generic;
using System.Linq;
using APIBrasil.Dto;
using Microsoft.AspNetCore.Mvc;

namespace APIBrasil.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/estado")]
    public class EstadoController : Controller
    {
        [HttpGet]
        public List<EstadoDto> Get()
        {
            return ListarEstados();
        }

        [HttpGet("{id}")]
        public EstadoDto Get(int id)
        {
            var estados = ListarEstados();
            return estados.FirstOrDefault(x => x.IdEstado == id);
        }

        private List<EstadoDto> ListarEstados()
        {
            var estados = new List<EstadoDto>()
            {
                new EstadoDto{ IdEstado = 1, Sigla = "SP", Nome = "São Paulo"},
                new EstadoDto{ IdEstado = 2, Sigla = "MG", Nome = "Minas Gerais"},
                new EstadoDto{ IdEstado = 3, Sigla = "RJ", Nome = "Rio de Janeiro"}
            };

            return estados;
        }
    }
}