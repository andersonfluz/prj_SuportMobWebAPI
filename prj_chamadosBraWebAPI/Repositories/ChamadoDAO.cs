using prj_chamadosBraWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prj_chamadosBraWebAPI.Repositories
{
    public class ChamadoDAO
    {
        public List<Chamado> BuscarChamados()
        {
            using (var ctx = new ApplicationDbContext())
            {
                List<Chamado> chamados = (from e in ctx.Chamado select e).ToList();
                return chamados;
            }
        }

        public Chamado BuscarChamadoId(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                Chamado chamado = (from e in ctx.Chamado where e.Id == id select e).SingleOrDefault();
                return chamado;
            }
        }

        public Chamado DetalhesChamado(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                Chamado chamado = (from e in ctx.Chamado where e.Id == id select e).SingleOrDefault();
                return chamado;
            }
        }

        public Boolean salvarChamado(Chamado chamado)
        {
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Chamado.Add(chamado);
                ctx.SaveChanges();
                return true;
            }
        }
    }
}