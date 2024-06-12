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

public partial class Power_Tool_Model_Master : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
    SqlCommand cmd1, cmd2, cmd3;
    SqlDataReader dr,dr1,dr2 ;
    private void filldata()
    {
        SqlDataAdapter da=new SqlDataAdapter("select * from Raw_Material_Master order by Raw_Material_id desc", con);
        con.Open();
        DataSet ds = new DataSet();
        da.Fill(ds);

        DropDownList2.DataSource = ds;
        DropDownList2.DataTextField = "raw_material_id";
        DropDownList2.DataValueField= "raw_material_id";
        DropDownList2.DataBind();
        con.Close();

        SqlDataAdapter da1 = new SqlDataAdapter("select * from power_tool_model_master order by model_no desc", con);
        con.Open();
        DataSet ds1 = new DataSet();
        da1.Fill(ds1);

        DropDownList1.DataSource = ds1;
        DropDownList1.DataTextField = "model_no";
        DropDownList1.DataValueField = "model_no";
        DropDownList1.DataBind();
        con.Close();

        cmd3 = new SqlCommand("select * from Power_Tool_Raw_Material_Model_Master", con);
        con.Open();
        GridView1.DataSource = cmd3.ExecuteReader();
        GridView1.DataBind();
        DropDownList1.SelectedIndex = DropDownList1.Items.Count - 1;
        con.Close();
    }
    private void Page_Load(object sender, System.EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            filldata();
        }
    }
    //private void Button1_Click(object sender, System.EventArgs e)
    //{
    //    //SqlConnection con = new SqlConnection();
    //    //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
    //    cmd1 = new SqlCommand("select max(Sales_Office_id) from Sales_Office_Master", con);
    //    con.Open();
    //    dr = cmd1.ExecuteReader();
    //    dr.Read();
    //    string i;
    //    i = DropDownList1.Items.Count.ToString(); 
    //    DropDownList1.Items.Add("Convert.ToInt32dr[0] + 1");
    //    DropDownList1.SelectedIndex = DropDownList1.Items.Count - 1;
    //    Textbox1.Text = "";
    //    dr.Close();
    //    con.Close();
    //    Textbox1.Text = "";
    //}

    private void Button2_Click(object sender, System.EventArgs e)
    {
        //SqlConnection con = new SqlConnection();
        //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        
    }

    private void Button5_Click(object sender, System.EventArgs e)
    {
        ////SqlConnection con = new SqlConnection();
        ////SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        //string update;
        //update = string.Format("update Power_Tool_Raw_Material_Model_Master set Raw_material_qty_required = '" + Textbox1.Text + "'where Model_No=" + DropDownList1.SelectedItem.Text + " and Raw_material_id=" + DropDownList2.SelectedItem.Text + "");
        //cmd1 = new SqlCommand(update, con);
        //con.Open();
        //cmd1.ExecuteNonQuery();
        //con.Close();
        //DropDownList1.Items.Clear();
        //filldata();
        //con.Close();
    }

    private void DropDownList1_SelectedIndexChanged(object sender, System.EventArgs e)
    {
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        DropDownList1.Items.Clear();

        SqlCommand cmd = new SqlCommand("Select count(*) from Power_Tool_Raw_Material_Model_Master", con);
        con.Open();
        int cou = Convert.ToInt32(cmd.ExecuteScalar().ToString());
        con.Close();

        if (cou == 0)
        {
            DropDownList1.Items.Add("1".ToString());
        }
        else
        {
            SqlCommand cmd2 = new SqlCommand("select Max(model_no)+1 from Power_Tool_Raw_Material_Model_Master", con);
            //SqlCommand cmd2 = new SqlCommand("select Max(model_no)+1 from raw_material_master", con);

            con.Open();
            DropDownList1.Items.Add(cmd2.ExecuteScalar().ToString());
            con.Close();
        }

       
        
        //SqlCommand cmd3 = new SqlCommand("select Max(raw_material_id)+1 from raw_material_master", con);
        //con.Open();
        //string str2 = cmd3.ExecuteScalar().ToString();
        //if (str2 == "")
        //{
        //    str2 = "1";
        //}
        //else
        //{
        //    str2 = str2;
        //}
        //con.Close();

    }

    protected void Button2_Click1(object sender, EventArgs e)
    {
        
        SqlCommand cmd=new SqlCommand("insert into Power_Tool_Raw_Material_Model_Master values ( " + DropDownList1.SelectedValue + "," + DropDownList2.SelectedValue + "," + Textbox1.Text + ")",con);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        DropDownList1.Items.Clear();
        filldata();
        con.Close();
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        DropDownList1.Items.Clear();
        filldata();
        Textbox1.Text = "";
    }
    protected void DropDownList1_SelectedIndexChanged1(object sender, EventArgs e)
    {
        SqlDataAdapter da = new SqlDataAdapter("Select * from power_tool_raw_material_model_master where model_no='" + DropDownList1.SelectedValue + "'", con);
        con.Open();
        DataSet ds = new DataSet();
        da.Fill(ds);
        con.Close();
        DropDownList2.Items.Clear();
        SqlDataAdapter da11 = new SqlDataAdapter("select * from Raw_Material_Master order by Raw_Material_id desc", con);
        con.Open();
        DataSet ds11 = new DataSet();
        da11.Fill(ds11);

        DropDownList2.DataSource = ds11;
        DropDownList2.DataTextField = "raw_material_id";
        DropDownList2.DataValueField = "raw_material_id";
        DropDownList2.DataBind();
        con.Close();

        DropDownList2.Items.Insert(0, ds.Tables[0].Rows[0][1].ToString());
        Textbox1.Text = ds.Tables[0].Rows[0][2].ToString();


    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("delete from power_tool_raw_material_model_master where model_no=" + DropDownList1.SelectedValue + "", con);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        DropDownList1.Items.Clear();
        filldata();
        Textbox1.Text = "";
        
    }
    protected void Button5_Click1(object sender, EventArgs e)
    {
        //SqlConnection con = new SqlConnection();
        //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        string update;
        update = string.Format("update Power_Tool_Raw_Material_Model_Master set Raw_material_qty_required = '" + Textbox1.Text + "'where Model_No=" + DropDownList1.SelectedItem.Text + " and Raw_material_id=" + DropDownList2.SelectedItem.Text + "");
        cmd1 = new SqlCommand(update, con);
        con.Open();
        cmd1.ExecuteNonQuery();
        con.Close();
        DropDownList1.Items.Clear();
        filldata();
        con.Close();
    }
}
