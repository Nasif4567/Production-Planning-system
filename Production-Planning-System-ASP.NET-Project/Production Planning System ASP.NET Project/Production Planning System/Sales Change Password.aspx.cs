using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

public partial class Sales_Change_Password : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
    private void btnCancel_Click(object sender, System.EventArgs e)
    {
        txtUserName.Text = "";
        txtPassword.Text = "";
        txtNewPassword.Text = "";
    }

    private void btnChange_Click(object sender, System.EventArgs e)
    {
    //    if ((txtUserName.Text == "" | txtPassword.Text == "" | txtNewPassword.Text == ""))
    //    {
    //        Label1.Text = "You are not entered some of the required values. Plese Enter ";
    //    }
    //    else
    //    {
    //        //SqlConnection con = new SqlConnection();
    //        //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
    //        SqlCommand cmd = new SqlCommand("SELECT n_pwd FROM Login_Master WHERE user_name=@user_name", con);
    //        string curpword = null;
    //        SqlDataReader dr;
    //        SqlParameter pm;
    //        pm = cmd.Parameters.Add(new SqlParameter("@user_name", SqlDbType.NVarChar));
    //        pm.Value = (txtUserName.Text.Trim());
    //        con.Open();
    //        dr = cmd.ExecuteReader();
    //        if ((dr.Read()))
    //        {
    //            curpword = dr[0].ToString();
    //        }
    //        con.Close();
    //        if (((txtPassword.Text.Trim()) == curpword))
    //        {
    //            SqlCommand cmdudate = new SqlCommand("UPDATE Login_Master SET n_pwd=@n_pwd,o_pwd=@o_pwd WHERE user_name =@user_name ", con);
    //            pm = cmdudate.Parameters.Add(new SqlParameter("@n_pwd", SqlDbType.NVarChar));
    //            pm.Value =txtNewPassword.Text.Trim();
    //            pm = cmdudate.Parameters.Add(new SqlParameter("@user_name", SqlDbType.NVarChar));
    //            pm.Value = txtUserName.Text.Trim();
    //            pm = cmdudate.Parameters.Add(new SqlParameter("@o_pwd", SqlDbType.NVarChar));
    //            pm.Value = curpword.Trim();
    //            con.Open();
    //            try
    //            {
    //                cmdudate.ExecuteNonQuery();
    //            }
    //            catch (SqlException ex)
    //            {
    //                if (con.State == ConnectionState.Open)
    //                {
    //                    con.Close();
    //                }
    //            }
    //            Label1.Text = "Your password is successfully changed";
    //        }
    //        else
    //        {
    //            Label1.Text = "Enter valid username and current password";
    //        }
    //    }
    //}
    //private void Page_Load(object sender, System.EventArgs e)
    //{
    //    Label1.Text = "";
    //}
    //private void LinkButton1_Click(object sender, System.EventArgs e)
    //{
    //    FormsAuthentication.SignOut();
    //    Response.Redirect("LogInForm.aspx");
    }



    protected void btnChange_Click1(object sender, EventArgs e)
    {
 if ((txtUserName.Text == "" | txtPassword.Text == "" | txtNewPassword.Text == ""))
 {
     Label1.Text = "You are not entered some of the required values. Plese Enter ";
 }
 else
 {
     //SqlConnection con = new SqlConnection();
     //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
     SqlCommand cmd = new SqlCommand("SELECT n_pwd FROM Login_Master WHERE user_name=@user_name", con);
     string curpword = null;
     SqlDataReader dr;
     SqlParameter pm;
     pm = cmd.Parameters.Add(new SqlParameter("@user_name", SqlDbType.NVarChar));
     pm.Value = (txtUserName.Text.Trim());
     con.Open();
     dr = cmd.ExecuteReader();
     if ((dr.Read()))
     {
         curpword = dr[0].ToString();
     }
     con.Close();
     if (((txtPassword.Text.Trim()) == curpword))
     {
         SqlCommand cmdudate = new SqlCommand("UPDATE Login_Master SET n_pwd=@n_pwd,o_pwd=@o_pwd WHERE user_name =@user_name ", con);
         pm = cmdudate.Parameters.Add(new SqlParameter("@n_pwd", SqlDbType.NVarChar));
         pm.Value = txtNewPassword.Text.Trim();
         pm = cmdudate.Parameters.Add(new SqlParameter("@user_name", SqlDbType.NVarChar));
         pm.Value = txtUserName.Text.Trim();
         pm = cmdudate.Parameters.Add(new SqlParameter("@o_pwd", SqlDbType.NVarChar));
         pm.Value = curpword.Trim();
         con.Open();
         try
         {
             cmdudate.ExecuteNonQuery();
         }
         catch (SqlException ex)
         {
             if (con.State == ConnectionState.Open)
             {
                 con.Close();
             }
         }
         Label1.Text = "Your password is successfully changed";
     }
     else
     {
         Label1.Text = "Enter valid username and current password";
     }
 }
}
private void Page_Load(object sender, System.EventArgs e)
{
    Label1.Text = "";
}
private void LinkButton1_Click(object sender, System.EventArgs e)
{
    FormsAuthentication.SignOut();
    Response.Redirect("LogInForm.aspx");
    }
}
