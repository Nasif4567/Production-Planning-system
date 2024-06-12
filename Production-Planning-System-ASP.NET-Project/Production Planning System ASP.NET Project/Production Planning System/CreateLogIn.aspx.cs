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

public partial class CreateLogIn : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
    SqlDataReader dr;
    private void Page_Init(object sender, System.EventArgs e)
    {
        //InitializeComponent();
    }
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, System.EventArgs e)
    {
        Label1.Text = "";
        if (!(Page.IsPostBack))
        {
         //   SqlConnection con = new SqlConnection();
            //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
            SqlCommand cmd = new SqlCommand("SELECT emp_no from Employee_Master", con);
            SqlDataReader dr;
            con.Open();
            dr = cmd.ExecuteReader();
            if (!IsPostBack)
            {
                ddlEmpID.DataSource = dr;
                ddlEmpID.DataTextField = "emp_no";
                ddlEmpID.DataValueField = "emp_no";
                ddlEmpID.DataBind();
            }
            con.Close();
            //SqlParameter pm;
            //con.Open();
            //try
            //{
            //    dr = cmd.ExecuteReader();
            //}
            //catch (SqlException ex)
            //{
            //    if (con.State == ConnectionState.Open)
            //    {
            //        con.Close();
            //    }
            //}
            ////bool state = true;
            ////while ((dr.Read()))
            ////{
            ////    ddlEmpID.Items.Add(dr[0].ToString());
            ////    if ((state))
            ////    {
            ////        txtEmpName.Text = dr[1].ToString() ;
            ////    }
            ////}
            //con.Close();
            //dr.Close();
            ////DataBind();
            //bindgrid();
        }
    }
    protected void ddlEmpID_SelectedIndexChanged(object sender, System.EventArgs e)
    {
       //// SqlConnection con = new SqlConnection();
       // SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
       // SqlCommand cmd = new SqlCommand("SELECT emp_name from Employee_Master where emp_no=@emp_no", con);
       // //SqlDataReader dr;
       // SqlParameter pm;
       // pm = cmd.Parameters.Add(new SqlParameter("@emp_no", SqlDbType.Int));
       // pm.Value = Convert.ToInt32(ddlEmpID.SelectedItem.Text);
       // con.Open();
       // try
       // {
       //     dr = cmd.ExecuteReader();
       // }
       // catch (SqlException ex)
       // {
       //     if (con.State == ConnectionState.Open)
       //     {
       //         con.Close();
       //     }
       // }
       // while(dr.Read())
       // {
       //     txtEmpName.Text = dr[0].ToString();
       // }
       // con.Close();
    }

    private void btnClear_Click(object sender, System.EventArgs e)
    {
        //txtLoginName.Text = "";
        //txtPassword.Text = "";
        //txtConPassword.Text = "";
    }

    private void btnCreateLogIn_Click(object sender, System.EventArgs e)
    {
        //if ((txtLoginName.Text == "" | txtPassword.Text == "" | txtConPassword.Text == ""))
        //{
        //    Label1.Text = "You were not entered some of the required values. Please Enter";
        //}
        //else
        //{
        //   // SqlConnection con = new SqlConnection();
        //    SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        //    string sql = "INSERT INTO Login_Master (user_name,emp_id,n_pwd) VALUES(@user_name,@emp_id,@n_pwd)";
        //    SqlCommand cmd = new SqlCommand(sql, con);
        //    SqlParameter pm;
        //    pm = cmd.Parameters.Add(new SqlParameter("@user_name", SqlDbType.NVarChar));
        //    pm.Value = txtLoginName.Text;
        //    pm = cmd.Parameters.Add(new SqlParameter("@emp_id", SqlDbType.Int));
        //    pm.Value = Convert.ToInt16(ddlEmpID.SelectedItem.Text);
        //    pm = cmd.Parameters.Add(new SqlParameter("@n_pwd", SqlDbType.VarChar));
        //    pm.Value = txtPassword.Text;
        //    try
        //    {
        //        con.Open();
        //    }
        //    catch (SqlException ex)
        //    {
        //    }
        //    try
        //    {
        //        cmd.ExecuteNonQuery();
        //    }
        //    catch (SqlException ex)
        //    {
        //        if (con.State == ConnectionState.Open)
        //        {
        //            con.Close();
        //        }
        //    }
        //    con.Close();
        //    txtLoginName.Text = "";
        //    txtPassword.Text = "";
        //    txtConPassword.Text = "";
        //    bindgrid();
        //}
    }

    private void bindgrid()
    {
        //SqlDataAdapter da=new SqlDataAdapter("SELECT Login_Master.user_name,Login_Master.emp_id,Employee_Master.emp_name FROM Employee_Master inner join Login_Master on Employee_Master.emp_no=Login_Master.emp_id", con);
        //con.Open();
        //DataSet ds=new DataSet();
        //da.Fill(ds);
        //GridView1.DataSource=ds;
        //GridView1.DataBind();
        //con.Close();
    }

    //    //SqlConnection con = new SqlConnection();
    //    SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
    //    SqlCommand cmd = new SqlCommand("SELECT Login_Master.user_name,Login_Master.emp_id,Employee_Master.emp_name FROM Employee_Master inner join Login_Master on Employee_Master.emp_no=Login_Master.emp_id", con);
    //    SqlDataAdapter da = new SqlDataAdapter(cmd);
    //    try
    //    {
    //        da.Fill(ds);
    //    }
    //    catch (SqlException ex)
    //    {
    //    }
    //    Datagrid1.DataSource = ds.Tables[0];
    //    Datagrid1.DataBind();
    //    con.Close();
    //    cmd = null;
    //    Datagrid1.Visible = true;
    protected void  btnClear_Click1(object sender, EventArgs e)
{
        txtLoginName.Text = "";
        txtPassword.Text = "";
        txtConPassword.Text = "";

}

    //void DataGrid1_Delete(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
    //{
    //    //SqlConnection con = new SqlConnection();
    //    SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
    //    string value = e.Item.Cells[1].Text;
    //    string sql = "DELETE FROM Login_Master WHERE user_name='" + value + "'";
    //    SqlCommand cmd = new SqlCommand(sql, con);
    //    try
    //    {
    //        con.Open();
    //    }
    //    catch (SqlException ex)
    //    {
    //    }
    //    try
    //    {
    //        cmd.ExecuteNonQuery();
    //    }
    //    catch (SqlException ex)
    //    {
    //        if (con.State == ConnectionState.Open)
    //        {
    //            con.Close();
    //        }
    //    }
    //    con.Close();
    //    cmd = null;
    //    bindgrid();
    //}

    //private void Datagrid1_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
    //{
    //    Datagrid1.CurrentPageIndex = e.NewPageIndex;
    //    bindgrid();
    //}

    protected void btnCreateLogIn_Click1(object sender, EventArgs e)
    {
        if ((txtLoginName.Text == "" | txtPassword.Text == "" | txtConPassword.Text == ""))
        {
            Label1.Text = "You were not entered some of the required values. Please Enter";
        }
        else
        {
            // SqlConnection con = new SqlConnection();
            //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
            string sql = "INSERT INTO Login_Master (user_name,emp_id,n_pwd) VALUES(@user_name,@emp_id,@n_pwd)";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlParameter pm;
            pm = cmd.Parameters.Add(new SqlParameter("@user_name", SqlDbType.NVarChar));
            pm.Value = txtLoginName.Text;
            pm = cmd.Parameters.Add(new SqlParameter("@emp_id", SqlDbType.Int));
            pm.Value = Convert.ToInt16(ddlEmpID.SelectedItem.Text);
            pm = cmd.Parameters.Add(new SqlParameter("@n_pwd", SqlDbType.VarChar));
            pm.Value = txtPassword.Text;
            try
            {
                con.Open();
            }
            catch (SqlException ex)
            {
            }
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            con.Close();
            txtLoginName.Text = "";
            txtPassword.Text = "";
            txtConPassword.Text = "";
            bindgrid();
        }
    }
    //protected void btnClear_Click1(object sender, EventArgs e)
    //{
    //    txtLoginName.Text = "";
    //    txtPassword.Text = "";
    //    txtConPassword.Text = "";
    //}
    protected void ddlEmpID_SelectedIndexChanged1(object sender, EventArgs e)
    {
    }

    protected void ddlEmpID_SelectedIndexChanged2(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        SqlDataAdapter DA = new SqlDataAdapter("SELECT emp_name from Employee_Master where emp_no=" + ddlEmpID.SelectedValue + "", con);
        DataSet DS = new DataSet();
        con.Open();
        DA.Fill(ds);
        txtEmpName.Text = ds.Tables[0].Rows[0][0].ToString();
        con.Close();



    }
}
