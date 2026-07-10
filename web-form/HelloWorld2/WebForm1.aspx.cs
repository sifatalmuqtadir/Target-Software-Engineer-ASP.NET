using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWorld2
{
	public partial class WebForm1 : System.Web.UI.Page
	{
        //private string name;
        protected void Page_Load(object sender, EventArgs e)
		{
            

        }

        protected void displayButton_Click1(object sender, EventArgs e)
        {
            //Response.Write("Hello");
            //string name = nameTextBox.Text;
            //messageLabel.Text = "Hello " +name;

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            string name;
            name = nameTextBox.Text;
            ViewState["name"] = name;
            nameTextBox.Text = "";
        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            outputTextBox.Text = ViewState["name"].ToString();
        }
    }
}