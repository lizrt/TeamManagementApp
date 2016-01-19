using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TeamManagement.Models;

namespace TeamManagement
{
    public partial class LoginUC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public delegate void ClickHandler(object sender, EventArgs e);
        public event ClickHandler LoginClick;

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Employee employ = new Employee();
            List<Employee> empList = employ.GetEmployees();
            foreach (var emp in empList)
            {
                if (txtusrname.Text == emp.Username && txtpw.Text == emp.Password)
                {
                    lblmsg.Visible = false;
                    Session["Username"] = emp.Username;
                    Session["Password"] = emp.Password;
                    Session["Teamname"] = emp.Teamname;
                }
                else
                {
                    lblmsg.Visible = true;
                    lblmsg.Text = "Incorrect Login";
                }
            }
            LoginClick(sender, e);
        }
    }
}