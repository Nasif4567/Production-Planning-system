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

public partial class ProcessCustomersOrders : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
    SqlDataReader dr;
    private void Page_Load(object sender, System.EventArgs e)
    {
        if (!(Page.IsPostBack))
        {
            //SqlDataAdapter da1 = new SqlDataAdapter("select model_no from power_tool_model_master order by  model_no ASC", con);
            SqlDataAdapter da1 = new SqlDataAdapter("select distinct(model_no) from forecastdata", con); 
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            ddlModel.DataSource = ds1;
            ddlModel.DataTextField = "model_no";
            ddlModel.DataValueField="model_no";  
            ddlModel.DataBind();

            fillgrid(); 
            ////SqlConnection con = new SqlConnection();
            ////SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
            //DataSet ds = new DataSet();
            //DataTable modelnum = new DataTable();
            //string sql2 = "SELECT * FROM Model_Quantity_Requaired";
            //SqlCommand cmd = new SqlCommand(sql2, con);
            //string sqlno = "Select distinct model_no From Power_Tool_Model_Master";
            //SqlCommand cmd1 = new SqlCommand(sqlno, con);
            //SqlDataAdapter da = new SqlDataAdapter(cmd1);
            //try
            //{
            //    da.Fill(modelnum);
            //}
            //catch (SqlException ex)
            //{
            //}
            //Session["modelnum"] = modelnum;
            //con.Open();
            //try
            //{
            //    dr = cmd.ExecuteReader();
            //}
            //catch (SqlException ex)
            //{
            //}
            //DataGrid1.DataSource = dr;
            //DataGrid1.DataBind();
            //con.Close();
            //dr.Close();
            //cmd.CommandText = "SELECT model_no FROM Power_Tool_Model_Master";
            //con.Open();
            //try
            //{
            //    dr = cmd.ExecuteReader();
            //}
            //catch (SqlException ex)
            //{
            //}
            //while ((dr.Read()))
            //{
            //    ddlModel.Items.Add(dr[0].ToString());
            //}
            //dr.Close();
            //con.Close();
            //bindgrid2();
        }
    }
    //private void ProcessOrders(string s)
    //{
    //    string sql = "SELECT sales_order_no From Sales_Order_Master inner join Sales_Order_Details on Sales_Order_Master.sales_order_no=Sales_Order_Details.sales_order_no where model_no =3 And sale_orders_satus ='p'";
    //}
    public void fillgrid()
    {
        SqlDataAdapter da2 = new SqlDataAdapter("SELECT SUM(PredictedQty) as Total, model_no FROM forecastdata GROUP BY  model_no", con);
        DataSet ds2 = new DataSet();
        da2.Fill(ds2);
        GridView1.DataSource = ds2;
        GridView1.DataBind();  
    }


    public void cancelstatus(string st)
    {
        SqlDataAdapter da1 = new SqlDataAdapter("select * from forecastdata where  model_no='" + ddlModel.SelectedValue + "'", con);
        DataSet ds1 = new DataSet();
        da1.Fill(ds1);
        Session["salesofficeid"] = ds1.Tables[0].Rows[0][0].ToString();
        string  a = Session["salesofficeid"].ToString();
        SqlDataAdapter da = new SqlDataAdapter("update Sales_Order_Master set sale_orders_satus = '" + st + "' where sales_offices_id = "+Session["salesofficeid"]+"", con);
        DataSet ds = new DataSet();
        da.Fill(ds);
       
    }
    public void updatequantitygrid()
    {
        SqlDataAdapter da = new SqlDataAdapter("select PredictedQty from forecastdata where model_no='" + ddlModel.SelectedValue + "' and Sales_Office_ID=(select distinct sales_offices_id from Sales_Order_Master where sale_orders_satus='cancel')",con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        Session["PredictedQty"] = int.Parse(ds.Tables[0].Rows[0][0].ToString());
        //SqlDataAdapter da2 = new SqlDataAdapter("select PredictedQty from forecastdata where model_no='" + ddlModel.SelectedValue + "'", con);
        //DataSet ds2 = new DataSet();
        //da2.Fill(ds2);
  

        int a = int.Parse(Session["PredictedQty"].ToString());
        SqlDataAdapter da1 = new SqlDataAdapter("update forecastdata set PredictedQty =  PredictedQty - " + a + " where  model_no= '" + ddlModel.SelectedValue + "'", con);
        DataSet ds1 = new DataSet();
        da1.Fill(ds1);
        fillgrid(); 
        //GridView1.DataSource = ds1;
        //GridView1.DataBind();   


    }


    private void Button4_Click(object sender, System.EventArgs e)
    {
        //SqlConnection con = new SqlConnection();
        //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        ProductionRequest();
        string sql = "Update Sales_Order_Master set sale_orders_satus='c' WHERE sale_orders_satus='p'";
        SqlCommand cmd = new SqlCommand(sql, con);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        bindgrid2();
    }

    void bindgrid2()
    {
        //int i = 0;
        //DataTable dss=new DataTable(Session["modelnum"].ToString());
        //DataTable tab=new DataTable();
        //DataTable tb = new DataTable();
        
        //tb.Columns.Add(new DataColumn("Model_No", System.Type.GetType("System.Int16")));
        //tb.Columns.Add(new DataColumn("Model_Qty", System.Type.GetType("System.Int16")));
        //Session["table"] = tb;
        //for (i = 0; i <= dss.Rows.Count - 1; i++)
        //{
        //    retrieve(Convert.ToInt32(dss.Rows[i].ItemArray[0]));
        //}
        //DataView dv = new DataView();
        //tab.TableName=Session["table"].ToString();
        //dv = tab.DefaultView;
        //DataGrid2.DataSource = dv;
        //DataGrid2.DataBind();
    }

    void retrieve(int modelno)
    {
//        //SqlConnection con = new SqlConnection();
//        //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
//        string sqlno = "SELECT SUM (sales_order_qty) From Sales_Order_Master inner join Sales_Order_Details on Sales_Order_Master.sales_order_no=Sales_Order_Details.sales_order_no where model_no = " + modelno + " And sale_orders_satus ='p'";
//        SqlCommand cmd = new SqlCommand(sqlno, con);
//        DataTable ts=new DataTable(Session["table"].ToString());
      
//        string row = ts.NewRow().ToString();
//        if (con.State == ConnectionState.Closed)
//        {
//            con.Open();
//        }
        
////        ts.Rows[0] = modelno.ToString();
////        //row[0] = modelno;
////        ts.Rows[1] = cmd.ExecuteScalar();
//////        row[1] = cmd.ExecuteScalar();
////        con.Close();
////        ts.Rows.Add[row];
//        Session["table"] = ts;
    }

    private void btnRejectLast_Click(object sender, System.EventArgs e)
    {
        //SqlConnection con = new SqlConnection();
        //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        int modelno = Convert.ToInt16(ddlModel.SelectedItem.Text);
        string s = "SELECT max( Sales_Order_Master.sales_order_no) FROM Sales_Order_Master INNER JOIN Sales_Order_Details ON Sales_Order_Master.sales_order_no = Sales_Order_Details.sales_order_no where model_no=" + modelno + " and sale_orders_satus='p'";
        SqlCommand comm = new SqlCommand(s, con);
        con.Open();
        int orderno = Convert.ToInt32(comm.ExecuteScalar().ToString());
        con.Close();
        string sqlupdate = "Update Sales_Order_Master set sale_orders_satus='r' WHERE sales_order_no =" + orderno + "";
        con.Open();
        comm.CommandText = sqlupdate;
        comm.ExecuteNonQuery();
        con.Close();
        bindgrid2();
    }

    private void Button5_Click(object sender, System.EventArgs e)
    {
        //SqlConnection con = new SqlConnection();
        //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        ProductionRequest();
        string sqlupdate = "Update Sales_Order_Master set sale_orders_satus='r' WHERE sale_orders_satus ='p'";
        con.Open();
        cmd.CommandText = sqlupdate;
        cmd.ExecuteNonQuery();
        con.Close();
        bindgrid2();
    }

    private void ProductionRequest()
    {
        //SqlConnection con = new SqlConnection();
        //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        string sql1 = "Insert Into Production_Request_Master(prod_req_date,exp_date_of_delv,prod_req_incharge_id)values(@nowdate,@datedelv,@incharge)";
        SqlCommand cmd = new SqlCommand(sql1, con);
        SqlParameter pm;
        pm = cmd.Parameters.Add(new SqlParameter("@nowdate", SqlDbType.DateTime));
        pm.Value = DateTime.Now; 
        pm = cmd.Parameters.Add(new SqlParameter("@datedelv", SqlDbType.DateTime));
        pm.Value = DateTime.Now.AddDays(14);
        pm = cmd.Parameters.Add(new SqlParameter("@incharge", SqlDbType.Int));
        pm.Value = 14;
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        cmd.CommandText = "Select MAX(prod_req_No)From Production_Request_Master";
        int prodreqno;
        con.Open();
        prodreqno = int.Parse(cmd.ExecuteScalar().ToString()) ;
        con.Close();
        string sql = "SELECT Sales_Order_Master.sales_order_no FROM Sales_Order_Details INNER Join Sales_Order_Master ON Sales_Order_Details.sales_order_no = Sales_Order_Master.sales_order_no where Sales_Order_Master.sale_orders_satus='P'";
        SqlDataAdapter da = new SqlDataAdapter(sql, con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        int i;
        for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
        {
            insertPrequestdetails(prodreqno,Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[0]));
                
        }
    }

    private void insertPrequestdetails(int prodreqno, int orderno)
    {
        //SqlConnection con = new SqlConnection();
        //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        string sql = "Insert Into Production_Request_Details(prod_req_no,sales_order_no)Values(@reqno,@orderno)";
        SqlCommand cmd = new SqlCommand(sql, con);
        SqlParameter pm;
        pm = cmd.Parameters.Add(new SqlParameter("@reqno", SqlDbType.Int));
        pm.Value = prodreqno;
        pm = cmd.Parameters.Add(new SqlParameter("@orderno", SqlDbType.Int));
        pm.Value = orderno;
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
    }

    private void LinkButton1_Click(object sender, System.EventArgs e)
    {
        FormsAuthentication.SignOut();
        Response.Redirect("LogInForm.aspx");
    }

    protected void Button4_Click1(object sender, EventArgs e)
    {
        GridView1.Visible = true;
        string st = "process";
        cancelstatus(st);
        //ProductionRequest();
        //string sql = "Update Sales_Order_Master set sale_orders_satus='c' WHERE sale_orders_satus='process'";
        //SqlCommand cmd = new SqlCommand(sql, con);
        //con.Open();
        //cmd.ExecuteNonQuery();
        //con.Close();
        //bindgrid2();
    }
    protected void btnRejectLast_Click1(object sender, EventArgs e)
    {
        GridView1.Visible = true;
        string st = "cancel";
        cancelstatus(st);
        updatequantitygrid();
    }
    protected void Button5_Click1(object sender, EventArgs e)
    {
          
        SqlDataAdapter da1 = new SqlDataAdapter("select Sales_Office_ID from forecastdata where  model_no='" + ddlModel.SelectedValue + "'", con);
        DataSet ds1 = new DataSet();
        da1.Fill(ds1);
        Session["salesofficeid"] = ds1.Tables[0].Rows[0][0].ToString();
        string  a = Session["salesofficeid"].ToString();
        SqlDataAdapter da = new SqlDataAdapter("update Sales_Order_Master set sale_orders_satus = 'Rejected'", con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        GridView1.Visible = false;  
    }
    
}
