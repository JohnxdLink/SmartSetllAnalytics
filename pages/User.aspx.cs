using SmartSetll_Analytics_V2.classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartSetll_Analytics_V2.pages
{
    public partial class User : System.Web.UI.Page
    {
        GetUserSmartSell userSmartSell = new GetUserSmartSell();
        GetSetCapital getUserRealTimeData = new GetSetCapital();
        CalculateValues realTimeMonthly = new CalculateValues();

        protected void Page_Load(object sender, EventArgs e)
        {
            // X: Display Home as Default Page
            homeContentID.Visible = true;

            if (!IsPostBack)
            {
                // N: Check if the user is logged in
                if (Session["Company_ID"] == null || Session["Company_Name"] == null)
                {
                    // Redirect back to index.aspx if not logged in
                    Response.Redirect("~/Index.aspx");
                }
                else
                {
                    // N: Update labels with company information
                    int companyId = (int)Session["Company_ID"];
                    string companyName = (string)Session["Company_Name"];

                    Lbl_Company_ID.Text = companyId.ToString();
                    Lbl_Company_Name.Text = "Company: " + companyName;


                    // N: Instanstiating userSmartSell Object to Retrieve User SmartSell Data
                    userSmartSell.RetrieveUserSmartSellData(companyId, Lbl_Capital, Lbl_Num_Days, Lbl_Average_Price, Lbl_Population, Lbl_Percent_Population, Lbl_Target_Market, Lbl_Daily_Target, Lbl_Sales_Per_Day, Lbl_Monthly_Sales, Lbl_Salary_Per_Day, Lbl_Monthly_Salary, Lbl_Monthly_Expenses, Lbl_Total_Expenses, Lbl_Net_Profit, Lbl_Return_Investment, Lbl_Roi_Prediction);
                    LoadAndBindData();
                }
            }

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

            //N: Instanstiang Object GetSetCapital
            getUserRealTimeData.Insert_Capital(Convert.ToInt32(Lbl_Company_ID.Text), Convert.ToInt32(Txb_Item_Qty.Text), Txb_Item_Name.Text, Convert.ToDouble(Txb_Item_Price.Text));
            LoadAndBindData();

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

        protected void Btn_Real_Monthly_Click(object sender, EventArgs e)
        {
            // N: Set visibility and update the session variable
            monthlyContentID.Visible = true;

            double rlTotalExpenses = realTimeMonthly.Calculate_TotalExpenses(Convert.ToDouble(Txb_Rl_MonthlyExpenses.Text), Convert.ToDouble(Txb_Rl_MonthlySalary.Text));
            double rlNetPRofit = realTimeMonthly.Calculate_NetProfit(Convert.ToDouble(Txb_Rl_MonthlySales.Text), rlTotalExpenses);
            double rlRoi = realTimeMonthly.Calculate_Roi((int)rlNetPRofit, Convert.ToDouble(Lbl_Capital.Text));
            double rlRoi_Prediction = realTimeMonthly.Calculate_Roi_Prediction(Convert.ToDouble(Txb_Rl_MonthlySales.Text), rlNetPRofit);
            
            getUserRealTimeData.Insert_RealTime_Month(Convert.ToInt32(Lbl_Company_ID.Text), Txb_Month.Text, Convert.ToDouble(Txb_Rl_MonthlySales.Text), Convert.ToDouble(Txb_Rl_MonthlySalary.Text), Convert.ToDouble(Txb_Rl_MonthlyExpenses.Text), rlTotalExpenses, rlNetPRofit, rlRoi, rlRoi_Prediction);

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

        private void LoadAndBindData()
        {
            DataTable obj_DataCapital = getUserRealTimeData.Get_Capital(Convert.ToInt32(Lbl_Company_ID.Text));

            // N: Display the data in a GridView
            Gridvw_Capital.DataSource = obj_DataCapital;
            Gridvw_Capital.DataBind();
        }

    }
}