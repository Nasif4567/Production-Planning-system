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

public partial class SalesOffice : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
    string str;
    private void Page_Load(object sender, System.EventArgs e)
    {

        SqlDataAdapter da = new SqlDataAdapter("select s.sales_office_id from sales_office_master s,Employee_Master e where e.emp_no=" + Session["empno"] + "", con);
        //SqlDataAdapter da = new SqlDataAdapter("Select sales_office_id from Alerts,Employee_Master where emp_no=" + Session["empno"] + "", con);
        //SqlDataAdapter da = new SqlDataAdapter("select sales_office_id from Alerts where sales_office_id=(select sales_office_id from Employee_Master where emp_no=" + Session["empno"] + ")", con);
        //SqlDataAdapter da = new SqlDataAdapter("select sales_office_id from Alerts where sales_office_id=(Select sales_office_id from sales_office_Master,Employee_Master e where e.emp_no=" + Session["empno"] + ")", con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            Session["sofid"] = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            lblmsg.Visible = false;
            Label3.Visible = true;
            SqlDataAdapter da1 = new SqlDataAdapter("select alert_id,message_alerts from Alerts where sales_office_id=" + Session["sofid"] + "", con);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            DataGrid1.DataSource = ds1;
            DataGrid1.DataBind();
            GridView1.DataSource = ds1;
            GridView1.DataBind();
        }
        else
        {
            lblmsg.Visible = true;
            Label3.Visible = false;
        }
 
        //if (Page.IsPostBack == false)
        //{
        //    CheckForcastSubmission();
        //    lblmsg.Visible = false;
        //    bindgrid();
        TextBox1.Text = Session["username"].ToString();  
        //}
    }
    void DataGrid1_Delete(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
    {
        //SqlConnection con = new SqlConnection();
        //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        int value = Convert.ToInt32((e.Item.Cells[0].Text).ToString());
        string sql = "Select message_alerts FROM Alerts WHERE alert_id = " + value + "";
        SqlCommand cmd = new SqlCommand(sql, con);
        SqlDataReader dr;
        con.Open();
        dr = cmd.ExecuteReader();
        while ((dr.Read()))
        {
            lblmessage.Text = dr[0].ToString();
        }
        con.Close();
        cmd = null;
    }

    private void Button1_Click(object sender, System.EventArgs e)
    {
        //SqlConnection con = new SqlConnection();
        //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        int empno = Convert.ToInt32(Session["empno"]);
        string sql = "SELECT sales_office_id from sales_office_master where sales_office_incharge_id=" + empno + "";
        SqlCommand cmd = new SqlCommand(sql, con);
        int officeid;
        con.Open();
        officeid =int.Parse(cmd.ExecuteScalar().ToString());
        con.Close();
        cmd.CommandText = "Delete From Alerts Where sales_office_id=" + officeid + "";
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        Label3.Visible = false;
        DataGrid1.Visible = false;
        lblmessage.Visible = false;
        Button1.Visible = false;
    }

    private void bindgrid()
    {
        //SqlConnection con = new SqlConnection();
        //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        int empno = Convert.ToInt32(Session["empno"]);
        string sql = "SELECT Alerts.alert_id FROM Alerts INNER JOIN sales_office_master ON Alerts.sales_office_id = sales_office_master.sales_office_id where sales_office_master.sales_office_incharge_id = " + empno + "";
        SqlCommand cmd = new SqlCommand(sql, con);
        SqlDataReader dr;
        con.Open();
        dr = cmd.ExecuteReader();
        DataGrid1.DataSource = dr;
        DataGrid1.DataBind();
        dr.Close();
        con.Close();
        con.Open();
        dr = cmd.ExecuteReader();
        int mailcount = 0;
        while ((dr.Read()))
        {
            mailcount = mailcount + 1;
        }
        if (mailcount > 0)
        {
            Label3.Visible = true;
            DataGrid1.Visible = true;
            lblmessage.Visible = true;
            Button1.Visible = true;
        }
        else
        {
            lblmsg.Visible = true;
        }
        dr.Close();
        con.Close();
    }

    private void DataGrid1_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
    {
        DataGrid1.CurrentPageIndex = e.NewPageIndex;
        bindgrid();
    }

    private void LinkButton1_Click(object sender, System.EventArgs e)
    {
        FormsAuthentication.SignOut();
        Response.Redirect("LogInForm.aspx");
    }

    private void CheckForcastSubmission()
    {
        //SqlConnection con = new SqlConnection();
        //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        SqlDataReader dr;
        if ((DateTime.Now.Day== 9))
        {
            int empno = Convert.ToInt32(Session["empno"]);
            int officeid = findofficeid(empno);
           string month =Convert.ToString(DateTime.Now.Month + 2);
          
            if (month == "1")
            {
                str = "January";
            }
            else if (month == "2")
            {
                str = "February";
            }
            else if (month == "3")
            {
                str = "March";
            }
            else if (month == "4")
            {
                str = "April";
            }
            else if (month == "5")
            {
                str = "May";
            }
            else if (month == "6")
            {
                str = "June";
            }
            else if (month == "7")
            {
                str = "July";
            }
            else if (month =="8")
            {
                str = "August";
            }
            else if (month == "9")
            {
                str = "September";
            }
            else if (month == "10")
            {
                str = "October";
            }
            else if (month == "11")
            {
                str = "November";
            }
            else if (month == "12")
            {
                str = "December";
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * From Forecast_Master Where Forecast_Month=" + month + " and Forecast_Year=" +DateTime.Now.Year+ " and Sales_Office_ID=" + officeid + "";
            con.Open();
            dr=cmd.ExecuteReader();
            con.Close(); 
            string massage = "Upto now you have not submitted the Forcast Report for the Month " + str + " Please Submit it Erly";
            cmd.CommandText = "Insert Into Alerts(sales_office_id,message_alerts,message_status) values(" + officeid + ",'" + massage + "','new' )";
             con.Open();
             cmd.ExecuteNonQuery();
             con.Close();


        //    try
        //    {
        //        con.Open();
        //    }
        //    catch (Exception ex)
        //    {
        //        return;
        //    }
        //    try
        //    {
        //        dr = cmd.ExecuteReader();
        //    }
        //    catch (Exception ex)
        //    {
        //        con.Close();
        //        return;
        //    }
        //    if (!(dr.HasRows))
        //    {
        //        dr.Close();
        //        con.Close();
        //        string massage = "Upto now you have not submitted the Forcast Report for the Month " + str + " Please Submit it Erly";
        //        cmd.CommandText = "Insert Into Alerts values(" + officeid + ",'" + massage + "')";
        //        try
        //        {
        //            con.Open();
        //        }
        //        catch (Exception ex)
        //        {
        //            return;
        //        }
        //        try
        //        {
        //            cmd.ExecuteNonQuery();
        //        }
        //        catch (Exception ex)
        //        {
        //            con.Close();
        //            return;
        //        }
        //        dr.Close();
        //        con.Close();
        //    }
        //    else
        //    {
        //        dr.Close();
        //        con.Close();
               return;
           }
       
    }

    private int findofficeid(int empno)
    {
        //SqlConnection con = new SqlConnection();
       SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        //SqlDataReader dr;
        string sql = "SELECT sales_office_id from sales_office_master where sales_office_incharge_id=" + empno + "";
        SqlDataAdapter da = new SqlDataAdapter(sql, con);
        DataSet ds = new DataSet();
          con.Open();
          da.Fill(ds);  
        //dr = cmd.ExecuteScalar();
         int officeid;
         officeid = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());   
         //Response.Write(dr[0]);
          con.Close();
        return officeid;
        
    //    try
    //    {
    //        con.Open();
    //    }
    //    catch (Exception ex)
    //    {
    //        return -1;
    //    }
    //    Response.Write(empno);
    //    try
    //    {
    //        dr = cmd.ExecuteReader();
    //    }
    //    catch (Exception ex)
    //    {
    //        con.Close();
    //        return -1;
    //    }
    //    int officeid;
    //    if (dr.HasRows)
    //    {
    //        while ((dr.Read()))
    //        {
    //            officeid = Convert.ToInt32( dr[0]);
    //            Response.Write(dr[0]);
    //        }
    //    }
    //    else
    //    {
    //        dr.Close();
    //        con.Close();
    //        return -1;
    //    }
    //    dr.Close();
    //    con.Close();
    //    return officeid;
 }

    protected void Button1_Click1(object sender, EventArgs e)
    {

    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}
