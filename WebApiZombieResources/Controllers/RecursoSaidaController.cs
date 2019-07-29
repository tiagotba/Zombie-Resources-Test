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
    public class RecursoSaidaController : ApiController
    {
        private IRecursoSaidaRepository _recursoSaidaRepository;
        private ISobreviventeRepository _sobreviventeRepository;

        public RecursoSaidaController(IRecursoSaidaRepository recursoSaidaRepository, ISobreviventeRepository sobreviventeRepository)
        {
            this._recursoSaidaRepository = recursoSaidaRepository;
            this._sobreviventeRepository = sobreviventeRepository;
        }

        [HttpPost]
        public IHttpActionResult PostRecursoSaida([FromBody] RecursoSaida recursoSaida)
        {
            var sobreviventeExiste = _sobreviventeRepository.GetSobreviventes(recursoSaida.SobreviventeID);
            if (sobreviventeExiste == null)
            {
                return NotFound();
            }

            _recursoSaidaRepository.RegistraSaida(recursoSaida);
            return Ok();
        }
    }
}
