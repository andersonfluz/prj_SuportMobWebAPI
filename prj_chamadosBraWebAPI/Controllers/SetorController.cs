using prj_chamadosBraWebAPI.Models;
using prj_chamadosBraWebAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace prj_chamadosBraWebAPI.Controllers
{
    public class SetorController : ApiController
    {
        // GET api/chamado
        public IEnumerable<Setor> Get()
        {
            return new SetorDAO().BuscarSetores();
        }

        // GET api/chamado/5
        public Setor Get(int id)
        {
            return new SetorDAO().DetalhesSetor(id);
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
