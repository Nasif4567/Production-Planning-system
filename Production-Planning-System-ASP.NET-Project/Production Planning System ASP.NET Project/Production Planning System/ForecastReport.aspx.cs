using System;
using System.Data;
using System.Data.SqlClient;  
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class ForecastReport : System.Web.UI.Page
{
    
    SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
    //SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings("con"));
    int month;
    private void Page_Load(object sender, System.EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            ddlYear.Items.Add("Select Year");
            //int i;
            for (int i = 1970; i <= DateTime.Now.Year; i++)
            {

                ddlYear.Items.Add(i.ToString());  
            }
            //CrystalReportViewer1.Visible = false;
        }
    }
    private void Last_Click(object sender, System.Web.UI.ImageClickEventArgs e)
    {
        bindview();
        //CrystalReportViewer1.ShowLastPage();
    }

    private void Prev_Click(object sender, System.Web.UI.ImageClickEventArgs e)
    {
        bindview();
        //CrystalReportViewer1.ShowPreviousPage();
    }

    private void ext_Click(object sender, System.Web.UI.ImageClickEventArgs e)
    {
        bindview();
        //CrystalReportViewer1.ShowNextPage();
    }

    private void First_Click(object sender, System.Web.UI.ImageClickEventArgs e)
    {
        bindview();
        //CrystalReportViewer1.ShowFirstPage();
    }

 private void btnShow_Click(object sender, System.EventArgs e)
 {
   //if (ddlMonth.SelectedIndex > 0 & ddlYear.SelectedIndex > 0) {
   //  string sql = "SELECT Forecast_Master.Sales_Office_ID, Forecast_Details.Model_ID, Forecast_Details.Qty_Predicted, Forecast_Details.Varience FROM Forecast_Details INNER JOIN Forecast_Master ON Forecast_Details.Forecast_ID = Forecast_Master.Forecast_ID Where Forecast_Master.Forecast_Month=" + ddlMonth.SelectedItem.Value + " and Forecast_Master.Forecast_Year=" + ddlYear.SelectedItem.Value + "";
   //  SqlCommand cmd = new SqlCommand(sql, con);
   //  SqlDataAdapter da = new SqlDataAdapter(cmd);
   //  da.Fill(ReportData1.Tables[0]);
   //  ForecastReport cr = new ForecastReport();
   //  cr.SetDataSource(ReportData1);
   //  CrystalReportViewer1.ReportSource = cr;
   //} else {
   //  CrystalReportViewer1.Visible = false;
   //  Msg("Select Month and Year");
   //}
 }

 private void bindview()
 {
   //string sql = "SELECT Forecast_Master.Sales_Office_ID, Forecast_Details.Model_ID, Forecast_Details.Qty_Predicted, Forecast_Details.Varience FROM Forecast_Details INNER JOIN Forecast_Master ON Forecast_Details.Forecast_ID = Forecast_Master.Forecast_ID Where Forecast_Master.Forecast_Month=" + ddlMonth.SelectedItem.Value + " and Forecast_Master.Forecast_Year=" + ddlYear.SelectedItem.Value + "";
   //SqlCommand cmd = new SqlCommand(sql, con);
   //SqlDataAdapter da = new SqlDataAdapter(cmd);
   //da.Fill(ReportData1.Tables[0]);
   //ForecastReport cr = new ForecastReport();
   //cr.SetDataSource(ReportData1);
   ////CrystalReportViewer1.ReportSource = cr;
 }

 private void Msg(string message)
 {
   object str = "<script language=JavaScript >";
   str += "alert(\"" + message + "\");";
   str += "</script>";
   //this.RegisterStartupScript("clientScript", str);
 }


    //protected void Last_Click1(object sender, ImageClickEventArgs e)
    //{

    //}
    protected void btnShow_Click1(object sender, EventArgs e)
    {
        //if (ddlMonth.SelectedIndex > 0 & ddlYear.SelectedIndex > 0)
        //{
        //    switch(ddlMonth.SelectedIndex)
        //    {                 
        //        case 0:                 
        //            month =0;
        //        break ;
        //        case 1:
        //            month=1;
        //            break; 
        //        case 2:
        //            month =2;
        //            break;
        //        case 3:
        //            month =3;
        //            break;
        //        case 4:
        //             month =4;
        //            break;
        //        case 5:
        //             month = 5;
        //            break;
        //        case 6:
        //             month =6;
        //            break;
        //        case 7:
        //             month = 7;
        //            break;
        //        case 8:
        //             month = 8;
        //            break;
        //        case 9:
        //             month = 9;
        //            break;
        //        case 10:
        //             month = 10;
        //            break;
        //        case 11:
        //             month = 11;
        //            break;
        //        case 12:
        //            month = 12;
        //            break;
        //    }

        //    //string sql = "SELECT Forecast_Master.Sales_Office_ID, forecastdata.model_no, forecastdata.PredictedQty, forecastdata.Varience FROM forecastdata INNER JOIN Forecast_Master ON forecastdata.Forecast_ID = Forecast_Master.Forecast_ID Where Forecast_Master.Forecast_Month='"+month+"' and Forecast_Master.Forecast_Year=" + ddlYear.SelectedItem.Value + "";
        //    //SqlCommand cmd = new SqlCommand(sql, con);
            
        //    //SqlDataAdapter da=new SqlDataAdapter("Select * from forecastdata where 

        //    con.Open();            
        //    SqlDataReader dr;
        //    dr = cmd.ExecuteReader();
        //    GridView1.DataSource = dr;
        //    GridView1.DataBind();
        //    con.Close();
        //    //SqlDataAdapter da = new SqlDataAdapter(cmd);
        //     //da.Fill(ReportData1.Tables[0]);
        //    //ForecastReport cr = new ForecastReport();
        //    //cr.SetDataSource(ReportData1);
        //    //CrystalReportViewer1.ReportSource = cr;
        //}
        //else
        //{
        //    //CrystalReportViewer1.Visible = false;
        //    Msg("Select Month and Year");
        //}
    }
    //protected void ext_Click(object sender, ImageClickEventArgs e)
    //{

    //}
    //protected void Last_Click(object sender, ImageClickEventArgs e)
    //{

    //}
    //protected void First_Click(object sender, ImageClickEventArgs e)
    //{

    //}
    //protected void Prev_Click(object sender, ImageClickEventArgs e)
    //{

    //}
