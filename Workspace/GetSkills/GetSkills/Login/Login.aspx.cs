using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using MySql.Data.MySqlClient;

public partial class main_Login : System.Web.UI.Page
{
    protected void Login_Click(object sender, EventArgs e)
    {
        string connectionString = "Database=test;Data Source=localhost;User Id=root;Password=";  //?
        MySqlConnection dbconn = new MySqlConnection(connectionString);
        MySqlCommand cmd = dbconn.CreateCommand();

        try
        {
            cmd.Connection.Open();
            String str = "";
            int num;

            //check whether the user exists
            cmd.CommandText= "select count(USER_NAME) from USERS where USER_NAME=" + userName.Text
                + " and USER_PSWD='" + password.Text + "'";
            MySqlDataReader odr = cmd.ExecuteReader();
            odr.Read();
            str = odr["count(USER_NAME)"].ToString();
            odr.Close();
            num = Convert.ToInt16(str);
            if (num == 0)
            {
                error.Visible = true;
            }
            else
            {
                error.Visible = false;

                //check the role of the user
                cmd.CommandText = "select USER_TYPE from USERS where USER_NAME='" + userName.Text + "'";
                odr = cmd.ExecuteReader();
                odr.Read();
                str = odr["USER_TYPE"].ToString();
                odr.Close();
                Session["userID"] = userName.Text;

                //redirect
                if (str.Equals("ad"))
                {
                    Response.Redirect("CataLog_ad.aspx");
                }
                else
                {
                    Response.Redirect("CataLog_ma.aspx");
                }
            }
            userName.Text = "";
            password.Text = "";
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('The system is busy. Please try again later.')</script>");
        }
        finally
        {
            dbconn.Close();
        }
    }
}