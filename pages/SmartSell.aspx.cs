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

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // ? Button Calculate Target MAarket, Daily Target, Sales Per Day, Monthly Sales
        protected void Btn_One_Calculate_Click(object sender, EventArgs e)
        {
            int capital = setUserValue.Capital = Convert.ToInt32(Txb_Capital.Text);
            int days = setUserValue.Days = Convert.ToInt32(Txb_Num_Days.Text);
            double averagePrice = setUserValue.AveragePrice = Convert.ToDouble(Txb_Average_Price.Text);

            Compute_TargetMarket_To_MonthlySales(days, averagePrice);

            Txb_Capital.Text = capital.ToString();
            Txb_Num_Days.Text = days.ToString();
        }

        // ? Button Calculate Salary Per Day to MOnthly Salary
        protected void Btn_Two_Calculate_Click(object sender, EventArgs e)
        {
            int days = setUserValue.Days = Convert.ToInt32(Txb_Num_Days.Text);
            Compute_Monthly_Salary(days);
        }

        // ? Button Calcuate Total Expenses, Net Profit, Return of Investment & ROi Prediction
        protected void Btn_Three_Calculate_Click(object sender, EventArgs e)
        {
            double monthlySalary = Convert.ToDouble(Txb_Monthly_Salary.Text);
            double monthlySales = Convert.ToDouble(Txb_Monthly_Sales.Text);
            
            Compute_TotalExpenses_To_Roi(monthlySalary, monthlySales);  
        }

        public void Compute_TargetMarket_To_MonthlySales(int days, double averagePrice)
        {
            int population = setUserValue.Population = Convert.ToInt32(Txb_Population.Text);
            double percentPopulation = setUserValue.PercentPopulation = Convert.ToDouble(Txb_Percent_Population.Text);
            double targetMarket = getCalculateValue.Calculate_TargetMarket(population, percentPopulation);
            double dailyTarget = getCalculateValue.Calculate_DailyTarget(targetMarket, days);
            double salesPerDay = getCalculateValue.Calculate_Sales_PerDay(dailyTarget, averagePrice);
            double monthlySales = getCalculateValue.Calculate_Monthly_Sales(salesPerDay, days);
 
            Txb_Monthly_Sales.Text = monthlySales.ToString();
        }

        public void Compute_Monthly_Salary(int days)
        {
            double salaryPerDay = setUserValue.SalaryPerDay = Convert.ToDouble(Txb_Salary_Per_Day.Text);
            double monthlySalary = getCalculateValue.Calculate_MonthlySalary(salaryPerDay, days);

            Txb_Monthly_Salary.Text = monthlySalary.ToString();
        }

        public void Compute_TotalExpenses_To_Roi(double monthlySalary, double monthlySales)
        {
            double monthlyExpenses = setUserValue.MonthlyExpenses = Convert.ToDouble(Txb_Monthly_Expenses.Text);
            double totalExpenses = getCalculateValue.Calculate_TotalExpenses(monthlySalary, monthlyExpenses);

            Txb_Total_Expenses.Text = totalExpenses.ToString();

            double netProfit = getCalculateValue.Calculate_NetProfit(monthlySales, totalExpenses);

            Txb_Net_Profit.Text = netProfit.ToString();

            int capital = Convert.ToInt32(Txb_Capital.Text);

            double returnInvestment = getCalculateValue.Calculate_Roi((int)netProfit, capital);

            Txb_Return_Investment.Text = returnInvestment.ToString() + "%";

            double roiPrediction = getCalculateValue.Calculate_Roi_Prediction(monthlySales, netProfit);

            Txb_Roi_Prediction.Text = roiPrediction.ToString("F2");
        }

    }
}