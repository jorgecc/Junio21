using Junio21.ef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Junio21.dal
{
    // hagan lo mismo con ciudades
    public class PaisDAL
    {
        public static List<Paises> ListarTodo()
        {
            var resultado=new List<Paises>();
            using(var grupo=new ef.junio21Entities())
            {
                resultado=grupo.Paises.ToList();
            }
            return resultado;
        }
    }
}