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

public partial class DesignationMaster : System.Web.UI.Page
{
    //private void Page_Init(object sender, System.EventArgs e)
    //{
    //   // InitializeComponent();
    //}
    SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
    DataSet ds = new DataSet();
    private void Page_Load(object sender, System.EventArgs e)
    {
        if (!(Page.IsPostBack))
        {
           // bindgrid();
        }

        
    }

    //private void DataGrid1_EditCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
    //{
        
    //    DataGrid1.EditItemIndex = e.Item.ItemIndex;
    //     //GridView1.EditIndex = e.Item.ItemIndex;
    //     bindgrid();
    //    rfvname.Enabled = false;
    //}

    //private void bindgrid()
    //{
    //   // SqlConnection con = new SqlConnection();
    //    SqlCommand cmd = new SqlCommand("SELECT * FROM Designation_Master", con);
    //    SqlDataAdapter da = new SqlDataAdapter(cmd);
    //    con.Open(); 
    //    da.Fill(ds);
    //    DataGrid1.DataSource = ds.Tables[0];
    //    DataGrid1.DataBind();  
    //    //DataGrid1.DataBind();
    //    con.Close();
    //    cmd = null;
    //    con = null;
    //}

    //private void DataGrid1_UpdateCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
    //{
        
    //    SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
    //    string sql = "UPDATE Designation_Master SET desig_name=@desig_name,desig_abr=@desig_abr,desig_desc=@desig_desc WHERE desig_id=@desig_id";
    //    SqlCommand cmd = new SqlCommand(sql, con);
    //    SqlParameter pm;
    //    pm = cmd.Parameters.Add(new SqlParameter("@desig_id", SqlDbType.Int));
    //    pm.Value = e.Item.Cells[0].Text;
    //    pm = cmd.Parameters.Add(new SqlParameter("@desig_name", SqlDbType.NVarChar));
    //    pm.Value = ((TextBox)(e.Item.Cells[3].Controls[0])).Text;
    //    pm = cmd.Parameters.Add(new SqlParameter("@desig_abr", SqlDbType.NChar));
    //    pm.Value = ((TextBox)(e.Item.Cells[4].Controls[0])).Text;
    //    pm = cmd.Parameters.Add(new SqlParameter("@desig_desc", SqlDbType.VarChar));
    //    pm.Value = ((TextBox)(e.Item.Cells[5].Controls[0])).Text;
    //    con.Open();
    //    cmd.ExecuteNonQuery();
    //    con.Close();
    //    cmd = null;
    //    con = null;
    //    DataGrid1.EditItemIndex= - 1;        
    //     bindgrid();
    //    rfvname.Enabled = true;
    //}

    private void hide()
    {
        //Label2.Visible = false;
    }

    //private void DataGrid1_CancelCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
    //{
    //    DataGrid1.EditItemIndex = -1;  
    //    bindgrid();
    //    rfvname.Enabled = true;
    //}

    private void btncreatDesig_Click(object sender, System.EventArgs e)
    {
        //SqlConnection con = new SqlConnection();
        SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        string sql = "INSERT INTO Designation_Master(desig_name,desig_abr,desig_desc) VALUES(@desig_name,@desig_abr,@desig_desc)";
        SqlCommand cmd = new SqlCommand(sql, con);
        SqlParameter pm;
        pm = cmd.Parameters.Add(new SqlParameter("@desig_name", SqlDbType.NVarChar));
        pm.Value = txtDesigName.Text;
        pm = cmd.Parameters.Add(new SqlParameter("@desig_abr", SqlDbType.NChar));
        pm.Value = txtDesigabbr.Text;
        pm = cmd.Parameters.Add(new SqlParameter("@desig_desc", SqlDbType.VarChar));
        pm.Value = txtDesigDesc.Text;
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
       // bindgrid();
        cmd = null;
        con = null;
        txtDesigDesc.Text = "";
        txtDesigName.Text = "";
    }

    //void DataGrid1_Delete(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
    //{
    //    //SqlConnection con = new SqlConnection();
    //    SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
    //    int value = Convert.ToInt32(e.Item.Cells[0].Text);
    //    string sql = "DELETE FROM Designation_Master WHERE desig_id = " + value + "";
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

    //private void DataGrid1_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
    //{
    //    DataGrid1.CurrentPageIndex = e.NewPageIndex;
    //    bindgrid();
    //}

    protected void txtDesigabbr_TextChanged(object sender, EventArgs e)
    {

    }
    protected void btncreatDesig_Click1(object sender, EventArgs e)
    {
        SqlCommand cmd1 = new SqlCommand("select Max(desig_id)+1 from Designation_Master", con);
        con.Open();
        string str1 = cmd1.ExecuteScalar().ToString();
        if (str1 == "")
        {
            str1 = "1";
        }
        else
        {
            str1 = str1;
        }
        con.Close();
       // SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        string sql = "INSERT INTO Designation_Master(desig_id,desig_name,desig_abr,desig_desc) VALUES(" + str1 + ",@desig_name,@desig_abr,@desig_desc)";
        SqlCommand cmd = new SqlCommand(sql, con);
        SqlParameter pm;
        pm = cmd.Parameters.Add(new SqlParameter("@desig_name", SqlDbType.NVarChar));
        pm.Value = txtDesigName.Text;
        pm = cmd.Parameters.Add(new SqlParameter("@desig_abr", SqlDbType.NChar));
        pm.Value = txtDesigabbr.Text;
        pm = cmd.Parameters.Add(new SqlParameter("@desig_desc", SqlDbType.VarChar));
        pm.Value = txtDesigDesc.Text;
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
       // bindgrid();
        cmd = null;
        con = null;
        txtDesigDesc.Text = "";
        txtDesigName.Text = "";
        txtDesigabbr.Text = ""; 
    }
    
}

