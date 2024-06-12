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

public partial class DepartmentMaster : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");

    private void Page_Init(object sender, System.EventArgs e)
    {
        //InitializeComponent();
    }
    DataSet ds = new DataSet();


    private void Page_Load(object sender, System.EventArgs e)
    {
        if (!(Page.IsPostBack))
        {
            //SqlConnection con = new SqlConnection();
            //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
            SqlDataReader dr ;
            SqlCommand cmd = new SqlCommand("SELECT desig_name FROM Designation_Master", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while ((dr.Read()))
            {
                ddlDesignation.Items.Add(Convert.ToString(dr[0]));
            }
            con.Close();
            bindgrid();
        }
    }

  private void bindgrid()
 {
   //SqlConnection con = new SqlConnection();
   //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
   SqlCommand cmd = new SqlCommand("SELECT * FROM Dept_Master", con);
   con.Open();
   SqlDataAdapter da = new SqlDataAdapter(cmd);
   da.Fill(ds);
   //DataGrid1.DataSource = ds.Tables[0];
   //DataGrid1.DataBind();
   con.Close();
   cmd = null;
 }

 //private void DataGrid1_EditCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
 //{
 //  DataGrid1.EditItemIndex = e.Item.ItemIndex;
 //  bindgrid();
 //  rfvname.Enabled = false;
 //}

 private void btncreatDept_Click(object sender, System.EventArgs e)
 {
   //SqlConnection con = new SqlConnection();
   //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
   string sql = "INSERT INTO Dept_Master(Dept_Name,Highest_Desig_ID) VALUES(@dept_name,@highest_desig)";
   SqlCommand cmd = new SqlCommand(sql, con);
   SqlParameter pm;
   pm = cmd.Parameters.Add(new SqlParameter("@dept_name", SqlDbType.NVarChar));
   pm.Value = txtDeptName.Text;
   pm = cmd.Parameters.Add(new SqlParameter("@highest_desig", SqlDbType.Int));
   pm.Value = Convert.ToInt16(ddlDesignation.SelectedItem.Text);
   con.Open();
   cmd.ExecuteNonQuery();
   con.Close();
   bindgrid();
   cmd = null;
   txtDeptName.Text = "";
   //txtDeptDesc.Text = "";
 }

 //private void DataGrid1_CancelCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
 //{
 //  //SqlConnection con = new SqlConnection();
 //  //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
 //  DataGrid1.EditItemIndex = -1;
 //  bindgrid();
 //  rfvname.Enabled = true;
 //}

 //private void DataGrid1_UpdateCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
 //{
 //  //SqlConnection con = new SqlConnection();
 //  //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
 //  string sql = "UPDATE Dept_Master SET Dept_Name=@dept_name,Highest_Desig_ID=@highest_desig WHERE Dept_ID=@dept_id";
 //  SqlCommand cmd = new SqlCommand(sql, con);
 //  SqlParameter pm;
 //  pm = cmd.Parameters.Add(new SqlParameter("@dept_id", SqlDbType.Int));
 //  pm.Value = Convert.ToInt16(e.Item.Cells[0].Text);
 //  pm = cmd.Parameters.Add(new SqlParameter("@dept_name", SqlDbType.NVarChar));
 //  pm.Value = ((TextBox)(e.Item.Cells[3].Controls[0])).Text;
 //  pm = cmd.Parameters.Add(new SqlParameter("@highest_desig", SqlDbType.VarChar));
 //  pm.Value = Convert.ToInt16(((TextBox)(e.Item.Cells[4].Controls[0])).Text);
 //  con.Open();
 //  cmd.ExecuteNonQuery();
 //  con.Close();
 //  cmd = null;
 //  DataGrid1.EditItemIndex = -1;
 //  bindgrid();
 //  rfvname.Enabled = true;
 //}

 //void DataGrid1_Delete(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
 //{
 //  //SqlConnection con = new SqlConnection();
 //  //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
 //  int value = Convert.ToInt32(e.Item.Cells[0].Text);
 //  string sql = "DELETE FROM Dept_Master WHERE Dept_ID = " + value + "";
 //  SqlCommand cmd = new SqlCommand(sql, con);
 //  try {
 //    con.Open();
 //  } catch (SqlException ex) {
 //  }
 //  try {
 //    cmd.ExecuteNonQuery();
 //  } catch (SqlException ex) {
 //    if (con.State == ConnectionState.Open) {
 //      con.Close();
 //    }
 //  }
 //  con.Close();
 //  cmd = null;
 //  bindgrid();
 //}

 //private void DataGrid1_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
 //{
 //  DataGrid1.CurrentPageIndex = e.NewPageIndex;
 //  bindgrid();
 //}

    protected void btncreatDept_Click1(object sender, EventArgs e)
    {
        
        SqlCommand cmd2 = new SqlCommand("select Max(dept_id)+1 from Dept_Master",con);
        con.Open();
        string str1 = cmd2.ExecuteScalar().ToString();
        if (str1 == "")
        {
           str1 = "1";
        }
        else
        {
            str1= str1;
        }
       con.Close();
        
        SqlCommand cmd1 = new SqlCommand("select desig_id from Designation_Master where desig_name='"+ddlDesignation.SelectedValue+"'", con);
        con.Open();
        string str =  cmd1.ExecuteScalar().ToString();
        con.Close();
        SqlCommand cmd = new SqlCommand("insert into Dept_Master values("+str1+",'" + txtDeptName.Text + "',"+str+")", con);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
    }
    protected void txtDeptDesc_TextChanged(object sender, EventArgs e)
    {

    }
    protected void ddlDesignation_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}

