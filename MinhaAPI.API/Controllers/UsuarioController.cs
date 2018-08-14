using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MinhaAPI.Domain.Entidades;

namespace MinhaAPI.API.Controllers
{
   
    public class UsuarioController : ApiController
    {
        // GET api/<controller>
        
        [HttpGet]
        public IEnumerable<Usuario> Buscar()
        {
            var lista = new List<Usuario>();
            lista.Add(new Usuario()
            {
                UsuarioId = 1,
                Nome = "Anderson",
                Senha = "123456"
            });
            lista.Add(new Usuario()
            {
                UsuarioId = 2,
                Nome = "Gisele"
            });
            lista.Add(new Usuario()
            {
                UsuarioId = 3,
                Nome = "Eduardo"
            });
            lista.Add(new Usuario()
            {
                UsuarioId = 4,
                Nome = "Eloisia"
            });
            lista.Add(new Usuario()
            {
                UsuarioId = 5,
                Nome = "Antonio"
            });

            return lista;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}