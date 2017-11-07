using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        
        Response.Write("<br>");
        Response.Write(Server.MachineName.ToString());
        Response.Write("<br>");
        Response.Write(DateTime.Now.ToString());
        //Response.Write(b/a);

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int a = 0;
        int b = 1;

        var t = b / a;
    }
}