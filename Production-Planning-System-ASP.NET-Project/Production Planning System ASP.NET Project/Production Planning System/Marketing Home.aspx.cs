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

public partial class Marketing_Home : System.Web.UI.Page
{
    //SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings("con"));
    SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");


    private void Page_Load(object sender, System.EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            CheckForcastSubmission();
            lblmsg.Visible = false;
           // bindgrid();
        }
    }
    //void DataGrid1_Delete(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
    //{
    //    int value = Convert.ToInt32(e.Item.Cells[0].Text);
    //    string sql = "Select message FROM Marketing_Alerts WHERE Message_id = " + value + "";
    //    SqlCommand cmd = new SqlCommand(sql, con);
    //    SqlDataReader dr;
    //    con.Open();
    //    dr = cmd.ExecuteReader();
    //    while (dr.Read())
    //    {
    //        lblmessage.Text = dr[0].ToString();
    //    }
    //    con.Close();
    //    cmd = null;
    //}

    private void Button1_Click(object sender, System.EventArgs e)
    {
        //SqlConnection con = new SqlConnection();
        SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        SqlCommand cmd = new SqlCommand("Delete From Marketing_Alerts", con);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        Label3.Visible = false;
        GridView1.Visible = false; 
      //  DataGrid1.Visible = false;
        lblmessage.Visible = false;
        Button1.Visible = false;
    }

    //private void bindgrid()
    //{
    //    //SqlConnection con = new SqlConnection();
    //    SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
    //    int empno =Convert.ToInt32( Session["empno"]);
    //    string sql = "SELECT Message_ID FROM Marketing_Alerts";
    //    SqlCommand cmd = new SqlCommand(sql, con);
    //    SqlDataReader dr;
    //    con.Open();
    //    dr = cmd.ExecuteReader();
    //    DataGrid1.DataSource = dr;
    //    DataGrid1.DataBind();
    //    dr.Close();
    //    con.Close();
    //    con.Open();
    //    dr = cmd.ExecuteReader();
    //    int mailcount = 0;
    //    while ((dr.Read()))
    //    {
    //        mailcount = mailcount + 1;
    //    }
    //    if (mailcount > 0)
    //    {
    //        Label3.Visible = true;
    //        DataGrid1.Visible = true;
    //        lblmessage.Visible = true;
    //        Button1.Visible = true;
    //    }
    //    else
    //    {
    //        lblmsg.Visible = true;
    //    }
    //    dr.Close();
    //    con.Close();
    //}

    //private void DataGrid1_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
    //{
    //    DataGrid1.CurrentPageIndex = e.NewPageIndex;
    //    bindgrid();
    //}

    private void LinkButton1_Click(object sender, System.EventArgs e)
    {
        FormsAuthentication.SignOut();
        Response.Redirect("LogInForm.aspx");
    }

    private void CheckForcastSubmission()
    {
       //SqlConnection con = new SqlConnection();
        SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        SqlDataReader dr;
        Response.Write(DateTime.Now.Day);
        if ((DateTime.Now.Day == 10))
        {
            object month = DateTime.Now.Month + 2;
            string str;
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
            else if (month == "8")
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
            cmd.CommandText = "Select sales_Office_ID From Sales_Office_Master";
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                return;
            }
            try
            {
                dr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                con.Close();
                return;
            }
            if (dr.HasRows)
            {
                ArrayList offices = new ArrayList();
                while ((dr.Read()))
                {
                    offices.Add(dr[0]);
                }
                dr.Close();
                con.Close();
                int i;
                //for (i = 0; i <= offices.Count - 1; i++)
                ////{
                ////    if (FindOffice(offices[i]))
                ////    {
                ////        Raisealert(offices[i], str);
                ////    }
                ////}
            }
        }
    }

    private bool FindOffice(int officeid)
    {
        string sql = "Select * From Forecast_Master Where Forecast_Month=" + DateTime .Now.Month  + 2 + " and Forecast_Year=" + DateTime .Now.Year + " and Sales_Office_ID=" + officeid + "";
        SqlCommand cmd = new SqlCommand(sql, con);
        SqlDataReader dr;
        try
        {
            con.Open();
        }
        catch (Exception ex)
        {
            return false;
        }
        try
        {
            dr = cmd.ExecuteReader();
        }
        catch (Exception ex)
        {
            con.Close();
            return false;
        }
        if (dr.HasRows)
        {
            dr.Close();
            con.Close();
            return false;
        }
        else
        {
            dr.Close();
            con.Close();
            return true;
        }
    }

    private void Raisealert(int office, string str)
    {
        string massage = "Upto now Sales Branch " + office + " have not submitted the Forcast Report for the Month " + str;
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "Insert Into Marketing_Alerts values('" + massage + "')";
        try
        {
            con.Open();
        }
        catch (Exception ex)
        {
            return;
        }
        try
        {
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            con.Close();
            return;
        }
        con.Close();
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        SqlDataAdapter da = new SqlDataAdapter("delete from Alerts where message_status='new'", con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        string msg="NEW MESSAGES HAVE BEEN DELETED";
        this.RegisterStartupScript("clientscript", "<html><body><script>alert('" + msg + "')</script></body></html>");   
    }
}
