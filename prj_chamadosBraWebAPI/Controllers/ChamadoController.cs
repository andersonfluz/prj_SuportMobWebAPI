using prj_chamadosBraWebAPI.Models;
using prj_chamadosBraWebAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace prj_chamadosBraWebAPI.Controllers
{
    public class ChamadoController : ApiController
    {
        // GET api/chamado
        public IEnumerable<Chamado> Get()
        {
            return new ChamadoDAO().BuscarChamados();
        }

        // GET api/chamado/5
        public Chamado Get(int id)
        {
            return new ChamadoDAO().BuscarChamadoId(id);
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
