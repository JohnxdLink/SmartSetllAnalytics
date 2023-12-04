using SmartSetll_Analytics_V2.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartSetll_Analytics_V2.pages
{
    public partial class User : System.Web.UI.Page
    {
        GetUserSmartSell userSmartSell = new GetUserSmartSell();

        protected void Page_Load(object sender, EventArgs e)
        {
            // X: Display Home as Default Page
            homeContentID.Visible = true;

        }

        // ? Button Home
        protected void Btn_Home_Click(object sender, EventArgs e)
        {

            // N: Setting the Navigation Text in Header
            Lbl_Navigation.Text = "HOME | SMARTSELL";

            // N: Set visibility and update the session variable
            homeContentID.Visible = true;
            capitalContentID.Visible = false; monthlyContentID.Visible = false; feedbackContentID.Visible = false; manualContentID.Visible = false; profileContentID.Visible = false;

            Session["ContentVisibility"] = true;
        }


        // ? Button Capital
        protected void Btn_Capital_Click(object sender, EventArgs e)
        {
            // N: Setting the Navigation Text in Header
            Lbl_Navigation.Text = "CAPITAL";

            // N: Set visibility and update the session variable
            capitalContentID.Visible = true;
            homeContentID.Visible = false; monthlyContentID.Visible = false; feedbackContentID.Visible = false; manualContentID.Visible = false; profileContentID.Visible = false;

            Session["ContentVisibility"] = false;
        }

        protected void Btn_Capital_Add_Item_Click(Object sender, EventArgs e)
        {
            // N: Setting the Navigation Text in Header
            Lbl_Navigation.Text = "CAPITAL";

            // N: Set visibility and update the session variable
            capitalContentID.Visible = true;
            homeContentID.Visible = false; monthlyContentID.Visible = false; feedbackContentID.Visible = false; manualContentID.Visible = false; profileContentID.Visible = false;

            Session["ContentVisibility"] = false;
        }


        // ? Button Monthly
        protected void Btn_Monthly_Click(object sender, EventArgs e)
        {
            // N: Setting the Navigation Text in Header
            Lbl_Navigation.Text = "MONTHLY";

            // N: Set visibility and update the session variable
            monthlyContentID.Visible = true;
            homeContentID.Visible = false; capitalContentID.Visible = false; feedbackContentID.Visible = false; manualContentID.Visible = false; profileContentID.Visible = false;

            Session["ContentVisibility"] = false;
        }

        // ? Button Feedback
        protected void Btn_Feedback_Click(object sender, EventArgs e)
        {
            // N: Setting the Navigation Text in Header
            Lbl_Navigation.Text = "FEEDBACK";

            // N: Set visibility and update the session variable
            feedbackContentID.Visible = true;
            homeContentID.Visible = false; capitalContentID.Visible = false; monthlyContentID.Visible = false; manualContentID.Visible = false; profileContentID.Visible = false;

            Session["ContentVisibility"] = false;
        }

        // ? Button Moanual
        protected void Btn_Manual_Click(object sender, EventArgs e)
        {
            // N: Setting the Navigation Text in Header
            Lbl_Navigation.Text = "MANUAL";

            // N: Set visibility and update the session variable
            manualContentID.Visible = true;
            homeContentID.Visible = false; capitalContentID.Visible = false; monthlyContentID.Visible = false; feedbackContentID.Visible = false; profileContentID.Visible = false;

            Session["ContentVisibility"] = false;
        }

        // ? Button Profile
        protected void Btn_Profile_Click(object sender, EventArgs e)
        {
            // N: Setting the Navigation Text in Header
            Lbl_Navigation.Text = "PROFILE";

            // N: Set visibility and update the session variable
            profileContentID.Visible = true;
            homeContentID.Visible = false; capitalContentID.Visible = false; monthlyContentID.Visible = false; feedbackContentID.Visible = false; manualContentID.Visible = false;

            Session["ContentVisibility"] = false;
        }

        // ? Button Logout
        protected void Btn_Logout_Click(object sender, EventArgs e)
        {
            // N: Clear session variables
            Session.Clear();

            // N: Redirect to the login page (adjust the URL accordingly)
            Response.Redirect("~/Index.aspx");
        }

        // ? Button go to SmartSell Page
        protected void Btn_Go_SmartSell_Click(object sender, EventArgs e)
        {
            // N: Clear session variables
            Session.Clear();

            // N: Redirect to the login page (adjust the URL accordingly)
            Response.Redirect("~/pages/SmartSell.aspx");
        }
    }
}