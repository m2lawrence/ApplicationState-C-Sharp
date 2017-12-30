using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ApplicationState
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Application["Clicks"] == null)
                {
                    Application["Clicks"] = 0;
                }
                TextBox1.Text = Application["Clicks"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //here the int variable ClicksCount, stores the Application clicks and increments up 1.
            int ClicksCount = (int)Application["Clicks"] + 1;
            //here convert int to string and passes the Application memory to the TextBox1.
            TextBox1.Text = ClicksCount.ToString();
            //here the Application memory gets stored back into the int variable ClicksCount.
            Application["Clicks"] = ClicksCount;
        }
    }
}