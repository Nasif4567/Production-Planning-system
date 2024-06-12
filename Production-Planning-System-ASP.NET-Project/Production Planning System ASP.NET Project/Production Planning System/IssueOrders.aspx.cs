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

public partial class IssueOrders : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
    SqlDataReader dr;
    int offid;
    private void Page_Init(object sender, System.EventArgs e)
    {
    }
    public DataTable tb = new DataTable();
    public DataRow dr1;
    private void Page_Load(object sender, System.EventArgs e)
    {
            SqlCommand cmd9 = new SqlCommand("SELECT MAX(sales_order_no)+1 from Sales_Order_Master", con);
            con.Open();
            Session["max"] = int.Parse(cmd9.ExecuteScalar().ToString());
            con.Close();
            Label1.Text = "";
        SqlCommand cmd = new SqlCommand("SELECT cust_no,cust_name from Customer_Master", con);
        SqlParameter pm;
        if (!(Page.IsPostBack))
        {
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
            bool state = true;
            while ((dr.Read()))
            {
                ddlCustNo.Items.Add(dr[0].ToString());
                if ((state))
                {
                    txtCustName.Text = dr[1].ToString();
                }
            }
            cmd.CommandText = "SELECT sales_office_id FROM sales_office_master";
            dr.Close();
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
            dr.Close();
            cmd.CommandText = "SELECT emp_no FROM Employee_Master";
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
            dr.Close();
            cmd.CommandText = "SELECT model_no FROM Power_Tool_Model_Master";
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
            while ((dr.Read()))
            {
                ddlModelNo.Items.Add(dr[0].ToString());
            }
            con.Close();
            dr = null;
            cmd = null;
            tb.Columns.Add(new DataColumn("ModelNo", System.Type.GetType("System.Int16")));
            tb.Columns.Add(new DataColumn("ModelQty", System.Type.GetType("System.Int16")));
            Session["table"] = tb;

             
        }
    }
    private void Cancel_Click(object sender, System.EventArgs e)
    {
        clean();
    }

    private void btnSubmit_Click(object sender, System.EventArgs e)
    {
        object officeid = findoffice();
        DataTable ta = new DataTable(Session["table"].ToString());
        
        if ((ta.Rows.Count == 0))
        {
            Label1.Text = "First Slect the Orders then submit them";
        }
        else if ((txtExpDelvDate.Text == ""))
        {
            Label1.Text = "Enter Expected Delivery Date";
        }
        else
        {
            string sql = "INSERT INTO Sales_Order_Master(sale_order_date,cust_no,exp_date_of_delivery,sales_offices_id,sales_exec_no,sale_orders_satus) VALUES(@sale_order_date,@cust_no,@exp_date_of_delivery,@sales_offices_id,@sales_exec_no,@sale_orders_satus)";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlParameter pm;
            int max;
            int i;
            pm = cmd.Parameters.Add(new SqlParameter("@sale_order_date", SqlDbType.DateTime));
            pm.Value = DateTime.Now;
            pm = cmd.Parameters.Add(new SqlParameter("@cust_no", SqlDbType.Int));
            pm.Value = Convert.ToInt32(ddlCustNo.SelectedItem.Text);
            pm = cmd.Parameters.Add(new SqlParameter("@exp_date_of_delivery", SqlDbType.DateTime));
            pm.Value = "#" + txtExpDelvDate.Text + "#";
            pm = cmd.Parameters.Add(new SqlParameter("@sales_offices_id", SqlDbType.Int));
            pm.Value = officeid;
            pm = cmd.Parameters.Add(new SqlParameter("@sales_exec_no", SqlDbType.Int));
            pm.Value = Session["empno"];
            pm = cmd.Parameters.Add(new SqlParameter("@sale_orders_satus", SqlDbType.Char));
            pm.Value = "p";
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
            cmd.CommandText = "SELECT MAX(sales_order_no) from Sales_Order_Master";
            con.Open();
            max = int.Parse(cmd.ExecuteScalar().ToString());
            con.Close();
            for (i = 0; i <= ta.Rows.Count - 1; i++)
            {
                salesorder(max, i);
            }
            cmd = null;
            con = null;
            clean();
            modelnoassign();
        }
    }

    private void ddlCustNo_SelectedIndexChanged(object sender, System.EventArgs e)
    {
        
    }

    private void btnAddToOrder_Click(object sender, System.EventArgs e)
    {
        if ((txtModelName.Text == ""))
        {
            Label1.Text = "Select Model Name";
        }
        else if ((txtQty.Text == ""))
        {
            Label1.Text = "Enter Quantity";
        }
        else if ((ddlModelNo.Items.Count == 0))
        {
            Label1.Text = "First submit the present orders then again select orders";
        }
        else
        {
            SqlDataAdapter da = new SqlDataAdapter("insert into Sales_Order_Details values(" + ddlModelNo.SelectedValue + "," + txtQty.Text + ")", con);
            DataSet ds = new DataSet();
        }
        txtQty.Text = "";
        txtModelName.Text = "";
    }

    private void clean()
    {
        txtCustName.Text = "";
        txtExpDelvDate.Text = "";
        DataTable table=new DataTable(Session["table"].ToString()) ;
          int i;
        
    }

    private void ddlModelNo_SelectedIndexChanged(object sender, System.EventArgs e)
    {
        
    }

    private void salesorder(int max, int index)
    {
        SqlCommand cmd = new SqlCommand("INSERT INTO Sales_Order_Details(sales_order_no,model_no,sales_order_qty) values(@sales_order_no,@model_no,@sales_order_qty)", con);
        SqlParameter p;
        DataTable ta=new DataTable(Session["table"].ToString()) ;
        
        p = cmd.Parameters.Add(new SqlParameter("@sales_order_no", SqlDbType.Int));
        p.Value = max;
        p = cmd.Parameters.Add(new SqlParameter("@model_no", SqlDbType.Int));
        p.Value = Convert.ToInt32(ta.Rows[index].ItemArray[0]);     
        p = cmd.Parameters.Add(new SqlParameter("@sales_order_qty", SqlDbType.Int));
        p.Value = ta.Rows[index].ItemArray[1];
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
        cmd.ExecuteNonQuery();
        if (con.State == ConnectionState.Open)
        {
            con.Close();
        }
        con.Close();
    }

    private void modelnoassign()
    {
        ddlModelNo.Items.Clear();
        SqlCommand cmd = new SqlCommand("SELECT model_no FROM Power_Tool_Model_Master", con);
        SqlDataReader dr;
        con.Open();
        dr = cmd.ExecuteReader();
        while ((dr.Read()))
        {
            ddlModelNo.Items.Add(Convert.ToString(dr[0]));
        }
        con.Close();
        dr = null;
        cmd = null;
    }

    private object findoffice()
    {
        SqlCommand cmd = new SqlCommand("SELECT sales_office_id FROM sales_office_master where sales_office_incharge_id=" + Session["empno"].ToString() + "", con);
        con.Open();
       
        try
        {
            offid = int.Parse(cmd.ExecuteScalar().ToString());
            Session["officeid"]= int.Parse(cmd.ExecuteScalar().ToString());
        }
        catch
        {
        }
        con.Close();
        return offid;
    }

    private void LinkButton1_Click(object sender, System.EventArgs e)
    {
        FormsAuthentication.SignOut();
        Response.Redirect("LogInForm.aspx");
    }

    protected void ddlCustNo_SelectedIndexChanged1(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        SqlDataAdapter DA = new SqlDataAdapter("SELECT cust_name from Customer_Master where cust_no=" + ddlCustNo.SelectedValue + "", con);
        DataSet DS = new DataSet();
        con.Open();
        DA.Fill(DS);
        txtCustName.Text = DS.Tables[0].Rows[0][0].ToString();
       
        con.Close();
    }
    protected void txtCustName_TextChanged(object sender, EventArgs e)
    {

    }
    protected void ddlModelNo_SelectedIndexChanged1(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        SqlDataAdapter DA = new SqlDataAdapter("SELECT model_name from power_tool_model_master where model_no=" + ddlModelNo.SelectedValue + "", con);
        DataSet DS = new DataSet();
        con.Open();
        DA.Fill(DS);
        txtModelName.Text = DS.Tables[0].Rows[0][0].ToString();
        con.Close();
    }

    protected void btnAddToOrder_Click1(object sender, EventArgs e)
    {

        if ((txtModelName.Text == ""))
        {
            Label1.Text = "Select Model Name";
        }
        else if ((txtQty.Text == ""))
        {
            Label1.Text = "Enter Quantity";
        }
        else if ((ddlModelNo.Items.Count == 0))
        {
            Label1.Text = "First submit the present orders then again select orders";
        }
        else
        {   SqlDataAdapter da = new SqlDataAdapter("Insert into  Sales_Order_Details values("+Session["max"].ToString()+"," + ddlModelNo.SelectedValue + "," + txtQty.Text + ")", con);
            DataSet ds = new DataSet();
            con.Open(); 
            da.Fill(ds);
            con.Close(); 
            
            }
    }

    protected void btnSubmit_Click1(object sender, EventArgs e)
    {
        SqlDataAdapter da = new SqlDataAdapter("select * from Sales_Order_Details", con);
        DataSet ds = new DataSet();
        da.Fill(ds); 
        
        object officeid = findoffice();

        if (ds.Tables[0].Rows.Count== 0)
        {
            Label1.Text = "First Slect the Orders then submit them";
        }
        else if ((txtExpDelvDate.Text == ""))
        {
            Label1.Text = "Enter Expected Delivery Date";
        }
        else
        {
            modelnoassign();
            findoffice();
            string p = "p".ToString();
            SqlCommand cmd1 = new SqlCommand("insert into Sales_Order_Master values(" + Session["max"].ToString() + ",'" + DateTime.Now.ToShortDateString() + "'," + ddlCustNo.SelectedValue + ",'" + txtExpDelvDate.Text + "'," + Session["officeid"].ToString() + "," + Session["empno"].ToString() + ",'"+p.ToString()+"')", con);
            con.Open();
            cmd1.ExecuteNonQuery();  
            con.Close();    
        }

    }
}
