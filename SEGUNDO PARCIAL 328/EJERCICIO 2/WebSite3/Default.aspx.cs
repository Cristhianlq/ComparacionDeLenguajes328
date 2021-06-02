using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ServiceReference1.WebServiceSoapClient sw = new ServiceReference1.WebServiceSoapClient();
        String ci = TextBox1.Text;
        GridView1.DataSource = sw.alumno(ci).Tables[0];
        GridView1.DataBind();
    }
}