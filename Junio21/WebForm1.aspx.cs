using Junio21.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Junio21
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // agreguemos una grilla en el formulario
            GridView1.DataSource=CiudadDAL.ListarTodo();
            GridView1.DataBind();
        }
    }
}