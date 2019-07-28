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
    public class RecursosController : ApiController
    {

        private IRecursosRepository recursosRepository;


        public RecursosController(IRecursosRepository recursosRepository)
        {
            this.recursosRepository = recursosRepository;
        }

        
        [HttpGet]
        public IHttpActionResult GetRecursos()
        {
            var recursos = recursosRepository.GetRecursos();
            return Ok(recursos);
        }

        [HttpGet]
        public IHttpActionResult GetRecursos(int id)
        {
            var recurso = recursosRepository.GetRecursos(id);
            if (recurso == null)
            {
                return NotFound();
            }
            return Ok(recurso);
        }

        [HttpPost]
        public IHttpActionResult PostRecurso([FromBody] Recursos recurso)
        {
            recursosRepository.CreateRecurso(recurso);
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult PutRecurso([FromBody] Recursos recurso)
        {
            var recursoExiste = recursosRepository.GetRecursos(recurso.Id);
            if (recursoExiste == null)
            {
                return NotFound();
            }
            else
            {
                recursoExiste = recurso;
            }

            recursosRepository.UpdateRecurso(recursoExiste, recurso.Id);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult DeleteRecurso(int id)
        {
            var recursoExiste = recursosRepository.GetRecursos(id);
            if (recursoExiste == null)
            {
                return NotFound();
            }
            recursosRepository.DeleRecurso(id);
            return Ok();
        }

    }
}
