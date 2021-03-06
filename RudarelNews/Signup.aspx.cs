﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace RudarelNews
{
    public partial class SIgnup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                SqlConnection objConnection = new SqlConnection(
                    ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);
                objConnection.Open();
                string strCheckUser = "select count(*) from Users where username='" + tbUsername.Text + "'";
                SqlCommand objSqlCommand = new SqlCommand(strCheckUser, objConnection);
                int nReturned = Convert.ToInt32(objSqlCommand.ExecuteScalar().ToString());
                if (nReturned == 1)
                {
                    //ToDo: change this with alert.
                    Response.Write("User already exists");
                }
                objConnection.Close();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection objConnection = new SqlConnection(
                    ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);

                Guid strGuid = Guid.NewGuid();

                string strFirstName = tbFirstName.Text;
                string strLastName = tbLastName.Text;
                string strUsername = tbUsername.Text;
                string strPass = tbPass.Text;
                string strEmail = tbEmail.Text;
                string strUserType = ddUserType.SelectedItem.Text;
                string strInsertQuery = "insert into Users (id, first_name, last_name, username, password, email, user_type) values ('" +
                     strGuid.ToString() + "','" +
                     strFirstName + "','" +
                     strLastName + "','" +
                     strUsername + "','" +
                     strPass + "','" +
                     strEmail + "','" +
                     strUserType + "')";

                SqlCommand objSqlCommand = new SqlCommand(strInsertQuery, objConnection);

                objSqlCommand.CommandType = System.Data.CommandType.Text;
                objSqlCommand.CommandText = strInsertQuery;
                objSqlCommand.Connection = objConnection;

                objSqlCommand.Parameters.AddWithValue("first_name", tbFirstName.Text);
                objSqlCommand.Parameters.AddWithValue("last_name", tbLastName.Text);
                objSqlCommand.Parameters.AddWithValue("username", tbUsername.Text);
                objSqlCommand.Parameters.AddWithValue("password", tbPass.Text);
                objSqlCommand.Parameters.AddWithValue("email", tbEmail.Text);
                objSqlCommand.Parameters.AddWithValue("user_type", ddUserType.SelectedItem.ToString());

                objConnection.Open();
                objSqlCommand.ExecuteNonQuery();
                Session["LoginUser"] = strUsername;
                Session["UserType"] = ddUserType.SelectedItem.ToString();

                lblSignup.Text = "Signup succesfull!";
                objConnection.Close();

                if (ddUserType.SelectedItem.ToString()=="Admin")
                {
                    //ToDo: Chenge with login response page.
                    Response.Redirect("Manager.aspx");
                }
                else
                {
                    Response.Redirect("User.aspx");
                }
            }
            catch (Exception ex)
            {
                lblSignup.Text = "Error: " + ex.ToString();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection objConnection = new SqlConnection(
                       ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);

                Guid strGuid = Guid.NewGuid();

                string strFirstName = tbFirstName.Text;
                string strLastName = tbLastName.Text;
                string strUsername = tbUsername.Text;
                string strPass = tbPass.Text;
                string strEmail = tbEmail.Text;
                string strUserType = ddUserType.SelectedItem.Text;
                string strInsertQuery = "DELETE FROM Users";

                SqlCommand objSqlCommand = new SqlCommand(strInsertQuery, objConnection);

                objSqlCommand.CommandType = System.Data.CommandType.Text;
                objSqlCommand.CommandText = strInsertQuery;
                objSqlCommand.Connection = objConnection;

                objConnection.Open();
                objSqlCommand.ExecuteNonQuery();

                Response.Redirect("Login.aspx");

                objConnection.Close();
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.ToString());
            }
        }
    }
}