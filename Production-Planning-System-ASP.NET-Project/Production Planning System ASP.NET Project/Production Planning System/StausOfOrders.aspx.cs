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

public partial class StausOfOrders : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
    private void Page_Load(object sender, System.EventArgs e)
    {
        if (!(Page.IsPostBack))
        {
            TextBox1.Text = Session["empno"].ToString();
        }
    }
    private void btnShowStatus_Click(object sender, System.EventArgs e)
    {
        bindgrid();
    }
     
   
    //public void GridView1_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
    //{
    //    GridView1.PageIndex = e.NewPageIndex; 
                
    //    bindgrid();
    //}


    private void bindgrid()
    {

        //SqlConnection con = new SqlConnection();
        //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        SqlDataAdapter Da = new SqlDataAdapter("SELECT * FROM Sales_Order_master Where sales_exec_no = " + Session["empno"] + "", con);
        DataSet ds = new DataSet();
        con.Open();
        Da.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            GridView1.Visible = true;
            GridView1.DataSource = ds;
            GridView1.DataBind();
            Label1.Text = "Your orders status details";

        }
        else
        {
            GridView1.Visible = false;
            Label1.Text = " You don't have any orders now";
        }
    }

    private void LinkButton1_Click(object sender, System.EventArgs e)
    {
        FormsAuthentication.SignOut();
        Response.Redirect("LogInForm.aspx");
    }

    
    protected void btnShowStatus_Click3(object sender, EventArgs e)
    {
        bindgrid(); 
    }




    //protected void TextBox1_TextChanged(object sender, EventArgs e)
    //{

    //}
    protected void TextBox1_TextChanged1(object sender, EventArgs e)
    {

    }
}
