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

public partial class Raw_Material_Master : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
    private void Page_Load(object sender, System.EventArgs e)
    {
        bindgrid();
    }
    private void bindgrid()
    {
        SqlCommand cmd = new SqlCommand("SELECT * FROM Raw_Material_Master", con);
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
        string sql = "DELETE FROM Raw_Material_Master WHERE Raw_Material_id = " + value + "";
        SqlCommand cmd = new SqlCommand(sql, con);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        cmd = null;
        bindgrid();
    }

    private void btncreatDesig_Click(object sender, System.EventArgs e)
    {
        //string sql = "INSERT INTO Raw_Material_Master(raw_material_name,raw_material_description,raw_material_price_unit,raw_material_quantity_avialable,raw_material_min_stock_level,raw_material_reorder_level)VALUES(@name,@desc,@price,@available,@minstock,@reorder)";
        //SqlCommand cmd = new SqlCommand(sql, con);
        //SqlParameter pm;
        //pm = cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar));
        //pm.Value = txtname.Text;
        //pm = cmd.Parameters.Add(new SqlParameter("@desc", SqlDbType.NVarChar));
        //pm.Value = txtdesc.Text;
        //pm = cmd.Parameters.Add(new SqlParameter("@price", SqlDbType.Money));
        //pm.Value = Convert.ToInt16(txtprice.Text);
        //pm = cmd.Parameters.Add(new SqlParameter("@available", SqlDbType.Int));
        //pm.Value = Convert.ToInt16(txtavail.Text);
        //pm = cmd.Parameters.Add(new SqlParameter("@minstock", SqlDbType.Int));
        //pm.Value = Convert.ToInt16(txtmin.Text);
        //pm = cmd.Parameters.Add(new SqlParameter("@reorder", SqlDbType.Int));
        //pm.Value = Convert.ToInt16(txtreorder.Text);
        //con.Open();
        //cmd.ExecuteNonQuery();
        //con.Close();
        //bindgrid();
        //cmd = null;
        //txtname.Text = "";
        //txtdesc.Text = "";
        //txtprice.Text = "";
        //txtavail.Text = "";
        //txtmin.Text = "";
        //txtreorder.Text = "";
    }

    private void DataGrid1_UpdateCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
    {
        string sql = "UPDATE raw_material_master SET raw_material_name=@name,raw_material_description=@desc,raw_material_price_unit=@price,raw_material_quantity_avialable=@available,raw_material_min_stock_level=@minstock,raw_material_reorder_level=@reorder WHERE raw_material_id=@id";
        SqlCommand cmd = new SqlCommand(sql, con);
        SqlParameter pm;
        pm = cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
        pm.Value = Convert.ToInt16(e.Item.Cells[0].Text);
        pm = cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar));
        pm.Value = ((TextBox)(e.Item.Cells[3].Controls[0])).Text;
        pm = cmd.Parameters.Add(new SqlParameter("@desc", SqlDbType.NVarChar));
        pm.Value = ((TextBox)(e.Item.Cells[4].Controls[0])).Text;
        pm = cmd.Parameters.Add(new SqlParameter("@price", SqlDbType.Money));
        pm.Value = ((TextBox)(e.Item.Cells[5].Controls[0])).Text;
        pm = cmd.Parameters.Add(new SqlParameter("@available", SqlDbType.Int));
        pm.Value = Convert.ToInt16(((TextBox)(e.Item.Cells[6].Controls[0])).Text);
        pm = cmd.Parameters.Add(new SqlParameter("@minstock", SqlDbType.Int));
        pm.Value = Convert.ToInt16(((TextBox)(e.Item.Cells[7].Controls[0])).Text);
        pm = cmd.Parameters.Add(new SqlParameter("@reorder", SqlDbType.Int));
        pm.Value = Convert.ToInt16(((TextBox)(e.Item.Cells[8].Controls[0])).Text);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        cmd = null;
        DataGrid1.EditItemIndex = -1;
        bindgrid();
        rfvname.Enabled = true;
        revmin.Enabled = true;
        revprice.Enabled = true;
        revquantity.Enabled = true;
        revreorder.Enabled = true;
        rfvreorder.Enabled = true;
        rfvmin.Enabled = true;
        rfvquantity.Enabled = true;
        rfvprice.Enabled = true;
    }

    private void DataGrid1_EditCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
    {
        DataGrid1.EditItemIndex = e.Item.ItemIndex;
        bindgrid();
        rfvname.Enabled = false;
        revmin.Enabled = false;
        revprice.Enabled = false;
        revquantity.Enabled = false;
        revreorder.Enabled = false;
        rfvreorder.Enabled = false;
        rfvmin.Enabled = false;
        rfvquantity.Enabled = false;
        rfvprice.Enabled = false;
    }

    private void DataGrid1_CancelCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
    {
        rfvname.Enabled = true;
        revmin.Enabled = true;
        revprice.Enabled = true;
        revquantity.Enabled = true;
        revreorder.Enabled = true;
        rfvreorder.Enabled = true;
        rfvmin.Enabled = true;
        rfvquantity.Enabled = true;
        rfvprice.Enabled = true;
        DataGrid1.EditItemIndex = -1;
        bindgrid();
    }

    private void DataGrid1_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
    {
        DataGrid1.CurrentPageIndex = e.NewPageIndex;
        bindgrid();
    }

    protected void btncreatDesig_Click1(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("select Max(raw_material_id)+1 from raw_material_master", con);
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
        SqlCommand cmd1 = new SqlCommand("insert into raw_material_master values("+str1+",'"+txtname.Text+"','"+txtdesc.Text+"',"+txtprice.Text+","+txtavail.Text+","+txtmin.Text+","+txtreorder.Text+")",con);
        con.Open();
        cmd1.ExecuteNonQuery();
        con.Close();
    }
}
