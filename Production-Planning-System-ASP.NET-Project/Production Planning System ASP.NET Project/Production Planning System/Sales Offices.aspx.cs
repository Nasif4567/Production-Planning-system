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


public partial class Sales_Offices : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
    SqlDataReader dr,dr1;    
    private void Page_Load(object sender, System.EventArgs e)
    {
        if (!(Page.IsPostBack))
        {
            
            SqlCommand cmd = new SqlCommand("SELECT emp_no,emp_name from Employee_Master", con);
            //SqlDataReader dr;
            SqlParameter pm;
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
                ddlincharge.Items.Add("dr[1]");
                ddlincharge.Items[ddlincharge.Items.Count - 1].Value = dr[0].ToString();
            }
            con.Close();
            dr.Close();
            cmd = null;
            bindgrid();
            
           SqlCommand cmd1 = new SqlCommand("select user_name from User_Roles where role_id= '3'",con);
            con.Open();
            dr1 = cmd1.ExecuteReader();
            ddlincharge.DataSource = dr1;
            ddlincharge.DataTextField = "user_name";
            ddlincharge.DataValueField = "user_name";
            ddlincharge.DataBind();
        }
    }
    private void bindgrid()
    {
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand("SELECT * FROM sales_office_master", con);
        con.Open();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        DataGrid1.DataSource = dt.DefaultView;
        DataGrid1.DataBind();
        con.Close();
        cmd = null;
    }

    void DataGrid1_Delete(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
    {
        //SqlConnection con = new SqlConnection();
        //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        int value = Convert.ToInt32(e.Item.Cells[0].Text);
        string sql = "DELETE FROM sales_office_master WHERE sales_office_id = " + value + "";
        SqlCommand cmd = new SqlCommand(sql, con);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        cmd = null;
        bindgrid();
    }

    private void btnAssignRole_Click(object sender, System.EventArgs e)
    {
        string sql = "INSERT INTO sales_office_master(sales_office_name,sales_office_address,sales_office_phoneno,sales_office_email,sales_office_fax_no,sales_office_incharge_id) VALUES(@name,@address,@phone,@email,@faxno,@incharge)";
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
        pm = cmd.Parameters.Add(new SqlParameter("@incharge", SqlDbType.Int));
        pm.Value = Convert.ToInt32((ddlincharge.SelectedItem.Value.ToString()));
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        cmd = null;
        con.Close();
        bindgrid();
        txtname.Text = "";
        txtaddress.Text = "";
        txtphone.Text = "";
        txtemail.Text = "";
        txtfax.Text = "";
    }

    private void DataGrid1_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
    {
        DataGrid1.CurrentPageIndex = e.NewPageIndex;
        bindgrid();
    }

    private void DataGrid1_UpdateCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
    {
        //SqlConnection con = new SqlConnection();
        //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        string sql = "Update Sales_Office_Master Set sales_office_name=@name,sales_office_address=@address,sales_office_phoneno=@phone,sales_office_email=@email,sales_office_fax_no=@faxno,sales_office_incharge_id=@incharge WHERE sales_office_id=@id";
        SqlCommand cmd = new SqlCommand(sql, con);
        SqlParameter pm;
        pm = cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
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
        pm = cmd.Parameters.Add(new SqlParameter("@incharge", SqlDbType.Int));
        pm.Value = ((TextBox)(e.Item.Cells[8].Controls[0])).Text;
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        cmd = null;
        con.Close();
        DataGrid1.EditItemIndex = -1;
        bindgrid();
        rfvname.Enabled = true;
        rfvphone.Enabled = true;
        revphone.Enabled = true;
        revmail.Enabled = true;
        revfax.Enabled = true;
    }

    private void DataGrid1_CancelCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
    {
        DataGrid1.EditItemIndex = -1;
        bindgrid();
        rfvname.Enabled = true;
        rfvphone.Enabled = true;
        revphone.Enabled = true;
        revmail.Enabled = true;
        revfax.Enabled = true;
    }

    private void DataGrid1_EditCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
    {
        DataGrid1.EditItemIndex = e.Item.ItemIndex;
        bindgrid();
        rfvname.Enabled = false;
        rfvphone.Enabled = false;
        revphone.Enabled = false;
        revmail.Enabled = false;
        revfax.Enabled = false;
    }

    protected void btnAssignRole_Click1(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("select Max(sales_office_id)+1 from sales_office_master", con);
        con.Open();
        string str1 = cmd.ExecuteScalar().ToString();
        if (str1 == "")
        {
            str1 = "1";
        }
        else
        {
            str1 = str1;
        }
        con.Close();
        SqlCommand cmd1 = new SqlCommand("select emp_id from Login_Master where user_name='" +ddlincharge.SelectedValue + "'", con);
        con.Open();
        string str = cmd1.ExecuteScalar().ToString();
        con.Close();
        SqlCommand cmd2 = new SqlCommand("insert into sales_office_master values(" + str1 + ",'" +txtname.Text + "','"+txtaddress.Text+"',"+txtphone.Text+",'"+txtemail.Text+"',"+txtfax.Text+"," + str + ")", con);
        con.Open();
        cmd2.ExecuteNonQuery();
        con.Close();



    }
}
