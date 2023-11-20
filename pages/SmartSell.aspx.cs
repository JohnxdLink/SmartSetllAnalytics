using SmartSetll_Analytics_V2.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartSetll_Analytics_V2.pages
{
    /* 
     * Project: SmartSell Analytics
     * Developer: Castro JOhn Christian
     * Message: Under Development in Backend
     * Date Started: 11/19/2023
     */

    public partial class SmartSell : System.Web.UI.Page
    {
        // ! Txb_Capital || Txb_Num_Days || Txb_Average_Price || Txb_Population || Txb_Percent_Population || Txb_Target_Market
        // ! Txb_Daily_Target || Txb_Sales_Per_Day || Txb_Monthly_Sales
        // ! Txb_Salary_Per_Day || Txb_Monthly_Salary // Txb_Monthly_Expenses // Txb_Total_Expenses
        // ! Txb_Net_Profit || Txb_Return_Investment || Txb_Roi_Prediction

        // ? Instantiating GetSeVAlues class to create an Object getUSerValue
        GetSetValues getUserValue = new GetSetValues();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // ? Button Calculate Target MAarket, Daily Target, Sales Per Day, Monthly Sales
        protected void Btn_One_Calculate_Click(object sender, EventArgs e)
        {
            // ! Setting the encapsulated attributes and convert the Inputted Text from Web page
            int capital = getUserValue.Capital = Convert.ToInt32(Txb_Capital.Text);
            int days = getUserValue.Days = Convert.ToInt32(Txb_Num_Days.Text);
            double averagePrice = getUserValue.AveragePrice = Convert.ToDouble(Txb_Average_Price.Text);
            int population = getUserValue.Population = Convert.ToInt32(Txb_Population.Text);
            double percentPopulation = getUserValue.PercentPopulation = Convert.ToDouble(Txb_Percent_Population.Text);

            Display_Capital_Days_Price_Population_Percent(capital, days, averagePrice, population, percentPopulation);
        }

        // ? Button Calculate Salary Per Day to MOnthly Salary
        protected void Btn_Two_Calculate_Click(object sender, EventArgs e)
        { 
        }

        // ? Button Calcuate Total Expenses, Net Profit, Return of Investment & ROi Prediction
        protected void Btn_Three_Calculate_Click(object sender, EventArgs e)
        {

        }

        // ! Creating Displays for Capital Days Price Population and Percent and its parameters
        protected void Display_Capital_Days_Price_Population_Percent(int capital, int days, double averagePrice, int population, double percentPopulation)
        {
            Txb_Capital.Text = capital.ToString();
            Txb_Num_Days.Text = days.ToString();
            Txb_Average_Price.Text = "₱ " + averagePrice.ToString();
            Txb_Population.Text = population.ToString();
            Txb_Target_Market.Text = percentPopulation.ToString() + "%";
        }
    }
}