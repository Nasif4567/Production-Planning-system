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

public partial class Suppliers_Raw_Meterial_Master : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
    SqlDataReader dr; 
    //SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings("con"));


    private void Page_Load(object sender, System.EventArgs e)
    {
        if (!(Page.IsPostBack))
        {
            //SqlDataReader dr ;
            SqlCommand cmd = new SqlCommand("SELECT sup_no FROM Supplier_Master", con);
            con.Open();
            try
            {
                dr = cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {
            }
            while (dr.Read())
            {
                ddlsupid.Items.Add(dr[0].ToString());
            }
            dr.Close();
            con.Close();
            cmd.CommandText = "Select raw_material_id from raw_material_Master";
            con.Open();
            dr = cmd.ExecuteReader();
            while ((dr.Read()))
            {
                ddlrawid.Items.Add(dr[0].ToString());
            }
            dr.Close();
            con.Close();
            bindgrid();
        }
    }
    private void Button1_Click(object sender, System.EventArgs e)
    {
        //string sql = "INSERT INTO Suppliers_Raw_Material_Master(sup_no,raw_material_id,estimated_supply_days) VALUES(@supno,@rawid,@days)";
        //SqlCommand cmd = new SqlCommand(sql, con);
        //SqlParameter pm;
        //pm = cmd.Parameters.Add(new SqlParameter("@supno", SqlDbType.Money));
        //pm.Value = Convert.ToInt16(ddlsupid.SelectedItem.Text);
        //pm = cmd.Parameters.Add(new SqlParameter("@rawid", SqlDbType.NVarChar));
        //pm.Value = Convert.ToInt16(ddlrawid.SelectedItem.Text);
        //pm = cmd.Parameters.Add(new SqlParameter("@days", SqlDbType.NVarChar));
        //pm.Value = Convert.ToInt16(txtdays.Text);
        //con.Open();
        //cmd.ExecuteNonQuery();
        //con.Close();
        //cmd = null;
        //con.Close();
        //bindgrid();
        //txtdays.Text = "";
    }

    private void bindgrid()
    {
        SqlCommand cmd = new SqlCommand("SELECT * FROM Suppliers_raw_material_master", con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        DataGrid1.DataSource = ds.Tables[0];
        DataGrid1.DataBind();
        con.Close();
        cmd = null;
    }

    public void DataGrid1_Delete(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
    {
        int value = Convert.ToInt32(e.Item.Cells[0].Text);
        int value1 = Convert.ToInt32(e.Item.Cells[3].Text);
        string sql = "DELETE FROM suppliers_raw_material_Master WHERE sup_no = " + value + " and raw_material_id = " + value1 + " ";
        SqlCommand cmd = new SqlCommand(sql, con);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        cmd = null;
        bindgrid();
    }

    private void DataGrid1_UpdateCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
    {
        string sql = "UPDATE Suppliers_raw_material_master Set estimated_supply_days=@days WHERE sup_no=@no and raw_material_id=@rawid";
        SqlCommand cmd = new SqlCommand(sql, con);
        SqlParameter pm;
        pm = cmd.Parameters.Add(new SqlParameter("@no", SqlDbType.Int));
        pm.Value = Convert.ToInt32(e.Item.Cells[0].Text);
        pm = cmd.Parameters.Add(new SqlParameter("@rawid", SqlDbType.Int));
        pm.Value = Convert.ToInt32(e.Item.Cells[3].Text);
        pm = cmd.Parameters.Add(new SqlParameter("@days", SqlDbType.Int));
        pm.Value = Convert.ToInt32(((TextBox)(e.Item.Cells[4].Controls[0])).Text);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        cmd = null;
        con.Close();
        DataGrid1.EditItemIndex = -1;
        bindgrid();
        rfvdays.Enabled = true;
        revdays.Enabled = true;
    }

    private void DataGrid1_CancelCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
    {
        DataGrid1.EditItemIndex = -1;
        bindgrid();
        rfvdays.Enabled = true;
        revdays.Enabled = true;
    }

    private void DataGrid1_EditCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
    {
        DataGrid1.EditItemIndex = e.Item.ItemIndex;
        bindgrid();
        rfvdays.Enabled = false;
        revdays.Enabled = false;
    }

    private void DataGrid1_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
    {
        DataGrid1.CurrentPageIndex = e.NewPageIndex;
        bindgrid();
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        string sql = "INSERT INTO Suppliers_Raw_Material_Master(sup_no,raw_material_id,estimated_supply_days) VALUES(@supno,@rawid,@days)";
        SqlCommand cmd = new SqlCommand(sql, con);
        SqlParameter pm;
        pm = cmd.Parameters.Add(new SqlParameter("@supno", SqlDbType.Money));
        pm.Value = Convert.ToInt16(ddlsupid.SelectedItem.Text);
        pm = cmd.Parameters.Add(new SqlParameter("@rawid", SqlDbType.NVarChar));
        pm.Value = Convert.ToInt16(ddlrawid.SelectedItem.Text);
        pm = cmd.Parameters.Add(new SqlParameter("@days", SqlDbType.NVarChar));
        pm.Value = Convert.ToInt16(txtdays.Text);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        cmd = null;
        con.Close();
        bindgrid();
        txtdays.Text = "";
    }
}
