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

public partial class OrderTrends : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
    int sum;
    private void Page_Load(object sender, System.EventArgs e)
    {
        Label5.Text = "";
        btnRaiseAlerts.Visible =false;
        if (!(Page.IsPostBack))
        {
            //SqlConnection con = new SqlConnection();
            //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
            string str = "SELECT sales_office_id FROM Sales_Office_Master";
            SqlCommand cmd = new SqlCommand(str, con);
            SqlDataReader dr;
            con.Open();
            dr = cmd.ExecuteReader();
            while ((dr.Read()))
            {
                ddlSalesID.Items.Add(dr[0].ToString());
            }
            con.Close();
            dr.Close();
            cmd.CommandText = "Select model_name From Power_Tool_Model_Master";
            con.Open();
            dr = cmd.ExecuteReader();
            while ((dr.Read()))
            {
                ddlmodel.Items.Add(dr[0].ToString());
            }
            dr.Close();
            con.Close();
        }
    }
    private void btnShowStatus_Click(object sender, System.EventArgs e)
    {
        //SqlConnection con = new SqlConnection();
        SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        string sql = "SELECT SUM(Sales_Order_Details.sales_order_qty)FROM Sales_Order_Details INNER JOIN Sales_Order_Master ON Sales_Order_Details.sales_order_no = Sales_Order_Master.sales_order_no where Sales_Order_Details.Model_No=" + ddlmodel.SelectedItem.Text + " and Sales_Order_Master.sales_offices_id=" + ddlSalesID.SelectedItem.Text + " and sale_orders_satus='p'";
        SqlCommand cmd = new SqlCommand(sql, con);
        con.Open();
        SqlDataReader dr;
        //int sum;
        try
        {
            sum = Convert.ToInt32(cmd.ExecuteScalar().ToString()) ;
        }
        catch (Exception ex)
        {
            lblorderqty.Text = "0";
        }
        lblorderqty.Text = sum.ToString();
        con.Close();
        cmd = null;
    }

    private void btnRaiseAlerts_Click(object sender, System.EventArgs e)
    {
        if ((txtraise.Text == ""))
        {
            Label5.Text = "Write some Message and then raise Alerts";
        }
        else
        {
            //SqlConnection con = new SqlConnection();
            //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
            string sql = "INSERT INTO Alerts(sales_office_id,message_alerts)VALUES(@id,@message)";
            SqlParameter pm;
            SqlCommand cmd = new SqlCommand(sql, con);
            pm = cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            pm.Value = Convert.ToInt32(ddlSalesID.SelectedItem.Text);
            pm = cmd.Parameters.Add(new SqlParameter("@message", SqlDbType.NVarChar));
            pm.Value = txtraise.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            cmd = null;
            txtraise.Text = "";
        }
    }

    private void LinkButton1_Click(object sender, System.EventArgs e)
    {
        FormsAuthentication.SignOut();
        Response.Redirect("LogInForm.aspx");
    }


    protected void btnShowStatus_Click1(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        string sql = "SELECT SUM(Sales_Order_Details.sales_order_qty)FROM Sales_Order_Details INNER JOIN Sales_Order_Master ON Sales_Order_Details.sales_order_no = Sales_Order_Master.sales_order_no where Sales_Order_Details.Model_No=" + ddlmodel.SelectedItem.Text + " and Sales_Order_Master.sales_offices_id=" + ddlSalesID.SelectedItem.Text + " and sale_orders_satus='p'";
        SqlCommand cmd = new SqlCommand(sql, con);
        con.Open();
        SqlDataReader dr;
        //int sum;
        try
        {
            sum = Convert.ToInt32(cmd.ExecuteScalar().ToString());
        }
        catch (Exception ex)
        {
            lblorderqty.Text = "0";
        }
        lblorderqty.Text = sum.ToString();
        con.Close();
        cmd = null;
    }


    protected void btnShowStatus_Click2(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        string sql = "SELECT SUM(Sales_Order_Details.sales_order_qty)FROM Sales_Order_Details INNER JOIN Sales_Order_Master ON Sales_Order_Details.sales_order_no = Sales_Order_Master.sales_order_no where Sales_Order_Details.Model_No=" + ddlmodel.SelectedItem.Text + " and Sales_Order_Master.sales_offices_id=" + ddlSalesID.SelectedItem.Text + " and sale_orders_satus='p'";
        SqlCommand cmd = new SqlCommand(sql, con);
        con.Open();
        SqlDataReader dr;
        //int sum;
        try
        {
            sum = Convert.ToInt32(cmd.ExecuteScalar().ToString());
        }
        catch (Exception ex)
        {
            lblorderqty.Text = "0";
        }
        lblorderqty.Text = sum.ToString();
        con.Close();
        cmd = null;
    }

    protected void btnShowStatus_Click3(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("select sum(PredictedQty)  from forecastdata,sales_office_master s where s.Sales_Office_ID=" + ddlSalesID.SelectedValue + "  and model_no='" + ddlmodel.SelectedValue + "'", con);
        con.Open();
        lblorderqty.Text = cmd.ExecuteScalar().ToString();
        con.Close();
        if (lblorderqty.Text == "")
        {
            //Session["lblorderqty"] = lblorderqty.Text;
            btnRaiseAlerts.Visible = true;
          
        }
  
    }
    protected void btnRaiseAlerts_Click1(object sender, EventArgs e)
    {


        SqlCommand cmd = new SqlCommand("insert into Alerts values (" + ddlSalesID.SelectedValue + ",'" + txtraise.Text + "','p')");
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
      
    }
    protected void btnRaiseAlerts_Click2(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("insert into Alerts values (" + ddlSalesID.SelectedValue + ",'" + txtraise.Text + "','p')");
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
      
    }

    protected void btnRaiseAlerts_Click3(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("insert into Alerts values (" + ddlSalesID.SelectedValue + ",'" + txtraise.Text + "','p')",con);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
    }
}
