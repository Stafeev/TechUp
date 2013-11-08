using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;
using PlanViewer.Models;

namespace PlanViewer
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*RegisterHyperLink.NavigateUrl = "Register";
            OpenAuthLogin.ReturnUrl = Request.QueryString["ReturnUrl"];

            var returnUrl = HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
            if (!String.IsNullOrEmpty(returnUrl))
            {
                RegisterHyperLink.NavigateUrl += "?ReturnUrl=" + returnUrl;
            }*/
        }

        protected void Customer_Authenticate(object sender, AuthenticateEventArgs e)
        {            
            string email = Customer.UserName;
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrEmpty(email))
            {
                Alert.Show("Некорректное имя пользователя!");
                return;
            }
            string pass = Customer.Password;
            if (string.IsNullOrWhiteSpace(pass) || string.IsNullOrEmpty(pass))
            {
                Alert.Show("Введите пароль!");
                return;
            }
            
            string connectionStr = WebConfigurationManager.ConnectionStrings["TeamProjectDBConnectionString1"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionStr);
            con.Open();
            string sqlUserName = "SELECT email,password FROM Customer WHERE email ='" + email + "' AND password ='" + pass + "'";
            SqlCommand cmd = new SqlCommand(sqlUserName, con);
            string CurrentName;
            CurrentName = (string)cmd.ExecuteScalar();
            if (CurrentName != null)
            {
                Session["UserAuthentication"] = email;
                Session.Timeout = 1;
                Response.Redirect("../ViewPlan.aspx");
            }
            else
            {
                Session["UserAuthentication"] = "";
            }
            con.Close();
        }

        protected void Contractor_Authenticate(object sender, AuthenticateEventArgs e)
        {
            string email = Contractor.UserName;
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrEmpty(email))
            {
                Alert.Show("Некорректное имя пользователя!");
                return;
            }
            string pass = Contractor.Password;
            if (string.IsNullOrWhiteSpace(pass) || string.IsNullOrEmpty(pass))
            {
                Alert.Show("Введите пароль!");
                return;
            }

            string connectionStr = WebConfigurationManager.ConnectionStrings["TeamProjectDBConnectionString1"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionStr);
            con.Open();
            string sqlUserName = "SELECT email,password FROM Contractor WHERE email ='" + email + "' AND password ='" + pass + "'";
            SqlCommand cmd = new SqlCommand(sqlUserName, con);
            string CurrentName;
            CurrentName = (string)cmd.ExecuteScalar();
            if (CurrentName != null)
            {
                Session["UserAuthentication"] = email;
                Session.Timeout = 1;
                Response.Redirect("../CreatePlan.aspx");
            }
            else
            {
                Session["UserAuthentication"] = "";
            }
            con.Close();
        }
    }
}