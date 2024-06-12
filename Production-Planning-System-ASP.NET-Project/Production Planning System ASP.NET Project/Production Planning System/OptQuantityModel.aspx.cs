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

public partial class OptQuantityModel : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
    int value;
    private void Page_Load(object sender, System.EventArgs e)
    {
        if (!(Page.IsPostBack))
        {
            //SqlConnection con = new SqlConnection();
            //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
            //SqlDataReader dr;
            //SqlCommand cmd = new SqlCommand("Select model_name from Power_Tool_Model_Master", con);
            SqlDataAdapter da = new SqlDataAdapter("Select model_name from Power_Tool_Model_Master", con);
            con.Open();
            DataSet ds = new DataSet();
            da.Fill(ds);
            ddlModelName.DataSource = ds;
            ddlModelName.DataTextField="model_name";
            ddlModelName.DataValueField = "model_name";
            ddlModelName.DataBind();
            con.Close();

            //try
            //{
            //    con.Open();
            //}
            //catch (SqlException ex)
            //{
            //}
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
            //try
            //{
            //    dr = cmd.ExecuteReader();
            //    while ((dr.Read()))
            //    {
            //        ddlModelName.Items.Add(dr[0].ToString());
            //    }
            //}
            //catch (Exception ex)
            //{
            //    if (con.State == ConnectionState.Open)
            //    {
            //        con.Close();
            //    }
            //}
            //con.Close();
            bindgrid();
        }
    }
    private void bindgrid()
    {
        //SqlConnection con = new SqlConnection();
        SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        SqlCommand cmd = new SqlCommand("SELECT * FROM Model_Quantity_Requaired ", con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        DataGrid1.DataSource = ds.Tables[0];
        DataGrid1.DataBind();
        con.Close();
        cmd = null;
        con = null;
    }

    private void DataGrid1_EditCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
    {
        DataGrid1.EditItemIndex = e.Item.ItemIndex;
        bindgrid();
        rfvqty.Enabled = false;
        //revqty.Enabled = false;
    }

    private void DataGrid1_UpdateCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
    {
        //SqlConnection con = new SqlConnection();
        //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        string sql = "UPDATE Model_Quantity_Requaired SET model_name=@model_name,opt_qty_of_batch=@opt_qty_of_batch WHERE model_no=@model_no";
        SqlCommand cmd = new SqlCommand(sql, con);
        SqlParameter pm;
        pm = cmd.Parameters.Add(new SqlParameter("@model_no", SqlDbType.Int));
        pm.Value = Convert.ToInt16(((TextBox)(e.Item.Cells[2].Controls[0])).Text);
        pm = cmd.Parameters.Add(new SqlParameter("@model_name", SqlDbType.NVarChar));
        pm.Value = ((TextBox)(e.Item.Cells[3].Controls[0])).Text;
        pm = cmd.Parameters.Add(new SqlParameter("@opt_qty_of_batch", SqlDbType.Int));
        pm.Value = Convert.ToInt16(((TextBox)(e.Item.Cells[4].Controls[0])).Text);
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
        cmd = null;
        con = null;
        DataGrid1.EditItemIndex = -1;
        bindgrid();
        rfvqty.Enabled = true;
        //revqty.Enabled = true;
    }

    void DataGrid1_Delete(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
    {
        //SqlConnection con = new SqlConnection();
        SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        string sql = "DELETE FROM Model_Quantity_Requaired WHERE model_no=@model_no";
        SqlCommand cmd = new SqlCommand(sql, con);
        SqlParameter pm;
        pm = cmd.Parameters.Add(new SqlParameter("@model_no", SqlDbType.Int));
        pm.Value = Convert.ToInt16(e.Item.Cells[2].Text);
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
        cmd = null;
        bindgrid();
    }

    private void DataGrid1_CancelCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
    {
        DataGrid1.EditItemIndex = -1;
        bindgrid();
        rfvqty.Enabled = true;
        //revqty.Enabled = true;
    }

    

    private void DataGrid1_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
    {
        DataGrid1.CurrentPageIndex = e.NewPageIndex;
        bindgrid();
    }

    protected void btnCreateNew_Click1(object sender, EventArgs e)
    {
        string sql = "INSERT INTO Model_Quantity_Requaired(model_no,model_name,opt_qty_of_batch) VALUES(@model_no,@model_name,@opt_qty_of_batch)";
        SqlCommand cmd1 = new SqlCommand("SELECT model_no FROM power_tool_model_master WHERE model_name=@model_name", con);
        SqlCommand cmd = new SqlCommand(sql, con);
        SqlParameter pm;

        pm = cmd1.Parameters.Add(new SqlParameter("@model_name", SqlDbType.NVarChar));
        pm.Value = ddlModelName.SelectedItem.Text;
        try
        {
            con.Open();
        }
        catch (SqlException ex)
        {
        }
        try
        {
            value = Convert.ToInt32(cmd1.ExecuteScalar());
        }
        catch (SqlException ex)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        con.Close();
        pm = cmd.Parameters.Add(new SqlParameter("@model_no", SqlDbType.Int));
        pm.Value = value;
        pm = cmd.Parameters.Add(new SqlParameter("@model_name", SqlDbType.NVarChar));
        pm.Value = ddlModelName.SelectedItem.Text;
        pm = cmd.Parameters.Add(new SqlParameter("@opt_qty_of_batch", SqlDbType.NChar));
        pm.Value = Convert.ToInt32(txtOptimumQty.Text);
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
        bindgrid();
        cmd = null;
        txtOptimumQty.Text = "";
    }
}
