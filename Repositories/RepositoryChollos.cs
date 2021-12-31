using MvcChollos2.Data;
using MvcChollos2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcChollos2.Repositories
{
    public class RepositoryChollos
    {
        ChollosContext context;
        public RepositoryChollos()
        {
            this.context = new ChollosContext();
        }

        public List<Chollo> GetChollos()
        {
            var consulta = from datos in context.Chollos
                           orderby datos.IdChollo descending
                           select datos;
            return consulta.ToList();
        }
    }
}