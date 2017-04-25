using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1_Zakh
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                Label1.Text = "Please select a date";
                Calendar1.SelectedDate = DateTime.Now;
                Button1.Text = "Clear Selection";
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            Label1.Text = "Selected date: " + Calendar1.SelectedDate.ToShortDateString();
        }

        protected void Button1_OnClick(object sender, EventArgs e)
        {
            Calendar1.SelectedDate = DateTime.Now;
            Label1.Text = "Please select a date";
        }
    }
}