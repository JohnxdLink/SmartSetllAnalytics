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

        // ? Instantiating GetSeVAlues class to create an Object setUSerValue
        GetSetValues setUserValue = new GetSetValues();

        //? Instantiating CalculateValues class to create an Object getCalculateValue
        CalculateValues getCalculateValue = new CalculateValues();

        double globalMonthlySales = 0;
        double globalTotalExpenses = 0;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // ? Button Calculate Target MAarket, Daily Target, Sales Per Day, Monthly Sales
        protected void Btn_One_Calculate_Click(object sender, EventArgs e)
        {
            // ! Setting the encapsulated attributes and convert the Inputted Text from Web page
            int capital = setUserValue.Capital = Convert.ToInt32(Txb_Capital.Text);
            int days = setUserValue.Days = Convert.ToInt32(Txb_Num_Days.Text);
            double averagePrice = setUserValue.AveragePrice = Convert.ToDouble(Txb_Average_Price.Text);
            int population = setUserValue.Population = Convert.ToInt32(Txb_Population.Text);
            double percentPopulation = setUserValue.PercentPopulation = Convert.ToDouble(Txb_Percent_Population.Text);

            // ! Getting the Calculated Values and inside of the Parameters are the variables that encapsulated in SetUSerValue
            double targetMarket = getCalculateValue.Calculate_TargetMarket(population, percentPopulation);
            double dailyTarget = getCalculateValue.Calculate_DailyTarget(targetMarket, days);
            double salesPerDay = getCalculateValue.Calculate_Sales_PerDay(dailyTarget, averagePrice);
            double monthlySales = getCalculateValue.Calculate_Monthly_Sales(salesPerDay, days);

            globalMonthlySales += monthlySales;

            // ! Display
            Display_Section_One(capital, days, averagePrice, population, percentPopulation, targetMarket, dailyTarget, salesPerDay, monthlySales);
        }

        // ? Button Calculate Salary Per Day to MOnthly Salary
        protected void Btn_Two_Calculate_Click(object sender, EventArgs e)
        {
            // ! Setting the encapsulated attributes and convert the Inputted Text from Web page
            double salaryPerDay = setUserValue.SalaryPerDay = Convert.ToDouble(Txb_Salary_Per_Day.Text);
            int days = setUserValue.Days = Convert.ToInt32(Txb_Num_Days.Text);
            

            double monthlySalary = getCalculateValue.Calculate_MonthlySalary(salaryPerDay, days);
            Display_Section_Two(monthlySalary);
        }

        // ? Button Calcuate Total Expenses, Net Profit, Return of Investment & ROi Prediction
        protected void Btn_Three_Calculate_Click(object sender, EventArgs e)
        {
            double monthlyExpenses = setUserValue.MonthlyExpenses = Convert.ToDouble(Txb_Monthly_Expenses.Text);

            // ! Setting the encapsulated attributes and convert the Inputted Text from Web page
            double salaryPerDay = setUserValue.SalaryPerDay = Convert.ToDouble(Txb_Salary_Per_Day.Text);
            int days = setUserValue.Days = Convert.ToInt32(Txb_Num_Days.Text);


            double monthlySalary = getCalculateValue.Calculate_MonthlySalary(salaryPerDay, days);
            double totalExpenses = getCalculateValue.Calculate_TotalExpenses(monthlySalary, monthlyExpenses);

            globalTotalExpenses += totalExpenses;
            double netProfit = getCalculateValue.Calculate_NetProfit(globalMonthlySales, globalTotalExpenses);

            Display_Section_Three(globalMonthlySales, globalTotalExpenses, netProfit);
        }

        // ! Creating Displays
        protected void Display_Section_One(int capital, int days, double averagePrice, int population, double percentPopulation, double targetMarket, double dailyTarget, double salesPerDay, double monthlySales)
        {
            Txb_Capital.Text = capital.ToString();
            Txb_Num_Days.Text = days.ToString();
            Txb_Average_Price.Text = "₱ " + averagePrice.ToString();
            Txb_Population.Text = population.ToString();
            Txb_Percent_Population.Text = percentPopulation.ToString() + "%";
            Txb_Target_Market.Text = targetMarket.ToString();
            Txb_Daily_Target.Text = dailyTarget.ToString();
            Txb_Sales_Per_Day.Text = "₱ " + salesPerDay.ToString();
            Txb_Monthly_Sales.Text = "₱ " + monthlySales.ToString();
        }

        protected void Display_Section_Two(double monthlySalary)
        {
            Txb_Monthly_Salary.Text = "₱ " + monthlySalary.ToString();
        }

        protected void Display_Section_Three(double monthlyExpenses, double totalExpenses, double netProfit)
        {
            Txb_Monthly_Expenses.Text = "₱ " + monthlyExpenses.ToString();
            Txb_Total_Expenses.Text = "₱ " + totalExpenses.ToString();
            Txb_Net_Profit.Text = "₱ " + netProfit.ToString();

        }

    }
}