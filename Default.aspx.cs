using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login_asp.net_web_app
{
    public partial class _Default : Page
    {
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Here you would typically validate against a database
            if (ValidateUser(username, password))
            {
                // Redirect to another page on successful login
                Response.Redirect("Home.aspx");
            }
            else
            {
                lblMessage.Text = "Invalid username or password.";
            }
        }

        private bool ValidateUser(string username, string password)
        {
            // Replace with your actual user validation logic
            return username == "admin" && password == "password"; // Example credentials
        }
    }
}