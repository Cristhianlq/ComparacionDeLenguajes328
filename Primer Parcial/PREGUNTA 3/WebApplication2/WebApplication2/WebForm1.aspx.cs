using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string nombre, apellido, php_Time;
            nombre = Request.QueryString["name"];
            apellido = Request.QueryString["last_name"];
            php_Time = Request.QueryString["php_time"];
            Response.Write("<title>.NET-Pregunta 3</title>");
            Response.Write("<h1>Esto es .NET:</h1>");
            Response.Write("<h3> Hola " + nombre + " " + apellido + "</h3>");
            Response.Write("<br> Tiempo PHP: " + php_Time);
            String net_Time = DateTime.Now.ToString("dd/MM/yyyy") + " " + DateTime.Now.ToLongTimeString();
            Response.Write("<br>Tiempo Net: " + net_Time);
            if (nombre != null && apellido != null && php_Time != null && net_Time != null)
            {
                nombre = nombre.Replace(" ", "-");
                apellido = apellido.Replace(" ", "-");
                php_Time = php_Time.Replace(" ", "-");
                net_Time = net_Time.Replace(" ", "-");
            }
            Response.Write("<form method='GET' action='http://localhost:8787/Java_Netbeans/NewServlet'><input type = 'hidden' name = 'name_Net' value = " + nombre + "><input type = 'hidden' name = 'last_name_Net' value = " + apellido + "><input type = 'hidden' name = 'php_time_Net' value = " + php_Time + "><input type = 'hidden' name = 'net_time' value = " + net_Time + "><br/> <br/><input type = 'submit' name = 'Enviar'/></form> <br><br>" + net_Time.Replace("-", " "));

        }
    }
}