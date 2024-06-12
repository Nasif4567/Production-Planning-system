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

public partial class AssignRoles : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!(Page.IsPostBack))
        {
            //SqlConnection con = new SqlConnection();
            //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
            SqlCommand cmd = new SqlCommand("SELECT user_name from Login_Master", con);
            //SqlDataReader dr;
            SqlParameter pm;
            DataSet ds = new DataSet();
            con.Open();
            try
            {
                dr = cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            while (dr.Read())
            {
                ddlLoginName.Items.Add(dr[0].ToString());
                            }
            con.Close();
            dr.Close();
            cmd.CommandText = "SELECT role_desc FROM Roles";
            con.Open();
            dr = cmd.ExecuteReader();
            while ((dr.Read()))
            {
                ddlRoles.Items.Add(dr[0].ToString());
            }
            con.Close();
            dr.Close();
            //bindgrid();

        }
    }
 //       void DataGrid1_Delete(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
 //{
 //  //SqlConnection con = new SqlConnection();
 //  //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
 //  string value = e.Item.Cells[1].Text;
 //  string sql = "DELETE FROM User_Roles WHERE user_name='" + value + "'";
 //  SqlCommand cmd = new SqlCommand(sql, con);
 //  try {
 //    con.Open();
 //  } 
 //  catch (SqlException )
 //  {
 //  }
 //  try 
 //  {
 //    cmd.ExecuteNonQuery();
 //  }
 //  catch (SqlException ) 
 //  {
 //    if (con.State == ConnectionState.Open)
 //    {
 //      con.Close();
 //    }
 //  }
 //  con.Close();
 //  cmd = null;
 //  bindgrid();
 //}

 //private void bindgrid()
 //{
 //  //SqlConnection con = new SqlConnection();
 //  //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
 //  SqlCommand cmd = new SqlCommand("SELECT Employee_Master.emp_name, Login_Master.user_name, roles.role_desc FROM Employee_Master INNER JOIN Login_Master ON Employee_Master.emp_no = Login_Master.emp_id INNER JOIN User_Roles ON Login_Master.user_name = User_Roles.user_name INNER JOIN roles ON User_Roles.role_id = roles.role_id", con);
 //  SqlDataAdapter da = new SqlDataAdapter(cmd);
 //  DataSet ds = new DataSet();
 //  da.Fill(ds);
 //  Datagrid1.DataSource = ds.Tables[0];  
 //  //Datagrid1.DataSource = ds.Tables[0];
 //  Datagrid1.DataBind(); 
 //  con.Close();
 //  cmd = null;
 //}

 private void btnAssignRole_Click(object sender, System.EventArgs e)
 {
   //SqlConnection con = new SqlConnection();
   //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
   string sql = "INSERT INTO User_Roles(user_name,role_id)VALUES(@user_name,@role_id)";
   string sqlval = "SELECT role_id FROM Roles WHERE role_desc='" + ddlRoles.SelectedItem.Text + "'";
   SqlCommand cmd = new SqlCommand(sqlval, con);
   con.Open();
   int role_id = Convert.ToInt32(cmd.ExecuteScalar());
   con.Close();
   cmd.CommandText = sql;
   SqlParameter pm;
   pm = cmd.Parameters.Add(new SqlParameter("@user_name", SqlDbType.NVarChar));
   pm.Value = ddlLoginName.SelectedItem.Text;
   pm = cmd.Parameters.Add(new SqlParameter("@role_id", SqlDbType.Int));
   pm.Value = role_id;
   con.Open();
   cmd.ExecuteNonQuery();
   con.Close();
  // bindgrid();
   cmd = null;
 }


    protected void btnAssignRole_Click1(object sender, EventArgs e)
    {
        string sql = "INSERT INTO User_Roles(user_name,role_id)VALUES(@user_name,@role_id)";
        string sqlval = "SELECT role_id FROM Roles WHERE role_desc='" + ddlRoles.SelectedItem.Text + "'";
        SqlCommand cmd = new SqlCommand(sqlval, con);
        con.Open();
        int role_id = Convert.ToInt32(cmd.ExecuteScalar());
        con.Close();
        cmd.CommandText = sql;
        SqlParameter pm;
        pm = cmd.Parameters.Add(new SqlParameter("@user_name", SqlDbType.NVarChar));
        pm.Value = ddlLoginName.SelectedItem.Text;
        pm = cmd.Parameters.Add(new SqlParameter("@role_id", SqlDbType.Int));
        pm.Value = role_id;
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
       // bindgrid();
        cmd = null;

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["user_name"] = GridView1.SelectedValue.ToString();     
    }
}

