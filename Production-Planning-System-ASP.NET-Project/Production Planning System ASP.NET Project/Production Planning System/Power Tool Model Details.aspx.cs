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

public partial class Power_Tool_Model_Details : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
    private void Page_Load(object sender, System.EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            filldata();
            SqlCommand cmd = new SqlCommand("select * from power_Tool_MOdel_Master");
        }
    }
    private void filldata()
    {
        //SqlConnection con = new SqlConnection();
        //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        con.Open();
        SqlCommand cmd2 = new SqlCommand("select * from power_Tool_MOdel_Master order by MOdel_No desc", con);
        SqlDataReader dr; 
        dr = cmd2.ExecuteReader();
        while (dr.Read())
        {
            DropDownList1.Items.Add(dr[0].ToString());
        }
        dr.Close();
        con.Close();
        SqlCommand cmd3 = new SqlCommand("select * from power_Tool_MOdel_Master order by MOdel_No desc", con);
        con.Open();
        dr = cmd3.ExecuteReader();
        while (dr.Read())
        {
            Textbox1.Text = dr[1].ToString();
            TextBox2.Text = dr[2].ToString();
            TextBox3.Text = dr[3].ToString();
            Textbox4.Text = dr[4].ToString();
        }
        dr.Close();
        con.Close();
        cmd3 = new SqlCommand("select * from power_Tool_MOdel_Master order by MOdel_No desc", con);
        con.Open();
        DataGrid1.DataSource = cmd3.ExecuteReader();
        DataGrid1.DataBind();
        Textbox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        Textbox4.Text = "";                 
    }

    private void LinkButton1_Click(object sender, System.EventArgs e)
    {
        Server.Transfer("webform14.aspx");
    }

    private void DropDownList1_SelectedIndexChanged(object sender, System.EventArgs e)
    {
       //// SqlConnection con = new SqlConnection();
       //// SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
       // string search = DropDownList1.SelectedItem.Text;
       // SqlCommand cmd1 = new SqlCommand(string.Format("select * from Power_Tool_MOdel_Master where Model_No='{0}'", search), con);
       // con.Open();
       // SqlDataReader dr; 
       // dr = cmd1.ExecuteReader();
       // dr.Read();
       // Textbox1.Text = "";
       // TextBox2.Text = "";
       // TextBox3.Text = "";
       // Textbox4.Text = "";
       // Textbox1.Text = dr[1].ToString();
       // TextBox2.Text = dr[2].ToString();
       // TextBox3.Text = dr[3].ToString();
       // Textbox4.Text = dr[4].ToString();
       // dr.Close();
       // con.Close();
    }

    private void Button1_Click(object sender, System.EventArgs e)
    {
        //    //SqlConnection con = new SqlConnection();
        ////SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        //SqlCommand cmd1 = new SqlCommand("select max(Model_No) from Power_Tool_Model_Master", con);
        //con.Open();
        //SqlDataReader dr; 
        //dr = cmd1.ExecuteReader();
        //dr.Read();
        //DropDownList1.Items.Add("Convert.ToInt32(dr[0]) + 1");
        //DropDownList1.SelectedIndex = DropDownList1.Items.Count - 1;
        //dr.Close();
        //con.Close();
        //Textbox1.Text = "";
        //TextBox2.Text = "";
        //TextBox3.Text = "";
        //Textbox4.Text = "";
    
    }
protected void  Button2_Click(object sender, EventArgs e)
{
    //SqlConnection con = new SqlConnection();
        //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        string insert;
        insert = string.Format("insert into Power_Tool_Model_Master values ( " + DropDownList1.SelectedItem.Text + ",'" + Textbox1.Text + "'," + TextBox2.Text + "," + TextBox3.Text + ",'" + Textbox4.Text + "')");
        SqlCommand cmd1 = new SqlCommand(insert, con);
        
        con.Open();
        cmd1.ExecuteNonQuery();
        con.Close();
        DropDownList1.Items.Clear();
        filldata();
        con.Close();
} 

    private void Button5_Click(object sender, System.EventArgs e)
    {
        ////SqlConnection con = new SqlConnection();
        ////SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        //string update;
        //update = string.Format("update power_Tool_Model_Master set Model_name ='" + Textbox1.Text + "',Industria_rep_area_code= " + TextBox2.Text + ",Min_Selling_Price=" + TextBox3.Text + ",Model_Other_Details='" + Textbox4.Text + "' where Model_No=" + DropDownList1.SelectedItem.Text + "");
        //SqlCommand cmd1 = new SqlCommand(update, con);
        //con.Open();
        //cmd1.ExecuteNonQuery();
        //con.Close();
        //DropDownList1.Items.Clear();
        //filldata();
        //con.Close();
    }

    private void Button4_Click(object sender, System.EventArgs e)
    {
        Response.Redirect("webform15.aspx");
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        //SqlConnection con = new SqlConnection();
        //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        SqlCommand cmd1 = new SqlCommand("select max(Model_No)+1 from Power_Tool_Model_Master", con);
        con.Open();
        SqlDataReader dr;
        dr = cmd1.ExecuteReader();
        dr.Read();
        string i;
        i = DropDownList1.Items.Count.ToString();
        string s = dr[0].ToString();
        DropDownList1.Items.Add(s);
        DropDownList1.SelectedIndex = DropDownList1.Items.Count - 1;
        dr.Close();
        con.Close();
        Textbox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        Textbox4.Text = "";
    }
    protected void DropDownList1_SelectedIndexChanged1(object sender, EventArgs e)
    {
        // SqlConnection con = new SqlConnection();
        // SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        string search = DropDownList1.SelectedItem.Text;
        SqlCommand cmd1 = new SqlCommand(string.Format("select * from Power_Tool_MOdel_Master where Model_No='{0}'", search), con);
        con.Open();
        SqlDataReader dr;
        dr = cmd1.ExecuteReader();
        dr.Read();
        Textbox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        Textbox4.Text = "";
        Textbox1.Text = dr[1].ToString();
        TextBox2.Text = dr[2].ToString();
        TextBox3.Text = dr[3].ToString();
        Textbox4.Text = dr[4].ToString();
        dr.Close();
        con.Close();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("delete from power_tool_model_master where model_no=" + DropDownList1.SelectedValue + "", con);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        DropDownList1.Items.Clear();
        filldata();
        Textbox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        Textbox4.Text = "";
         
    }
    protected void Button5_Click1(object sender, EventArgs e)
    {
        //SqlConnection con = new SqlConnection();
        //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        string update;
        update = string.Format("update power_Tool_Model_Master set Model_name ='" + Textbox1.Text + "',Industria_rep_area_code= " + TextBox2.Text + ",Min_Selling_Price=" + TextBox3.Text + ",Model_Other_Details='" + Textbox4.Text + "' where Model_No=" + DropDownList1.SelectedItem.Text + "");
        SqlCommand cmd1 = new SqlCommand(update, con);
        con.Open();
        cmd1.ExecuteNonQuery();
        con.Close();
        DropDownList1.Items.Clear();
        filldata();
        con.Close();
    }
}
