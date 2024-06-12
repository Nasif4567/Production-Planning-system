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
public partial class Process_Master : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
    SqlDataReader dr;
    private void filldata()
    {
        //SqlConnection con = new SqlConnection();
        //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        con.Open();
        SqlCommand cmd1 = new SqlCommand("select * from Process_Master order by Process_no desc", con);
        SqlDataReader  dr = cmd1.ExecuteReader();
        while (dr.Read())
        {
            DropDownList1.Items.Add(Convert.ToString(dr[0]));
        }
        dr.Close();
        con.Close();
        SqlCommand cmd2 = new SqlCommand("select * from Process_Master order by Process_No", con);
        con.Open();
        SqlDataReader dr1 = cmd2.ExecuteReader();
        while (dr1.Read())
        {
            Textbox1.Text = dr1[1].ToString();
            TextBox2.Text = dr1[2].ToString();
            Textbox3.Text = dr1[3].ToString();
            Textbox4.Text = dr1[4].ToString();
            Textbox5.Text = dr1[5].ToString();
        }
        string i;
        i = DropDownList1.Items.Count.ToString();
        dr1.Close();
        con.Close();
        SqlCommand cmd3 = new SqlCommand("select * from Process_Master order by Process_no desc", con);
        con.Open();
        DataGrid1.DataSource = cmd3.ExecuteReader();
        DataGrid1.DataBind();
    }
    private void Page_Load(object sender, System.EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            filldata();
        }
    }
    private void LinkButton1_Click(object sender, System.EventArgs e)
    {
        Response.Redirect("webform14.aspx");
    }

    private void Button1_Click(object sender, System.EventArgs e)
    {
        ////SqlConnection con = new SqlConnection();
        //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        //SqlCommand cmd1 = new SqlCommand("select max(Process_No) from Process_Master", con);
        //con.Open();
        ////SqlDataReader dr = new SqlDataReader();
        //dr = cmd1.ExecuteReader();
        //dr.Read();
        //string i;
        //i = DropDownList1.Items.Count.ToString(); 
        //string s = dr[0].ToString();
        //DropDownList1.Items.Add("Convert.ToInt32(dr[0])+ 1");
        //DropDownList1.SelectedIndex = DropDownList1.Items.Count - 1;
        //dr.Close();
        //con.Close();
        //Textbox1.Text = "";
        //TextBox2.Text = "";
        //Textbox3.Text = "";
        //Textbox4.Text = "";
        //Textbox5.Text = "";
    }

    private void Button2_Click(object sender, System.EventArgs e)
    {
    //    //SqlConnection con = new SqlConnection();
    //    SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
    //    string insert;
    //    insert = string.Format("insert into Process_Master values ( " + DropDownList1.SelectedItem.Text + ",'" + Textbox1.Text + "','" + TextBox2.Text + "'," + Textbox3.Text + "," + Textbox4.Text + " ," + Textbox5.Text + ")");
    //    SqlCommand cmd1 = new SqlCommand(insert, con);
    //    con.Open();
    //    cmd1.ExecuteNonQuery();
    //    con.Close();
    //    DropDownList1.Items.Clear();
    //    filldata();
    //    con.Close();
    }

    private void Button5_Click(object sender, System.EventArgs e)
    {
        ////SqlConnection con = new SqlConnection();
        //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        //string update;
        //update = string.Format("update Process_Master set Process_name = '" + Textbox1.Text + "',Process_desc= '" + TextBox2.Text + "',Process_batch_qty=" + Textbox3.Text + ",Process_batch_cost=" + Textbox4.Text + ",Process_batch_time=" + Textbox5.Text + " where Process_No=" + DropDownList1.SelectedItem.Text + "");
        //SqlCommand cmd1 = new SqlCommand(update, con);
        //con.Open();
        //cmd1.ExecuteNonQuery();
        //con.Close();
        //DropDownList1.Items.Clear(); 
        //filldata();
        //con.Close();
    }

    private void DropDownList1_SelectedIndexChanged(object sender, System.EventArgs e)
    {
        //string search = DropDownList1.SelectedItem.Text;
        ////SqlConnection con = new SqlConnection();
        //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        //SqlCommand cmd1 = new SqlCommand(string.Format("select * from Process_Master where Process_No='{0}'", search), con);
        //con.Open();
        //dr = cmd1.ExecuteReader();
        //dr.Read();
        //Textbox1.Text = "";
        //TextBox2.Text = "";
        //Textbox3.Text = "";
        //Textbox4.Text = "";
        //Textbox5.Text = "";
        //Textbox1.Text = dr[1].ToString();
        //TextBox2.Text = dr[2].ToString();
        //Textbox3.Text = dr[3].ToString();
        //Textbox4.Text = dr[4].ToString();
        //Textbox5.Text = dr[5].ToString();
        //dr.Close();
        //con.Close();
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        
        SqlCommand cmd = new SqlCommand("Select Count(*) from Process_Master", con);
        con.Open();
        int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());
        con.Close();
        DropDownList1.Items.Clear();
        if (count == 0)
        {
            DropDownList1.Items.Add("1".ToString());
        }
        else
        {
            SqlCommand cmd1 = new SqlCommand("Select Max(Process_No)+1 from Process_Master", con);
            con.Open();
            DropDownList1.Items.Add(cmd1.ExecuteScalar().ToString());
            con.Close();

 
        }

        Textbox1.Text = "";
        TextBox2.Text = "";
        Textbox3.Text = "";
        Textbox4.Text = "";
        Textbox5.Text = "";
    }
    protected void Button2_Click1(object sender, EventArgs e)
    {

        //SqlConnection con = new SqlConnection();
        SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        string insert;
        insert = string.Format("insert into Process_Master values ( " + DropDownList1.SelectedItem.Text + ",'" + Textbox1.Text + "','" + TextBox2.Text + "'," + Textbox3.Text + "," + Textbox4.Text + " ," + Textbox5.Text + ")");
        SqlCommand cmd1 = new SqlCommand(insert, con);
        con.Open();
        cmd1.ExecuteNonQuery();
        con.Close();
        DropDownList1.Items.Clear();
        filldata();
        con.Close();
    }
    protected void DropDownList1_SelectedIndexChanged1(object sender, EventArgs e)
    {
        string search = DropDownList1.SelectedItem.Text;
        //SqlConnection con = new SqlConnection();
        SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        SqlCommand cmd1 = new SqlCommand(string.Format("select * from Process_Master where Process_No='{0}'", search), con);
        con.Open();
        dr = cmd1.ExecuteReader();
        dr.Read();
        Textbox1.Text = "";
        TextBox2.Text = "";
        Textbox3.Text = "";
        Textbox4.Text = "";
        Textbox5.Text = "";
        Textbox1.Text = dr[1].ToString();
        TextBox2.Text = dr[2].ToString();
        Textbox3.Text = dr[3].ToString();
        Textbox4.Text = dr[4].ToString();
        Textbox5.Text = dr[5].ToString();
        dr.Close();
        con.Close();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("delete from process_master where process_no=" + DropDownList1.SelectedValue + "", con);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        DropDownList1.Items.Clear();
        filldata();
        Textbox1.Text = "";
        TextBox2.Text = "";
        Textbox3.Text = "";
        Textbox4.Text = "";
        Textbox5.Text = "";
    }
    protected void Button5_Click1(object sender, EventArgs e)
    {
        //SqlConnection con = new SqlConnection();
        SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        string update;
        update = string.Format("update Process_Master set Process_name = '" + Textbox1.Text + "',Process_desc= '" + TextBox2.Text + "',Process_batch_qty=" + Textbox3.Text + ",Process_batch_cost=" + Textbox4.Text + ",Process_batch_time=" + Textbox5.Text + " where Process_No=" + DropDownList1.SelectedItem.Text + "");
        SqlCommand cmd1 = new SqlCommand(update, con);
        con.Open();
        cmd1.ExecuteNonQuery();
        con.Close();
        DropDownList1.Items.Clear();
        filldata();
        con.Close();
    }
}
