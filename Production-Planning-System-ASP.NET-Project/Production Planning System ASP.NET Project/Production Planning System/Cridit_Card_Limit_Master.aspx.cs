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

public partial class Cridit_Card_Limit_Master : System.Web.UI.Page
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
            bindgrid();
        }
    }
    protected void Button1_Click(object sender, System.EventArgs e)
    {
        ////SqlConnection con = new SqlConnection();
        ////SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        //string sql = "INSERT INTO Credit_Limit_Master(Credit_Rating_Limit,Credit_Rating_Description) VALUES(@name,@desc)";
        //SqlCommand cmd = new SqlCommand(sql, con);
        //SqlParameter pm;
        //pm = cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.Money));
        //pm.Value = Convert.ToInt64(txtlimit.Text);
        //pm = cmd.Parameters.Add(new SqlParameter("@desc", SqlDbType.NVarChar));
        //pm.Value = txtdesc.Text;
        //con.Open();
        //cmd.ExecuteNonQuery();
        //con.Close();
        //cmd = null;
        //con.Close();
        //bindgrid();
        //txtdesc.Text = "";
        //txtlimit.Text = "";
    }

    private void bindgrid()
    {
        //SqlConnection con = new SqlConnection();
        //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        //SqlCommand cmd = new SqlCommand("SELECT credit_limit_id,Credit_Limit_Master,credit_rating_description FROM Credit_Limit_Master", con);
        //con.Open();
        //SqlDataAdapter da = new SqlDataAdapter(cmd);
        //DataSet ds = new DataSet();
        //da.Fill(ds);
        //GridView1.DataSource=ds;
        //GridView1.DataBind();
        //con.Close();
        //cmd = null;
    }

 void DataGrid1_Delete(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
 {
   //SqlConnection con = new SqlConnection();
   //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
   int value = Convert.ToInt32(e.Item.Cells[0].Text);
   string sql = "DELETE FROM Credit_Limit_Master WHERE Credit_Limit_ID = " + value + "";
   SqlCommand cmd = new SqlCommand(sql, con);
   con.Open();
   cmd.ExecuteNonQuery();
   con.Close();
   cmd = null;
   //bindgrid();
 }

 private void DataGrid1_UpdateCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
 {
   //SqlConnection con = new SqlConnection();
   //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
   string sql = "UPDATE Credit_Limit_Master SET Credit_Rating_Limit=@limit,Credit_Rating_Description=@desc WHERE Credit_Limit_ID=@id";
   SqlCommand cmd = new SqlCommand(sql, con);
   SqlParameter pm;
   pm = cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
   pm.Value = Convert.ToInt16(e.Item.Cells[0].Text);
   pm = cmd.Parameters.Add(new SqlParameter("@Limit", SqlDbType.Money));
   pm.Value = ((TextBox)(e.Item.Cells[3].Controls[0])).Text;
   pm = cmd.Parameters.Add(new SqlParameter("@desc", SqlDbType.NVarChar));
   pm.Value = ((TextBox)(e.Item.Cells[4].Controls[0])).Text;
   con.Open();
   cmd.ExecuteNonQuery();
   con.Close();
   cmd = null;
   con.Close();
   //DataGrid1.EditItemIndex = -1;
   //bindgrid();
   rfvlimit.Enabled = true;
   rfvdesc.Enabled = true;
 }

 //private void DataGrid1_CancelCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
 //{
 //  DataGrid1.EditItemIndex = -1;
 //  bindgrid();
 //  rfvlimit.Enabled = true;
 //  rfvdesc.Enabled = true;
 //}

 //private void DataGrid1_EditCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
 //{
 //  rfvlimit.Enabled = false;
 //  rfvdesc.Enabled = false;
 //  DataGrid1.EditItemIndex = e.Item.ItemIndex;
 //  bindgrid();
 //}

 //private void DataGrid1_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
 //{
 //  DataGrid1.CurrentPageIndex = e.NewPageIndex;
 //  bindgrid();
 //}

    protected void Button1_Click1(object sender, EventArgs e)
    {
        SqlCommand cmd1 = new SqlCommand("select Max(credit_limit_id)+1 from Credit_Limit_Master", con);
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
        //SqlConnection con = new SqlConnection();
        //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        string sql = "INSERT INTO Credit_Limit_Master(credit_limit_id,Credit_Limit_Master,Credit_Rating_Description) VALUES("+str1+",@name,@desc)";
        SqlCommand cmd = new SqlCommand(sql, con);
        SqlParameter pm;
        pm = cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.Money));
        pm.Value = Convert.ToInt64(txtlimit.Text);
        pm = cmd.Parameters.Add(new SqlParameter("@desc", SqlDbType.NVarChar));
        pm.Value = txtdesc.Text;
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        cmd = null;
        con.Close();
        bindgrid();
        txtdesc.Text = "";
        txtlimit.Text = "";



        
    }
    //protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    //{
        

    //}
    //protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
    //{

    //}
    protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
    {

    }
}
    

