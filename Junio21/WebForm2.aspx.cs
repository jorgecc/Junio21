using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Junio21
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Panel1.Visible=false; // ocultamos el panel
            TextBox1.Enabled=false; // desabilitamos el cuadro de texto
            TextBox2.ReadOnly=true; // dejamos el texto solo como lectura

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (IsValid) // validacion es correcta o no (si es clientside=true)
            {
                var controlNuevo=new Literal(); // texto a la pagina
                controlNuevo.Text="el objeto es valido";
                Panel1.Controls.Add(controlNuevo);
                var texto=new TextBox();
                Panel1.Controls.Add(texto); // al final del panel
                form1.Controls.Add(texto); // al final de la pagina

            } else
            {
                var controlNuevo = new Literal();
                controlNuevo.Text = "el objeto no es valido";
                Panel1.Controls.Add(controlNuevo);
            }
        }
    }
}