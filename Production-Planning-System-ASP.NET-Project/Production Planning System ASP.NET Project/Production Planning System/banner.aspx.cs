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


public partial class banner : System.Web.UI.Page
{
    private void InitializeComponent()
 {
 }
 protected System.Web.UI.WebControls.Image Image2;
 protected System.Web.UI.WebControls.HyperLink HyperLink1;
 private object designerPlaceholderDeclaration;

 private void Page_Init(object sender, System.EventArgs e)
 {
   InitializeComponent();
 }

 private void Page_Load(object sender, System.EventArgs e)
 {
 }

 private void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
 {
   FormsAuthentication.SignOut();
   Response.Redirect("LogInForm.aspx");
 }
}

