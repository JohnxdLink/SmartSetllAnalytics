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
        protected void Page_Load(object sender, EventArgs e)
        {
            homeContentID.Visible = true;

            if (!IsPostBack)
            {
                // N: Check if the session variable exists
                if (Session["ContentVisibility"] != null)
                {
                    // N: Retrieve the visibility status from the session
                    bool isContentVisible = (bool)Session["ContentVisibility"];

                    // N: Set the visibility of the content based on the session variable
                    homeContentID.Visible = isContentVisible;
                    capitalContentID.Visible = !isContentVisible; monthlyContentID.Visible = !isContentVisible; feedbackContentID.Visible = !isContentVisible; manualContentID.Visible = !isContentVisible; profileContentID.Visible = !isContentVisible;
                }
            }
        }

        protected void Btn_Home_Click(object sender, EventArgs e)
        {
            // N: Set visibility and update the session variable
            homeContentID.Visible = true;
            capitalContentID.Visible = false; monthlyContentID.Visible = false; feedbackContentID.Visible = false; manualContentID.Visible = false; profileContentID.Visible = false;

            Session["ContentVisibility"] = true;
        }

        protected void Btn_Capital_Click(object sender, EventArgs e)
        {
            // N: Set visibility and update the session variable
            capitalContentID.Visible = true;
            homeContentID.Visible = false; monthlyContentID.Visible = false; feedbackContentID.Visible = false; manualContentID.Visible = false; profileContentID.Visible = false;

            Session["ContentVisibility"] = false;
        }

        protected void Btn_Monthly_Click(object sender, EventArgs e)
        {
            // N: Set visibility and update the session variable
            monthlyContentID.Visible = true;
            homeContentID.Visible = false; capitalContentID.Visible = false; feedbackContentID.Visible = false; manualContentID.Visible = false; profileContentID.Visible = false;

            Session["ContentVisibility"] = false;
        }

        protected void Btn_Feedback_Click(object sender, EventArgs e)
        {
            // N: Set visibility and update the session variable
            feedbackContentID.Visible = true;
            homeContentID.Visible = false; capitalContentID.Visible = false; monthlyContentID.Visible = false; manualContentID.Visible = false; profileContentID.Visible = false;

            Session["ContentVisibility"] = false;
        }

        protected void Btn_Manual_Click(object sender, EventArgs e)
        {
            // N: Set visibility and update the session variable
            manualContentID.Visible = true;
            homeContentID.Visible = false; capitalContentID.Visible = false; monthlyContentID.Visible = false; feedbackContentID.Visible = false; profileContentID.Visible = false;
            
            Session["ContentVisibility"] = false;
        }

        protected void Btn_Profile_Click(object sender, EventArgs e)
        {
            // N: Set visibility and update the session variable
            profileContentID.Visible = true;
            homeContentID.Visible = false; capitalContentID.Visible = false; monthlyContentID.Visible = false; feedbackContentID.Visible = false; manualContentID.Visible = false;

            Session["ContentVisibility"] = false;
        }

        protected void Btn_Logout_Click(object sender, EventArgs e)
        {
            // N: Clear session variables
            Session.Clear();

            // N: Redirect to the login page (adjust the URL accordingly)
            Response.Redirect("~/Index.aspx");
        }
    }
}