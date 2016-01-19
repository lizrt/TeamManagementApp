using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;
using TeamManagement.Models;

namespace TeamManagement
{
    public partial class TeamPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Cache["Data"] != null)
            {
                Label1.Text = "From Cache";
                GridView1.DataSource = Cache["Data"];
                GridView1.DataBind();
            }
            else
            {
                Label1.Text = "From List";
                Employee emp = new Employee();
                GridView1.DataSource = emp.GetEmployees();
                GridView1.DataBind();
                Cache["Data"] = emp.GetEmployees();
                Cache.Insert("Data", emp.GetEmployees());
   CacheDependency cd = new CacheDependency(Server.MapPath("myfile.txt"));
   Cache.Insert("Data", emp.GetEmployees(), cd, DateTime.Now.AddSeconds(20), Cache.NoSlidingExpiration);

            }


            ////       throw new InvalidOperationException("An InvalidOperationException " +
            ////"occurred in the Page_Load handler .");
        }

        protected void ConfigLinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/NoPage.aspx");
        }

        protected void AppLinkButton1_Click(object sender, EventArgs e)
        {
            throw new InvalidOperationException("An InvalidOperationException " +
      "occurred in the Page_Load handler .");
        }
        private void Page_Error(object sender, EventArgs e)
        {
            // Get last error from the server.
            Exception exc = Server.GetLastError();

            // Handle specific exception.
            if (exc is InvalidOperationException)
            {
                // Pass the error on to the error page.
                Server.Transfer("ErrorPage.aspx?handler=Page_Error%20-%20Default.aspx",
                    true);
            }
        }

        protected void CodeLinkButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int y = 5;
                int c = y / 0;
            }
            catch (Exception ex)
            {
                // Log the exception.
                Server.Transfer("ErrorPage.aspx?handler=Code_Error",
                    true);
            }
        }
    }
}