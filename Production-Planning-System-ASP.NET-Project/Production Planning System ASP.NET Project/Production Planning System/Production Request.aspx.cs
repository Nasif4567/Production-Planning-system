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

public partial class Production_Request : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
    private void Page_Load(object sender, System.EventArgs e)
    {
        if (!(Page.IsPostBack))
        {
            //SqlConnection con = new SqlConnection();
            //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
            string sql = "SELECT distinct pp.dbo.Production_Request_Master.prod_req_no FROM pp.dbo.Sales_Order_Master INNER JOIN pp.dbo.Production_Request_Details ON pp.dbo.Sales_Order_Master.sales_order_no = pp.dbo.Production_Request_Details.sales_order_no INNER JOIN pp.dbo.Production_Request_Master ON pp.dbo.Production_Request_Details.prod_req_no = pp.dbo.Production_Request_Master.prod_req_no WHERE pp.dbo.Sales_Order_Master.sale_orders_satus = 'c'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr;
            con.Open();
            dr = cmd.ExecuteReader();
            while ((dr.Read()))
            {
                ddlprno.Items.Add("prodReqNo" + dr[0]);
            }
            con.Close();
            dr.Close();
            cmd.CommandText = "Select Machine_id from Machine_Master";
            con.Open();
            dr = cmd.ExecuteReader();
            while ((dr.Read()))
            {
                ddlmno.Items.Add("dr[0].ToString()" );
            }
        }
    }
}
