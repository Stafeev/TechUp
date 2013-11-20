﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
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
                if (Membership.GetUser(email) == null)
                {
                    Alert.Show("Пользователь не найден!");
                    return;
                }
                FormsAuthentication.SetAuthCookie(email, true);
                try
                {
                    Roles.AddUserToRole(email, Global.customerRole);
                }
                catch (Exception ex)
                {
                    ///current current user has been already registered as customer
                }
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
                if (Membership.GetUser(email) == null)
                {
                    Alert.Show("Пользователь не найден!");
                    return;
                }
                FormsAuthentication.SetAuthCookie(email, true);
                try
                {
                    Roles.AddUserToRole(email, Global.contractorRole);
                }
                catch (Exception ex)
                {
                    ///current current user has been already registered as contractor
                }
                Response.Redirect("../CreatePlan.aspx");
            }
            else
            {
                Session["UserAuthentication"] = "";
                Alert.Show("Неверное имя пользователя или пароль!");
            }
            con.Close();
        }
         protected void registerCustomer(object sender, EventArgs e)
         {
             string name = CustomerName.Text;
             string email = CustomerEmail.Text;
             string pas = CustomerPassword.Text;
             string pas2 = CustomerPassword2.Text;
             if (!pas.Equals(pas2))
             {
                 Alert.Show("Пароли не совпадают!");
                 return;
             }
              if (name == "" || email == "" || pas == ""
             || pas2 == "")
            {
                Alert.Show("Пожалуйста, заполните все поля");
                return;
            }
              if (pas.Length < 6)
              {
                  Alert.Show("Пароль должен состоять не менее чем из 6 символов");
                  return;
              }
            var db = new DBClassesDataContext();


               Customer c = new Customer { Name = name, Email = email, Password = pas, Info = "", Address=""};
                db.Customers.InsertOnSubmit(c);
            try
            {
                db.SubmitChanges();                
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Ошибка", "нет записи", true);
                System.Diagnostics.Debug.Print(ex.StackTrace);
                return;
            }
            try
            {
                Membership.CreateUser(email, pas);
                FormsAuthentication.SetAuthCookie(email, true);
                Roles.AddUserToRole(email, Global.customerRole);
                Response.Redirect("../ViewPlan.aspx");
                //Alert.Show("Запись успешно добавлена");
            }
            catch (Exception ex)
            {
                Alert.Show("Пользователь с таким email уже зарегистрирован!");
            }            
         }
         protected void registerContractor(object sender, EventArgs e)
         {
             string name = ContracorName.Text;
             string email = ContracorEmail.Text;
             string pas = ContracorPassword.Text;
             string pas2 = ContracorPassword2.Text;
             if (!pas.Equals(pas2))
             {
                 Alert.Show("Пароли не совпадают!");
                 return;
             }
             
             if (name == "" || email == "" || pas == ""
   || pas2 == "")
             {
                 Alert.Show("Пожалуйста, заполните все поля");
                 return;
             }
             if (pas.Length < 6)
             {
                 Alert.Show("Пароль должен состоять не менее чем из 6 символов");
                 return;
             }
             var db = new DBClassesDataContext();


             Contractor c = new Contractor { Name = name, Email = email, Password = pas, Address="", Info="" };
             db.Contractors.InsertOnSubmit(c);
             try
             {
                 db.SubmitChanges();                 
             }
             catch
             {
                 ClientScript.RegisterStartupScript(this.GetType(), "Ошибка", "нет записи", true);
                 return;
             }
             
             try
             {
                 Membership.CreateUser(email, pas);
                 FormsAuthentication.SetAuthCookie(email, true);
                 Roles.AddUserToRole(email, Global.contractorRole);
                 Response.Redirect("../createPlan.aspx");
             }
             catch (Exception ex)
             {
                 Alert.Show("Пользователь с таким email уже зарегистрирован!");
             }
             
             //Alert.Show("Запись успешно добавлена");
         }
    }
}