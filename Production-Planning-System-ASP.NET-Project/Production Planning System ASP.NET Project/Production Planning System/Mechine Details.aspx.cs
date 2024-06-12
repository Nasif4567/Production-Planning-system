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

public partial class Mechine_Details : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");

    private void Page_Init(object sender, System.EventArgs e)
    {
        //InitializeComponent();
    }
    SqlCommand cmd1;
    SqlCommand cmd2;
    SqlCommand cmd3;
    SqlCommand cmdupdate;
    SqlDataReader dr;
    //SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings("con"));

    private void filldata()
    {
        con.Open();
        SqlCommand cmd2 = new SqlCommand("select * from Machine_Master order by Machine_id desc", con);
        dr = cmd2.ExecuteReader();
        while (dr.Read())
        {
            DropDownList1.Items.Add(dr[0].ToString());
        }
        dr.Close();
        con.Close();
        SqlCommand cmd3 = new SqlCommand("select * from Machine_Master order by Machine_id desc", con);
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
        SqlCommand cmd4 = new SqlCommand("select * from Machine_Master order by Machine_id desc", con);
        con.Open();
        DataGrid1.DataSource = cmd4.ExecuteReader();
        DataGrid1.DataBind();
    }
    private void Page_Load(object sender, System.EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            filldata();
        }
    }
    private void DropDownList1_SelectedIndexChanged(object sender, System.EventArgs e)
    {
        
    }

    private void Button1_Click(object sender, System.EventArgs e)
    {
        //cmd1 = new SqlCommand("select max(Machine_Id)+1 from Machine_Master", con);
        //con.Open();
        //dr = cmd1.ExecuteReader();
        //dr.Read();
        //string i;
        //i = DropDownList1.Items.Count.ToString() ;
        //DropDownList1.Items.Add(dr[0].ToString());
        //DropDownList1.SelectedIndex = DropDownList1.Items.Count - 1;
        //dr.Close();
        //con.Close();
        //Textbox1.Text = "";
        //TextBox2.Text = "";
        //TextBox3.Text = "";
        //Textbox4.Text = "";
    }

    private void Button2_Click(object sender, System.EventArgs e)
    {
        //string insert;
        //insert = string.Format("insert into Machine_Master values ( " + DropDownList1.SelectedItem.Text + "," + Textbox1.Text + ",'" + TextBox2.Text + "','" + TextBox3.Text + "'," + Textbox4.Text + ")");
        //cmd1 = new SqlCommand(insert, con);
        //con.Open();
        //cmd1.ExecuteNonQuery();
        //con.Close();
        //DropDownList1.Items.Clear();
        //filldata();
        //con.Close();
    }

    private void Button5_Click(object sender, System.EventArgs e)
    {
        //string update;
        //update = string.Format("update Machine_Master set Machine_no = " + Textbox1.Text + ",Machine_purch_date= '" + TextBox2.Text + "',Machine_inst_date='" + TextBox3.Text + "',waranty_period=" + Textbox4.Text + "where Machine_id=" + DropDownList1.SelectedItem.Text + "");
        //cmd1 = new SqlCommand(update, con);
        //con.Open();
        //cmd1.ExecuteNonQuery();
        //con.Close();
        //DropDownList1.Items.Clear();
        //filldata();
        //con.Close();
    }

    private void DataGrid1_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
    {
        DataGrid1.CurrentPageIndex = e.NewPageIndex;
        filldata();
    }

    private void Button4_Click(object sender, System.EventArgs e)
    {
        Response.Redirect("webform15.aspx");
    }


    protected void DropDownList1_SelectedIndexChanged2(object sender, EventArgs e)
    {
        string search = DropDownList1.SelectedItem.Text;
        cmd1 = new SqlCommand(string.Format("select * from Machine_Master where Machine_id='{0}'", search), con);
        con.Open();
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
    protected void Button1_Click1(object sender, EventArgs e)
    {

        SqlCommand cmd = new SqlCommand("Select count(*) from Machine_Master", con);
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
            cmd1 = new SqlCommand("select max(Machine_Id)+1 from Machine_Master", con);
            con.Open();
            DropDownList1.Items.Add(cmd1.ExecuteScalar().ToString());
            con.Close();
        }
        Textbox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        Textbox4.Text = "";
    }
    protected void Button2_Click1(object sender, EventArgs e)
    {
        string insert;
        insert = string.Format("insert into Machine_Master values ( " + DropDownList1.SelectedItem.Text + "," + Textbox1.Text + ",'" + TextBox2.Text + "','" + TextBox3.Text + "'," + Textbox4.Text + ")");
        cmd1 = new SqlCommand(insert, con);
        con.Open();
        cmd1.ExecuteNonQuery();
        con.Close();
        DropDownList1.Items.Clear();
        filldata();
        con.Close();
    }
    protected void Button5_Click1(object sender, EventArgs e)
    {
        string update;
        update = string.Format("update Machine_Master set Machine_no = " + Textbox1.Text + ",Machine_purch_date= '" + TextBox2.Text + "',Machine_inst_date='" + TextBox3.Text + "',waranty_period=" + Textbox4.Text + "where Machine_id=" + DropDownList1.SelectedItem.Text + "");
        cmd1 = new SqlCommand(update, con);
        con.Open();
        cmd1.ExecuteNonQuery();
        con.Close();
        DropDownList1.Items.Clear();
        filldata();
        con.Close();
    }
}
