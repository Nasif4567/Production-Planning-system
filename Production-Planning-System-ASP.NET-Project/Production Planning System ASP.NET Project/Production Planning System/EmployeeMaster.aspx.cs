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

public partial class EmployeeMaster : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
    private void Page_Init(object sender, System.EventArgs e)
    {
        //InitializeComponent();
    }
    DataSet ds = new DataSet();

    public void DataGrid1_Delete(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
    {
        //SqlConnection con = new SqlConnection();
        //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        int value = Convert.ToInt32(e.Item.Cells[0].Text);
        string sql = "DELETE FROM Employee_Master WHERE Emp_No = " + value + "";
        SqlCommand cmd = new SqlCommand(sql, con);
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
        cmd = null;
        bindgrid();
    }

    private void btncremp_Click(object sender, System.EventArgs e)
    {
        //SqlConnection con = new SqlConnection();
        //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        //string sql = "INSERT INTO Employee_Master(Emp_Name,emp_DoB,emp_doj,Dept_ID,Desig_ID) VALUES(@Employee_Name,@Date_of_Birth,@Date_of_Joining,@Dept_ID,@Designation_ID)";
        //SqlCommand cmd = new SqlCommand(sql, con);
        //SqlParameter pm;
        //pm = cmd.Parameters.Add(new SqlParameter("@Employee_Name", SqlDbType.NVarChar));
        //pm.Value = txtEmpName.Text;
        //pm = cmd.Parameters.Add(new SqlParameter("@Date_of_Birth", SqlDbType.DateTime));
        //pm.Value = "#" + txtDateofBirth.Text + "#";
        //pm = cmd.Parameters.Add(new SqlParameter("@Date_of_Joining", SqlDbType.DateTime));
        //pm.Value = "#" + txtDateofJoining.Text + "#";
        //pm = cmd.Parameters.Add(new SqlParameter("@Dept_ID", SqlDbType.Int));
        //pm.Value = Convert.ToInt16(ddldept.SelectedItem.Text);
        //pm = cmd.Parameters.Add(new SqlParameter("@Designation_ID", SqlDbType.Int));
        //pm.Value = Convert.ToInt16(ddlDesig.SelectedItem.Text);
        //con.Open();
        //cmd.ExecuteNonQuery();
        //con.Close();
        //bindgrid();
        //cmd = null;
        //txtEmpName.Text = "";
        //txtDateofBirth.Text = "";
        //txtDateofJoining.Text = "";
    }

    private void DataGrid1_UpdateCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
    {
        //SqlConnection con = new SqlConnection();
        //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        string sql = "UPDATE Employee_Master SET Emp_Name=@emp_name,emp_DoB=@dob,emp_DoJ=@doj,Desig_ID=@desigid,Dept_ID=@deptid WHERE Emp_No=@emp_id";
        SqlCommand cmd = new SqlCommand(sql, con);
        SqlParameter pm;
        pm = cmd.Parameters.Add(new SqlParameter("@emp_id", SqlDbType.Int));
        pm.Value = e.Item.Cells[0].Text;
        pm = cmd.Parameters.Add(new SqlParameter("@emp_name", SqlDbType.NVarChar));
        pm.Value = ((TextBox)(e.Item.Cells[3].Controls[0])).Text;
        pm = cmd.Parameters.Add(new SqlParameter("@dob", SqlDbType.DateTime));
        pm.Value = "#" + ((TextBox)(e.Item.Cells[4].Controls[0])).Text + "#";
        pm = cmd.Parameters.Add(new SqlParameter("@doj", SqlDbType.DateTime));
        pm.Value = "#" + ((TextBox)(e.Item.Cells[5].Controls[0])).Text + "#";
        pm = cmd.Parameters.Add(new SqlParameter("@desigid", SqlDbType.Int));
        string d;
        d = ((TextBox)(e.Item.Cells[6].Controls[0])).Text;
        pm.Value = Convert.ToInt16(d);
        pm = cmd.Parameters.Add(new SqlParameter("@deptid", SqlDbType.Int));
        string c;
        c = ((TextBox)(e.Item.Cells[7].Controls[0])).Text;
        pm.Value = Convert.ToInt16(c);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        cmd = null;
        DataGrid1.EditItemIndex = -1;
        bindgrid();
        rfvname.Enabled = true;
        revbirth.Enabled = true;
        revjoining.Enabled = true;
        rfvjoining.Enabled = true;
        rfvbirth.Enabled = true;
    }

    private void DataGrid1_EditCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
    {
        DataGrid1.EditItemIndex = e.Item.ItemIndex;
        bindgrid();
        rfvname.Enabled = false;
        revbirth.Enabled = false;
        revjoining.Enabled = false;
        rfvjoining.Enabled = false;
        rfvbirth.Enabled = false;
    }

    private void bindgrid()
    {
        //SqlConnection con = new SqlConnection();
        //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
        SqlCommand cmd = new SqlCommand("SELECT * FROM Employee_Master", con);
        con.Open();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);
        DataGrid1.DataSource = ds.Tables[0];
        DataGrid1.DataBind();
        con.Close();
        cmd = null;
    }
    private void Page_Load(object sender, System.EventArgs e)
    {
        if (!(Page.IsPostBack))
        {
            //SqlConnection con = new SqlConnection();
            //SqlConnection con = new SqlConnection("Data Source = BVC\\SQLEXPRESS; Initial Catalog = planning; Integrated Security = true");
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand("SELECT Desig_ID FROM Designation_Master", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while ((dr.Read()))
            {
                ddlDesig.Items.Add(Convert.ToString(dr[0]));
            }
            con.Close();
            dr.Close();
            cmd.CommandText = "SELECT Dept_ID FROM Dept_Master";
            con.Open();
            dr = cmd.ExecuteReader();
            while ((dr.Read()))
            {
                ddldept.Items.Add(dr[0].ToString());
            }
            con.Close();
            dr.Close();
            bindgrid();
            //SqlCommand cmd1 = new SqlCommand("select sales_office_name from sales_office_master",con);
            //con.Open();
            //dr = cmd1.ExecuteReader();
            //while ((dr.Read()))
            //{
            //    DropDownList1.Items.Add(Convert.ToString(dr[0]));
            //}
            //con.Close();
            //bindgrid();
        }
    }
 private void DataGrid1_CancelCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
 {
   DataGrid1.EditItemIndex = -1;
   bindgrid();
   rfvname.Enabled = true;
   revbirth.Enabled = true;
   revjoining.Enabled = true;
   rfvjoining.Enabled = true;
   rfvbirth.Enabled = true;
 }

 private void DataGrid1_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
 {
   DataGrid1.CurrentPageIndex = e.NewPageIndex;
   bindgrid();
 }

    protected void btncremp_Click1(object sender, EventArgs e)
    {
        //SqlCommand cmd2 = new SqlCommand("select sales_office_id from sales_office_master where sales_office_name='"+DropDownList1.SelectedValue+ "'", con);
        //con.Open();
        //string str1 = cmd2.ExecuteScalar().ToString();
        //con.Close();
        SqlCommand cmd1 = new SqlCommand("select Max(emp_no)+1 from Employee_Master",con);
        con.Open();
        string str = cmd1.ExecuteScalar().ToString();
        if (str == "")
        {
            str = "1";
        }
        else
        {
            str = str;
        }
        SqlCommand cmd = new SqlCommand("insert into Employee_Master values("+str+",'" + txtEmpName.Text + "','" + txtDateofBirth.Text + "','" + txtDateofJoining.Text + "'," + ddlDesig.SelectedValue+ "," + ddldept.SelectedValue + ")", con);
        
        cmd.ExecuteNonQuery();
        //bindgrid();
        con.Close();
    }
    protected void txtDateofJoining_TextChanged(object sender, EventArgs e)
    {

    }
}

