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

public partial class ChangePassword : System.Web.UI.Page
{
    //[System.Diagnostics.DebuggerStepThrough()]
    SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");

    private void InitializeComponent()
    {
    }
    ////protected System.Web.UI.WebControls.Label Label2;
    ////protected System.Web.UI.WebControls.Button btnChange;
    //protected System.Web.UI.WebControls.Button btnCancel;
    //protected System.Web.UI.WebControls.Label Label3;
    //protected System.Web.UI.WebControls.Label Label4;
    //protected System.Web.UI.WebControls.Label Label5;
    //protected System.Web.UI.WebControls.TextBox txtNewPassword;
    //protected System.Web.UI.WebControls.TextBox txtPassword;
    //protected System.Web.UI.WebControls.TextBox txtUserName;
    //protected System.Web.UI.WebControls.Label Label1;
    //private object designerPlaceholderDeclaration;
    protected void Page_Load(object sender, EventArgs e)
    {
        txtUserName.Text = Session["username"].ToString();
        SqlDataAdapter da = new SqlDataAdapter("SELECT n_pwd FROM Login_Master WHERE user_name='" + Session["username"] + "'", con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        string a = ds.Tables[0].Rows[0][0].ToString();
        txtPassword.Text = a.ToString();  
    }

    private void Page_Init(object sender, System.EventArgs e)
    {
        //InitializeComponent();
    }

    private void btnCancel_Click(object sender, System.EventArgs e)
    {
        txtUserName.Text = "";
        txtPassword.Text = "";
        txtNewPassword.Text = "";
    }

    private void btnChange_Click(object sender, System.EventArgs e)
    {
        //if ((txtUserName.Text == "" | txtPassword.Text == "" | txtNewPassword.Text == "")) {
        //  Label1.Text = "You are not entered some of the required values. Plese Enter ";
        //} else {
        //  //SqlConnection con = new SqlConnection();
        // // SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        //  SqlCommand cmd = new SqlCommand("SELECT n_pwd FROM Login_Master WHERE user_name=@user_name", con);
        //  string curpword = null;
        //  SqlDataReader dr;
        //  SqlParameter pm;
        //  pm = cmd.Parameters.Add(new SqlParameter("@user_name", SqlDbType.NVarChar));
        //  pm.Value = (txtUserName.Text.Trim());
        //  con.Open();
        //  dr = cmd.ExecuteReader();
        //  if ((dr.Read())) {
        //    curpword = dr[0].ToString();

        //  }
        //  con.Close();
        //  if (((txtPassword.Text.Trim()) == curpword)) {
        //    SqlCommand cmdudate = new SqlCommand("UPDATE Login_Master SET n_pwd=@n_pwd,o_pwd=@o_pwd WHERE user_name =@user_name ", con);
        //    pm = cmdudate.Parameters.Add(new SqlParameter("@n_pwd", SqlDbType.NVarChar));
        //    pm.Value = (txtNewPassword.Text.Trim());
        //    pm = cmdudate.Parameters.Add(new SqlParameter("@user_name", SqlDbType.NVarChar));
        //    pm.Value = (txtUserName.Text.Trim());
        //    pm = cmdudate.Parameters.Add(new SqlParameter("@o_pwd", SqlDbType.NVarChar));
        //    pm.Value = (curpword.Trim());
        //    con.Open();
        //    try {
        //      cmdudate.ExecuteNonQuery();
        //    } catch (SqlException ex) {
        //      if (con.State == ConnectionState.Open) {
        //        con.Close();
        //      }
        //    }
        //    Label1.Text = "Your password is successfully changed";
        //  } else {
        //    Label1.Text = "Enter valid username and current password";
        //  }
        //}
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
            // SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
            
            SqlDataAdapter da =new SqlDataAdapter("SELECT n_pwd FROM Login_Master WHERE user_name='" + txtUserName.Text + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            string a = ds.Tables[0].Rows[0][0].ToString();
            if (a == txtNewPassword.Text)
            {
                string s = "U R New PASSWORD IS SIMILAR TO OLDPASSWORD";
                this.RegisterStartupScript("clientscript", "<html><body><script>alert('" + s + "')</script></body></html>");
             }
            else
            {
                SqlCommand cmd1 = new SqlCommand("update Login_Master set o_pwd='" + a + "',n_pwd='" + txtNewPassword.Text + "' where user_name= '" + txtUserName.Text + "'", con);
                con.Open();
                cmd1.ExecuteNonQuery();
                string s = "U R PASSWORD HAS BEEN CHANGED";
                this.RegisterStartupScript("clientscript", "<html><body><script>alert('" + s + "')</script></body></html>");
                con.Close();
            }

            //pm = cmd.Parameters.Add(new SqlParameter("@user_name", SqlDbType.NVarChar));
            //pm.Value = (txtUserName.Text.Trim());
            //con.Open();
            //dr = cmd.ExecuteReader();
            //if ((dr.Read()))
            //{
            //    curpword = dr[0].ToString();

            //}
            //con.Close();
            //    //if (((txtPassword.Text.Trim()) == curpword))
            //    {
            //        SqlCommand cmdudate = new SqlCommand("UPDATE Login_Master SET n_pwd=@n_pwd,o_pwd=@o_pwd WHERE user_name =@user_name ", con);
            //        pm = cmdudate.Parameters.Add(new SqlParameter("@n_pwd", SqlDbType.NVarChar));
            //        pm.Value = (txtNewPassword.Text.Trim());
            //        pm = cmdudate.Parameters.Add(new SqlParameter("@user_name", SqlDbType.NVarChar));
            //        pm.Value = (txtUserName.Text.Trim());
            //        pm = cmdudate.Parameters.Add(new SqlParameter("@o_pwd", SqlDbType.NVarChar));
            //        pm.Value = (curpword.Trim());
            //        con.Open();
            //        try
            //        {
            //            cmdudate.ExecuteNonQuery();
            //        }
            //        catch (SqlException ex)
            //        {
            //            if (con.State == ConnectionState.Open)
            //            {
            //                con.Close();
            //            }
            //        }
            //        Label1.Text = "Your password is successfully changed";
            //    }
            //    else
            //    {
            //        Label1.Text = "Enter valid username and current password";
            //    }
            //}
        }
    }

    protected void btnCancel_Click1(object sender, EventArgs e)
    {

    }
}