protected void  Calendar1_SelectionChanged(object sender, EventArgs e)
{
    SqlDataAdapter da = new SqlDataAdapter("Select * from forecastdata where date_of_submission='" + Calendar1.SelectedDate.ToShortDateString() + "'", con);
    //SqlDataAdapter da = new SqlDataAdapter("SELECT Forecast_Master.Sales_Office_ID, forecastdata.model_no, forecastdata.PredictedQty, forecastdata.Varience FROM forecastdata INNER JOIN Forecast_Master ON forecastdata.Forecast_ID = Forecast_Master.Forecast_ID where forecastdata.date_of_submission='" + Calendar1.SelectedDate.ToShortDateString() + "'", con);
    //SqlDataAdapter da = new SqlDataAdapter("SELECT Forecast_Master.Sales_Office_ID, forecastdata.model_no, forecastdata.PredictedQty, forecastdata.Varience FROM forecastdata INNER JOIN Forecast_Master ON forecastdata.Forecast_ID = Forecast_Master.Forecast_ID where forecastdata.date_of_submission='" + Calendar1.SelectedDate.ToShortDateString() + "'", con);
    //SqlDataAdapter da = new SqlDataAdapter("Select * from forecastdata where date_of_submission='" + Calendar1.SelectedDate.ToShortDateString() + "'", con);
    con.Open();
    DataSet ds = new DataSet();
    da.Fill(ds);
    con.Close();
    GridView1.DataSource = ds;
    GridView1.DataBind();
}
}

