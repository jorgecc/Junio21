using Junio21.ef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Junio21.dal
{
    // hagan lo mismo con ciudades
    public class CiudadDAL
    {
        public static List<Ciudades> ListarTodo()
        {
            var resultado=new List<Ciudades>();
            using(var grupo=new ef.junio21Entities())
            {
                grupo.Configuration.ProxyCreationEnabled=true;
                resultado=grupo.Ciudades
                    .Include("Paises")
                    .Include("Paises.Continentes")
                    .ToList();
            } // cerro
            return resultado;
        }
    }
}