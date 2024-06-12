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

public partial class Customer_Master : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
    //SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings("con"));
    //private void Page_Load(object sender, System.EventArgs e)
    //{
    //    bindgrid();
    //}
    //private void bindgrid()
    //{
    //    //DataTable dt = new DataTable();
    //    DataSet ds = new DataSet(); 
    //    SqlCommand cmd = new SqlCommand("SELECT * FROM Customer_Master", con);
    //    con.Open();
    //    SqlDataAdapter da = new SqlDataAdapter(cmd);
    //    da.Fill(ds);
    //    DataGrid1.DataSource = ds;
    //    DataGrid1.DataBind();
    //    con.Close();
    //    cmd = null;
    //}

    void DataGrid1_Delete(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
    {
        int value = Convert.ToInt32(e.Item.Cells[0].Text);
        string sql = "DELETE FROM Customer_Master WHERE cust_no = " + value + "";
        SqlCommand cmd = new SqlCommand(sql, con);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        cmd = null;
       // bindgrid();
    }

    //private void DataGrid1_EditCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
    //{
    //    DataGrid1.EditItemIndex = e.Item.ItemIndex;
    //    bindgrid();
    //    rfvname.Enabled = false;
    //    rfvphone.Enabled = false;
    //}

    private void DataGrid1_UpdateCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
    {
        //SqlConnection con = new SqlConnection();
        //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        string sql = "UPDATE Customer_Master SET cust_name=@name,cust_address=@address,cust_phone=@phone,cust_email=@email,cust_fax_no=@faxno WHERE cust_no=@no";
        SqlCommand cmd = new SqlCommand(sql, con);
        SqlParameter pm;
        pm = cmd.Parameters.Add(new SqlParameter("@no", SqlDbType.Int));
        pm.Value = Convert.ToInt16(e.Item.Cells[0].Text);
        pm = cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar));
        pm.Value = ((TextBox)(e.Item.Cells[3].Controls[0])).Text;
        pm = cmd.Parameters.Add(new SqlParameter("@address", SqlDbType.NVarChar));
        pm.Value = ((TextBox)(e.Item.Cells[4].Controls[0])).Text;
        pm = cmd.Parameters.Add(new SqlParameter("@phone", SqlDbType.NChar));
        pm.Value = ((TextBox)(e.Item.Cells[5].Controls[0])).Text;
        pm = cmd.Parameters.Add(new SqlParameter("@email", SqlDbType.NVarChar));
        pm.Value = ((TextBox)(e.Item.Cells[6].Controls[0])).Text;
        pm = cmd.Parameters.Add(new SqlParameter("@faxno", SqlDbType.NChar));
        pm.Value = ((TextBox)(e.Item.Cells[7].Controls[0])).Text;
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        cmd = null;
        con.Close();
        //DataGrid1.EditItemIndex = -1;
        //bindgrid();
        rfvname.Enabled = true;
        rfvphone.Enabled = true;
    }

    //private void DataGrid1_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
    //{
    //    DataGrid1.CurrentPageIndex = e.NewPageIndex;
    //    bindgrid();
    //}

    private void btnAssignRole_Click(object sender, System.EventArgs e)
    {
        string sql = "INSERT INTO Customer_Master(cust_name,cust_address,cust_phone,cust_email,cust_fax_no) VALUES(@name,@address,@phone,@email,@faxno)";
        SqlCommand cmd = new SqlCommand(sql, con);
        SqlParameter pm;
        pm = cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar));
        pm.Value = txtname.Text;
        pm = cmd.Parameters.Add(new SqlParameter("@address", SqlDbType.NVarChar));
        pm.Value = txtaddress.Text;
        pm = cmd.Parameters.Add(new SqlParameter("@phone", SqlDbType.NChar));
        pm.Value = txtphone.Text;
        pm = cmd.Parameters.Add(new SqlParameter("@email", SqlDbType.NVarChar));
        pm.Value = txtemail.Text;
        pm = cmd.Parameters.Add(new SqlParameter("@faxno", SqlDbType.NChar));
        pm.Value = txtfax.Text;
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        cmd = null;
        con.Close();
       // bindgrid();
        txtname.Text = "";
        txtaddress.Text = "";
        txtphone.Text = "";
        txtemail.Text = "";
        txtfax.Text = "";
    }

    //private void DataGrid1_CancelCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
    //{
    //    DataGrid1.EditItemIndex = -1;
    //    bindgrid();
    //    rfvname.Enabled = true;
    //    rfvphone.Enabled = true;
    //}

    private void LinkButton1_Click(object sender, System.EventArgs e)
    {
        FormsAuthentication.SignOut();
        Response.Redirect("LogInForm.aspx");
    }
    protected void btnAssignRole_Click1(object sender, EventArgs e)
    {
        SqlCommand cmd =new SqlCommand("insert into Customer_Master values('"+txtname.Text+"','"+txtaddress.Text+"','"+txtphone.Text+"','"+txtemail.Text+"','"+txtfax.Text+"')",con);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void LinkButton1_Click1(object sender, EventArgs e)
    {

    }
    protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
    {

    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }
}
