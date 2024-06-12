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

public partial class Submit_Forecast_Details : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
    SqlDataReader dr;
    int offid;
    int i;
    private void Page_Init(object sender, System.EventArgs e)
    {
        //InitializeComponent();
    }

    private void Page_Load(object sender, System.EventArgs e)
    {
        Label1.Text = "";
        if (Page.IsPostBack == false)
        {
            //SqlConnection con = new SqlConnection();
            //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
            SqlCommand cmd = new SqlCommand("SELECT model_no,Model_Name FROM Power_Tool_Model_Master", con);

            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
            }
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
            ddlModelNo.Items.Add("Select Model");
            while ((dr.Read()))
            {
                ddlModelNo.Items.Add(dr[1].ToString());
                ddlModelNo.SelectedValue = dr[0].ToString();
            }
            con.Close();
            dr = null;
            DataTable tb = new DataTable();
            cmd = null;
            tb.Columns.Add(new DataColumn("ModelNo", System.Type.GetType("System.Int16")));
            tb.Columns.Add(new DataColumn("PredictedQty", System.Type.GetType("System.Int16")));
            tb.Columns.Add(new DataColumn("Varience", System.Type.GetType("System.Int16")));
            Session["table"] = tb;

        }
    }
    private void Cancel_Click(object sender, System.EventArgs e)
    {
        clean();
    }

    private void btnSubmit_Click(object sender, System.EventArgs e)
    {
        
        }
    

    private void btnAddToOrder_Click(object sender, System.EventArgs e)
    {
        //if (ddlModelNo.SelectedIndex == 0)
        //{
        //    Label1.Text = "First Select Model";
        //}
        //else if ((txtQty.Text == ""))
        //{
        //    Label1.Text = "Enter Quantity";
        //}
        //else if ((ddlModelNo.Items.Count == 0))
        //{
        //    Label1.Text = "First submit the present orders then again select orders";
        //}
        //else if ((txtVarience.Text == ""))
        //{
        //    Label1.Text = "Enter Variance";
        //}
        //else
        //{            
        //    //SqlDataReader dr;
        //    //DataTable ta = new DataTable(Session["table"].ToString());
        //    //dr = ta.NewRow();
        //    //dr["ModelNo"] = ddlModelNo.SelectedItem.Value;
        //    //dr["PredictedQty"] = Convert.ToInt32(txtQty.Text);
        //    //dr["Varience"] = Convert.ToInt32(txtVarience.Text);
        //    //ta.Rows.Add[dr];
        //    //Session["table"] = ta;
        //    //DataView dv = new DataView();
        //    //DataGrid1.DataSource = dv;
        //    //DataGrid1.DataBind();
        //    ddlModelNo.Items.RemoveAt(ddlModelNo.SelectedIndex);
        //}
        //txtQty.Text = "";
        //txtVarience.Text = "";
    }

    private void clean()
    {
        DataTable table =new DataTable(Session["table"].ToString()) ;
        table.Rows.Clear();
        //DataView dv = new DataView(table);
        //DataGrid1.DataSource = dv;
        //DataGrid1.DataBind();
    }

    private void ForecastDetails(int max, int index)
    {
        //SqlConnection con = new SqlConnection();
        ////SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        //SqlCommand cmd = new SqlCommand("INSERT INTO Forecast_Details(Forecast_ID,Model_ID,Qty_Predicted,Varience) values(@Forecast_ID,@Model_ID,@Qty_Predicted,@Varience)", con);
        //SqlParameter p;
        //DataTable ta =new DataTable(Session["table"].ToString()) ;
        // p = cmd.Parameters.Add(new SqlParameter("@Forecast_ID", SqlDbType.Int));
        //p.Value = max;
        //p = cmd.Parameters.Add(new SqlParameter("@Model_ID", SqlDbType.Int));
        //p.Value = Convert.ToInt16(ta.Rows[index].ItemArray[0]); 
        //p = cmd.Parameters.Add(new SqlParameter("@Qty_Predicted", SqlDbType.Int));
        //p.Value = ta.Rows[index].ItemArray[1]; 
        //p = cmd.Parameters.Add(new SqlParameter("@Varience", SqlDbType.Int));
        //p.Value = ta.Rows[index].ItemArray[2]; 
        //if (con.State == ConnectionState.Closed)
        //{
        //    con.Open();
        //}
        //cmd.ExecuteNonQuery();
        //if (con.State == ConnectionState.Open)
        //{
        //    con.Close();
        //}
        //con.Close();
    }

    private void modelnoassign()
    {
        ddlModelNo.Items.Clear();
        //SqlConnection con = new SqlConnection();
        //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        SqlCommand cmd = new SqlCommand("SELECT model_no,Model_Name FROM Power_Tool_Model_Master", con);
        SqlDataReader dr;
        con.Open();
        dr = cmd.ExecuteReader();
        ddlModelNo.Items.Add("Select Model");
        while ((dr.Read()))
        {
            ddlModelNo.Items.Add(dr[0].ToString());     
            //ddlModelNo.Items(ddlModelNo.Items.Count - 1).value = dr[0];
        }
        con.Close();
        dr = null;
        cmd = null;
    }


    private object findoffice()
    {
        //SqlConnection con = new SqlConnection();
        //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        SqlCommand cmd = new SqlCommand("SELECT sales_office_id FROM Sales_Office_Master where Sales_Office_Incharge_Id=" + Session["empno"] + "", con);
       // SqlCommand cmd = new SqlCommand("SELECT sales_office_id FROM sales_office_master where sales_office_incharge_id=" + Session["empno"] + "", con);
        int a = int.Parse(Session["empno"].ToString());  
      
        con.Open();
        
        try
        {
            offid =Convert.ToInt32(cmd.ExecuteScalar().ToString());
        }
        catch
        {
        }
        con.Close();
        dr = null;
        cmd = null;
        return offid;
    }

    private void LinkButton1_Click(object sender, System.EventArgs e)
    {
        FormsAuthentication.SignOut();
        Response.Redirect("LogInForm.aspx");
    }




    protected void btnSubmit_Click2(object sender, EventArgs e)
    {
        object officeid =findoffice();
        if ((Session["countforecast"].ToString()  == ""))
        {
            Label1.Text = "First Slect the Orders then submit them";
        }
        else
        {

            SqlCommand cmd1 = new  SqlCommand("select count(*) from Forecast_Master", con);
            con.Open();
            int count1 = Convert.ToInt32(cmd1.ExecuteScalar().ToString());
            con.Close();
            if (count1!=0)
            {

                SqlCommand cmd2 = new  SqlCommand("select max(Forecast_ID)+1 from Forecast_Master", con);
                con.Open();
                int count2 = Convert.ToInt32(cmd2.ExecuteScalar().ToString());
                con.Close();

                Session["forecastid"] = count2;
                
            }
            else
            {
                Session["forecastid"] = "1".ToString();
            }


            //SqlCommand cmd3 = new SqlCommand("select max(Forecast_ID)+1 from Forecast_Master", con);
            //DataSet ds = new DataSet();
            //con.Open(); 
            //da.Fill(ds);
            //con.Close(); 
            // string a = ds.Tables[0].Rows[0][0].ToString();
            string  b = Convert.ToString(DateTime.Now.Year);
            string c = Convert.ToString(DateTime.Now.ToShortDateString());
            SqlCommand cmd = new SqlCommand("insert into Forecast_Master values(" + Session["forecastid"].ToString() + "," + ddlMonth.SelectedValue + "," + officeid.ToString() + ",'" + c.ToString() + "','" + b.ToString() + "')", con);
             con.Open();
             cmd.ExecuteNonQuery();
             con.Close(); 

            
        }
    }
    protected void btnAddToOrder_Click1(object sender, EventArgs e)
    {
         if (ddlModelNo.SelectedIndex == 0)
        {
            Label1.Text = "First Select Model";
        }
        else if ((txtQty.Text == ""))
        {
            Label1.Text = "Enter Quantity";
        }
        else if ((ddlModelNo.Items.Count == 0))
        {
            Label1.Text = "First submit the present orders then again select orders";
        }
        else if ((txtVarience.Text == ""))
        {
            Label1.Text = "Enter Variance";
        }
        else
        {
           int fore_cast_id;
           SqlCommand cmdd = new SqlCommand("select count(*) from forecastdata", con);
           con.Open();
           int count_forecast=Convert.ToInt32(cmdd.ExecuteScalar().ToString());
                con.Close();
           if (count_forecast==0)
            {

                Session["forecastid"] = 1;

            }
            else
            {
                SqlCommand cmdd1 = new SqlCommand("select max(Forecast_ID)+1 from forecastdata", con);
                con.Open();
                Session["forecastid"] = Convert.ToInt32(cmdd1.ExecuteScalar().ToString());
                con.Close();
            }
            object officeid = findoffice();
            SqlCommand cmd = new SqlCommand("insert into forecastdata values(" + Session["forecastid"].ToString() + ",'" + ddlModelNo.SelectedValue + "'," + txtQty.Text + "," + txtVarience.Text + ",'" + DateTime.Now.ToShortDateString() + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            SqlDataAdapter da = new SqlDataAdapter("select *from forecastdata", con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds);
            DataGrid1.DataSource = ds;
            DataGrid1.DataBind();
            con.Close();
            Session["countforecast"] = ds.Tables[0].Rows.Count;    
        }

  
    }
    protected void Cancel_Click1(object sender, EventArgs e)
    {

    }
    protected void ddlModelNo_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void ddlModelNo_SelectedIndexChanged1(object sender, EventArgs e)
    {

    }
}
