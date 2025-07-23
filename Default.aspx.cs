using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NetFramework30ASPNETWEB
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Set the current date and time on each page load
            DateTimeLabel.Text = "Current server time: " + DateTime.Now.ToString("f");
        }
    }
}
