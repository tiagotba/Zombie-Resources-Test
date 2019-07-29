using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiZombieResources.Models;
using WebApiZombieResources.Repositories;

namespace WebApiZombieResources.Controllers
{
    public class RecursoEntradaController : ApiController
    {
        private IRecursoEntradaRepository _recursoEntradaRepository;
        private ISobreviventeRepository _sobreviventeRepository;

        public RecursoEntradaController(IRecursoEntradaRepository recursoEntradaRepository, ISobreviventeRepository sobreviventeRepository)
        {
            this._recursoEntradaRepository = recursoEntradaRepository;
            this._sobreviventeRepository = sobreviventeRepository;
        }

        [HttpPost]
        public IHttpActionResult PostRecursoEntrada([FromBody] RecursoEntrada recursoEntrada)
        {
            var sobreviventeExiste = _sobreviventeRepository.GetSobreviventes(recursoEntrada.SobreviventeID);
            if (sobreviventeExiste == null)
            {
                return NotFound();
            }

            _recursoEntradaRepository.RegistraEntrada(recursoEntrada);
            return Ok();
        }

    }
}
