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
public partial class Suppliers_Form : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
    SqlDataReader dr;
    private void Page_Load(object sender, System.EventArgs e)
    {
        if (!(Page.IsPostBack))
        {
            //SqlCommand cmd = new SqlCommand("SELECT Credit_Limit_ID,Credit_Rating_Limit from Credit_Limit_Master", con);
            
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
            //while (dr.Read())
            //{
            //    ddlcredit.Items.Add(dr[1].ToString());
            //  //  ddlcredit.Items(ddlcredit.Items.Count - 1).Value = dr[0].ToString();
            //}
            //con.Close();
            //dr.Close();
            //cmd = null;
            //bindgrid();
            SqlCommand cmd = new SqlCommand("select Credit_Limit_Master from Credit_Limit_Master", con);
            con.Open();
            dr = cmd.ExecuteReader();
            ddlcredit.DataSource = dr;
            ddlcredit.DataTextField = "Credit_Limit_Master";
            ddlcredit.DataValueField = "Credit_Limit_Master";
            ddlcredit.DataBind();
            con.Close();
        }
    }
    private void bindgrid()
    {
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand("SELECT * FROM Supplier_Master", con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        DataGrid1.DataSource = dt.DefaultView;
        DataGrid1.DataBind();
        con.Close();
        cmd = null;
    }

    void DataGrid1_Delete(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
    {
        int value = Convert.ToInt32(e.Item.Cells[0].Text);
        string sql = "DELETE FROM Supplier_Master WHERE sup_no = " + value + "";
        SqlCommand cmd = new SqlCommand(sql, con);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        cmd = null;
        bindgrid();
    }

    private void btnAssignRole_Click(object sender, System.EventArgs e)
    {
        string sql = "INSERT INTO Supplier_Master(sup_name,sup_full_name,sup_address,sup_phone,sup_email,sup_fax_no,sup_cont_person_name,sup_cont_person_phoneno,sup_crd_limit_id) VALUES(@name,@fullname,@address,@phone,@email,@faxno,@contname,@contphoneno,@crdlimit)";
        SqlCommand cmd = new SqlCommand(sql, con);
        SqlParameter pm;
        pm = cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar));
        pm.Value = txtname.Text;
        pm = cmd.Parameters.Add(new SqlParameter("@fullname", SqlDbType.NVarChar));
        pm.Value = txtfull.Text;
        pm = cmd.Parameters.Add(new SqlParameter("@address", SqlDbType.NVarChar));
        pm.Value = txtaddress.Text;
        pm = cmd.Parameters.Add(new SqlParameter("@phone", SqlDbType.NChar));
        pm.Value = txtphone.Text;
        pm = cmd.Parameters.Add(new SqlParameter("@email", SqlDbType.NVarChar));
        pm.Value = txtmail.Text;
        pm = cmd.Parameters.Add(new SqlParameter("@faxno", SqlDbType.NChar));
        pm.Value = txtfax.Text;
        pm = cmd.Parameters.Add(new SqlParameter("@contname", SqlDbType.NChar));
        pm.Value = txtcontactname.Text;
        pm = cmd.Parameters.Add(new SqlParameter("@contphoneno", SqlDbType.NChar));
        pm.Value = txtcontactphone.Text;
        pm = cmd.Parameters.Add(new SqlParameter("@crdlimit", SqlDbType.Int));
        pm.Value = Convert.ToInt32(ddlcredit.SelectedItem.Value.ToString());
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        cmd = null;
        con.Close();
        bindgrid();
        txtname.Text = "";
        txtfull.Text = "";
        txtaddress.Text = "";
        txtphone.Text = "";
        txtcontactname.Text = "";
        txtcontactphone.Text = "";
        txtemail.Text = "";
        txtfax.Text = "";
    }

    private void DataGrid1_CancelCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
    {
        DataGrid1.EditItemIndex = -1;
        bindgrid();
        revcontactphone.Enabled = true;
        rfvcontactphone.Enabled = true;
        rfvphone.Enabled = true;
        revphone.Enabled = true;
        rfvfullname.Enabled = true;
        revmail.Enabled = true;
        rfvcontactname.Enabled = true;
        revfax.Enabled = true;
    }

    private void DataGrid1_EditCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
    {
        DataGrid1.EditItemIndex = e.Item.ItemIndex;
        bindgrid();
        revcontactphone.Enabled = false;
        rfvcontactphone.Enabled = false;
        rfvphone.Enabled = false;
        revphone.Enabled = false;
        rfvfullname.Enabled = false;
        revmail.Enabled = false;
        rfvcontactname.Enabled = false;
        revfax.Enabled = false;
    }

    private void DataGrid1_UpdateCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
    {
        //SqlConnection con = new SqlConnection();
        //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        string sql = "UPDATE Supplier_Master SET sup_name=@name,sup_full_name=@fullname,sup_address=@address,sup_phone=@phone,sup_email=@email,sup_fax_no=@faxno,sup_cont_person_name=@contname,sup_cont_person_phoneno=@contphone,sup_crd_limit_id=@crdlimit WHERE sup_no=@id";
        SqlCommand cmd = new SqlCommand(sql, con);
        SqlParameter pm;
        pm = cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
        pm.Value = Convert.ToInt16(e.Item.Cells[0].Text);
        pm = cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar));
        pm.Value = ((TextBox)(e.Item.Cells[3].Controls[0])).Text;
        pm = cmd.Parameters.Add(new SqlParameter("@fullname", SqlDbType.NVarChar));
        pm.Value = ((TextBox)(e.Item.Cells[4].Controls[0])).Text;
        pm = cmd.Parameters.Add(new SqlParameter("@address", SqlDbType.NVarChar));
        pm.Value = ((TextBox)(e.Item.Cells[5].Controls[0])).Text;
        pm = cmd.Parameters.Add(new SqlParameter("@phone", SqlDbType.NChar));
        pm.Value = ((TextBox)(e.Item.Cells[6].Controls[0])).Text;
        pm = cmd.Parameters.Add(new SqlParameter("@email", SqlDbType.NVarChar));
        pm.Value = ((TextBox)(e.Item.Cells[7].Controls[0])).Text;
        pm = cmd.Parameters.Add(new SqlParameter("@faxno", SqlDbType.NChar));
        pm.Value = ((TextBox)(e.Item.Cells[8].Controls[0])).Text;
        pm = cmd.Parameters.Add(new SqlParameter("@contname", SqlDbType.NVarChar));
        pm.Value = ((TextBox)(e.Item.Cells[9].Controls[0])).Text;
        pm = cmd.Parameters.Add(new SqlParameter("@contphone", SqlDbType.NChar));
        pm.Value = ((TextBox)(e.Item.Cells[10].Controls[0])).Text;
        pm = cmd.Parameters.Add(new SqlParameter("@crdlimit", SqlDbType.Int));
        pm.Value = ((TextBox)(e.Item.Cells[11].Controls[0])).Text;
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        cmd = null;
        con.Close();
        DataGrid1.EditItemIndex = -1;
        bindgrid();
        revcontactphone.Enabled = true;
        rfvcontactphone.Enabled = true;
        rfvphone.Enabled = true;
        revphone.Enabled = true;
        rfvfullname.Enabled = true;
        revmail.Enabled = true;
        rfvcontactname.Enabled = true;
        revfax.Enabled = true;
    }

    private void DataGrid1_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
    {
        DataGrid1.CurrentPageIndex = e.NewPageIndex;
        bindgrid();
    }

    protected void txtcontactname_TextChanged(object sender, EventArgs e)
    {

    }
    protected void btnAssignRole_Click1(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("select Max(sup_no)+1 from Supplier_Master", con);
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
        SqlCommand cmd1 = new SqlCommand("select credit_limit_id from Credit_Limit_Master where Credit_Limit_Master='" + ddlcredit.SelectedValue + "'", con);
        con.Open();
        String str = cmd1.ExecuteScalar().ToString();
        con.Close();
        SqlCommand cmd2 = new SqlCommand("insert into Supplier_Master values(" + str1 + ",'" + txtname.Text + "','" + txtfull.Text + "','" + txtaddress.Text + "'," + txtphone.Text + ",'" + txtemail.Text + "'," + txtfaxno.Text + ",'" + txtcontactname.Text + "'," + txtcontactphone.Text + "," + str + ")", con);
        con.Open();
        cmd2.ExecuteNonQuery();
        con.Close();
    }
}
