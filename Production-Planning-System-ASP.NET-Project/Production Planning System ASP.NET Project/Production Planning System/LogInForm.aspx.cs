using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class LogInForm : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
    
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    private void btnCancel_Click(object sender, System.EventArgs e)
    {
        txtUserName.Text = "";
        txtPassword.Text = "";
    }

    private void btnLogIn_Click(object sender, System.EventArgs e)
    {
        if (!((txtUserName.Text == "" | txtPassword.Text == "")))
        {
            //SqlConnection con = new SqlConnection();
            //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
            SqlCommand cmd = new SqlCommand("SELECT n_pwd,emp_id FROM Login_Master WHERE user_name=@user_name", con);
            string curpword = null;
            SqlDataReader dr;
            SqlParameter pm;
            pm = cmd.Parameters.Add(new SqlParameter("@user_name", SqlDbType.NVarChar));
            pm.Value = (txtUserName.Text.Trim());
            con.Open();
            dr = cmd.ExecuteReader();
            if ((dr.Read()))
            {
                if (dr[0] == (txtPassword.Text.Trim()))
                {
                    Session["empno"] = dr[1];
                    con.Close();
                    definerole();
                }
                else
                {
                    Label1.Text = "Please enter valid password";
                }
            }
            else
            {
                Label1.Text = "Please enter valid username and password";
            }
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        else
        {
            Label1.Text = "Please Enter username and password";
        }
    }

    private void definerole()
    {
        //SqlConnection con = new SqlConnection();
        //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        SqlDataAdapter Da = new SqlDataAdapter("select role_desc from roles where role_id in(select role_id from User_Roles where user_name='"+txtUserName.Text+ "')", con);
        DataSet  ds = new DataSet();
        con.Open();
        Da.Fill(ds);
        
        if (ds.Tables[0].Rows[0][0].ToString() == "Admin")
        {
            Response.Redirect("Admin Content.htm");
        }
        else if (ds.Tables[0].Rows[0][0].ToString() == "SOI")
        {


            Response.Redirect("SalesOffice.aspx");
        }
        else if (ds.Tables[0].Rows[0][0].ToString() == "MI")
        {
            Response.Redirect("Market Content.htm");
        }
    }

    protected void btnLogIn_Click2(object sender, EventArgs e)
    {
        if (!((txtUserName.Text == "" | txtPassword.Text == "")))
        {
            //SqlConnection con = new SqlConnection();
            //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
            SqlDataAdapter Da =new SqlDataAdapter("SELECT * FROM Login_Master WHERE user_name='"+txtUserName.Text+"' and n_pwd='"+txtPassword.Text+"'", con);
            DataSet ds = new DataSet();
            con.Open();
            Da.Fill(ds);
            //string i = ds.Tables[0].Rows.Count;  
            if (ds.Tables[0].Rows.Count>0)
            {
                // string curpword = null;
                //SqlParameter pm;
                //pm = cmd.Parameters.Add(new SqlParameter("@user_name", SqlDbType.NVarChar));
                // pm.Value = (txtUserName.Text.Trim());

                //if ((dr.Read()))
                //{
                //    if (dr[0] == (txtPassword.Text.Trim()))
                //    {
                Session["empno"] = ds.Tables[0].Rows[0][1].ToString();
                Session["username"] = ds.Tables[0].Rows[0][0].ToString();  
  
                con.Close();
                definerole();
            }

            else
            {
                Label1.Text = "Please enter valid password";
            }
            }
            else
            {
                Label1.Text = "Please enter valid username and password";
            }
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        
        else
        {
            Label1.Text = "Please Enter username and password";
        }
    }
}

