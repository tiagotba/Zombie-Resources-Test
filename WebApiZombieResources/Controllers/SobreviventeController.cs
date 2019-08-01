using Newtonsoft.Json;
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
    [System.Web.Http.Cors.EnableCors(origins: "*", headers: "*", methods: "*", exposedHeaders: "X-Custom-Header")]
    public class SobreviventeController : ApiController
    {
        private ISobreviventeRepository sobreviventeRepository;

        public SobreviventeController(ISobreviventeRepository sobreviventeRepository)
        {
            this.sobreviventeRepository = sobreviventeRepository;
        }

        [HttpPost]
        public IHttpActionResult PostSobrevivente([FromBody] Sobreviventes sobreviventes)
        {
            var sobrevivente = sobreviventeRepository.GetByLogin(sobreviventes);

            if (sobrevivente != null)
            {
                return BadRequest("Sobrevivente já cadastrado");
            }

            var erros = sobreviventeRepository.Validar(sobreviventes).ToList();
            if (erros.Count > 0)
            {
                return BadRequest(JsonConvert.SerializeObject(erros));
            }

            sobreviventeRepository.AddSobrevivente(sobreviventes);
            return Ok();
        }
    }
}
