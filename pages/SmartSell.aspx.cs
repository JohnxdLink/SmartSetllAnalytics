using SmartSetll_Analytics_V2.classes;
using System;

namespace SmartSetll_Analytics_V2.pages
{
    /* 
     * Project: SmartSell Analytics
     * Developer: Castro JOhn Christian
     * Message: Almost Finished Working on this Backend 
     * Date Started: 11/19/2023
     */

    public partial class SmartSell : System.Web.UI.Page
    {
        // N: Instantiating GetSeVAlues class to create an Object setUSerValue
        GetSetValues setUserValue = new GetSetValues();

        // N: Instantiating CalculateValues class to create an Object getCalculateValue
        CalculateValues getCalculateValue = new CalculateValues();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // ? Button Calculate Target MAarket, Daily Target, Sales Per Day, Monthly Sales
        protected void Btn_One_Calculate_Click(object sender, EventArgs e)
        {
            // N: Setting the setUserValue from Textboxes and set in Variable
            int capital = setUserValue.Capital = Convert.ToInt32(Txb_Capital.Text);
            int days = setUserValue.Days = Convert.ToInt32(Txb_Num_Days.Text);
            double averagePrice = setUserValue.AveragePrice = Convert.ToDouble(Txb_Average_Price.Text);

            // N: In order to Compute TargetMarket to MonthlySales, it need parameters days and averagePrice
            Compute_TargetMarket_To_MonthlySales(days, averagePrice);

            // X: Display Textboxes to Webpage
            Txb_Capital.Text = capital.ToString();
            Txb_Num_Days.Text = days.ToString();
            Txb_Average_Price.Text = averagePrice.ToString();
        }

        // ? Button Calculate Salary Per Day to MOnthly Salary
        protected void Btn_Two_Calculate_Click(object sender, EventArgs e)
        {
            // N: Setting the setUserValue from Textboxes and set in Variable
            int days = setUserValue.Days = Convert.ToInt32(Txb_Num_Days.Text);

            // N: In order to Compute Monthly Salary, it need parameter days
            Compute_Monthly_Salary(days);
        }

        // ? Button Calcuate Total Expenses, Net Profit, Return of Investment & ROi Prediction
        protected void Btn_Three_Calculate_Click(object sender, EventArgs e)
        {
            // N: Getting the Textboxes Value and store it in Variables
            double monthlySalary = Convert.ToDouble(Txb_Monthly_Salary.Text);
            double monthlySales = Convert.ToDouble(Txb_Monthly_Sales.Text);

            // N: In order to Compute Total Expenses to ROI Prediction, it need parameters MonthlySalary and MonthlySales
            Compute_TotalExpenses_To_Roi(monthlySalary, monthlySales);
        }

        // ? Button to save those data entry to Database
        protected void Btn_Save_Click(object sender, EventArgs e)
        {
            // N: Instanstiating InsetGeneralSmartSellDAta
            InsertGeneralSmartSellData obj_InsertData = new InsertGeneralSmartSellData();

            // N: Calling the Insert_To_Database and add those parameters
            obj_InsertData.Insert_To_Database(Convert.ToInt32(Txb_Capital.Text), Convert.ToInt32(Txb_Num_Days.Text), Convert.ToDouble(Txb_Average_Price.Text), Convert.ToInt32(Txb_Population.Text), Convert.ToDouble(Txb_Percent_Population.Text), Convert.ToDouble(Txb_Target_Market.Text), Convert.ToInt32(Txb_Daily_Target.Text), Convert.ToDouble(Txb_Sales_Per_Day.Text), Convert.ToDouble(Txb_Monthly_Sales.Text), Convert.ToDouble(Txb_Salary_Per_Day.Text), Convert.ToDouble(Txb_Monthly_Salary.Text), Convert.ToDouble(Txb_Monthly_Expenses.Text), Convert.ToDouble(Txb_Total_Expenses.Text), Convert.ToDouble(Txb_Net_Profit.Text), Convert.ToDouble(Txb_Return_Investment.Text), Convert.ToDouble(Txb_Roi_Prediction.Text));

            // X: Dispaly All Textboxes with its format
            Final_Display_For_Text(Convert.ToInt32(Txb_Capital.Text), Convert.ToInt32(Txb_Num_Days.Text), Convert.ToDouble(Txb_Average_Price.Text), Convert.ToInt32(Txb_Population.Text), Convert.ToDouble(Txb_Percent_Population.Text), Convert.ToDouble(Txb_Target_Market.Text), Convert.ToInt32(Txb_Daily_Target.Text), Convert.ToDouble(Txb_Sales_Per_Day.Text), Convert.ToDouble(Txb_Monthly_Sales.Text), Convert.ToDouble(Txb_Salary_Per_Day.Text), Convert.ToDouble(Txb_Monthly_Salary.Text), Convert.ToDouble(Txb_Monthly_Expenses.Text), Convert.ToDouble(Txb_Total_Expenses.Text), Convert.ToDouble(Txb_Net_Profit.Text), Convert.ToDouble(Txb_Return_Investment.Text), Convert.ToDouble(Txb_Roi_Prediction.Text));

            // N: Setting the Save Button Enable to False so that it will be temporary disabled
            Btn_Save.Enabled = false;
        }

        // ? Button to Clear and Set the Btn_Save to true
        protected void Btn_Clear_Click(object sender, EventArgs e)
        {
            // N: Clearing all the Text in Textboxes
            Txb_Capital.Text = ""; Txb_Num_Days.Text = ""; Txb_Average_Price.Text = ""; Txb_Population.Text = ""; Txb_Percent_Population.Text = ""; Txb_Target_Market.Text = ""; Txb_Daily_Target.Text = ""; Txb_Sales_Per_Day.Text = ""; Txb_Monthly_Sales.Text = ""; Txb_Salary_Per_Day.Text = ""; Txb_Monthly_Salary.Text = ""; Txb_Monthly_Expenses.Text = ""; Txb_Total_Expenses.Text = ""; Txb_Net_Profit.Text = ""; Txb_Return_Investment.Text = ""; Txb_Roi_Prediction.Text = "";
            Btn_Save.Enabled = true;
        }

        // ? A void method to Compute TargetMarket to MonthlySales
        public void Compute_TargetMarket_To_MonthlySales(int days, double averagePrice)
        {
            // N: Setting the setUserValue from Textboxes and set in Variable
            int population = setUserValue.Population = Convert.ToInt32(Txb_Population.Text);
            double percentPopulation = setUserValue.PercentPopulation = Convert.ToDouble(Txb_Percent_Population.Text);

            // N: Getting the getCalculateValue from its different Public Attributes and its parameters to perform certain task
            double targetMarket = getCalculateValue.Calculate_TargetMarket(population, percentPopulation);
            double dailyTarget = getCalculateValue.Calculate_DailyTarget(targetMarket, days);
            double salesPerDay = getCalculateValue.Calculate_Sales_PerDay(dailyTarget, averagePrice);
            double monthlySales = getCalculateValue.Calculate_Monthly_Sales(salesPerDay, days);

            // X: Display Textboxes to Webpage
            Txb_Population.Text = population.ToString();
            Txb_Percent_Population.Text = percentPopulation.ToString();
            Txb_Target_Market.Text = targetMarket.ToString("F2"); // N: "F2" To display 2 decimal places
            Txb_Daily_Target.Text = dailyTarget.ToString();
            Txb_Sales_Per_Day.Text = salesPerDay.ToString();
            Txb_Monthly_Sales.Text = monthlySales.ToString();
        }

        // ? A void method to Compute Monthly Salary and its parameter days
        public void Compute_Monthly_Salary(int days)
        {
            // N: Setting the setUserValue from Textboxes and set in Variable
            double salaryPerDay = setUserValue.SalaryPerDay = Convert.ToDouble(Txb_Salary_Per_Day.Text);

            // N: Getting the getCalculateValue from its different Public Attributes and its parameters to perform certain task
            double monthlySalary = getCalculateValue.Calculate_MonthlySalary(salaryPerDay, days);

            // X: Display Textboxes to Webpage
            Txb_Salary_Per_Day.Text = salaryPerDay.ToString();
            Txb_Monthly_Salary.Text = monthlySalary.ToString();
        }

        // ? A void method to Compute Total Expenses, Return of Investment and ROI Prediction and its parameters monthlySalary and monthSales
        public void Compute_TotalExpenses_To_Roi(double monthlySalary, double monthlySales)
        {

            // N: Setting the setUserValue from Textboxes and set in Variable
            double monthlyExpenses = setUserValue.MonthlyExpenses = Convert.ToDouble(Txb_Monthly_Expenses.Text);

            // N: Getting the getCalculateValue from its different Public Attributes and its parameters to perform certain task
            double totalExpenses = getCalculateValue.Calculate_TotalExpenses(monthlySalary, monthlyExpenses);

            // X: Display Textboxes to Webpage
            Txb_Total_Expenses.Text = totalExpenses.ToString();

            // N: Getting the getCalculateValue from its different Public Attributes and its parameters to perform certain task
            double netProfit = getCalculateValue.Calculate_NetProfit(monthlySales, totalExpenses);

            // X: Display Textboxes to Webpage
            Txb_Net_Profit.Text = netProfit.ToString();

            // N: Declaring variable to get the Textbox Value
            int capital = Convert.ToInt32(Txb_Capital.Text);

            // N: Getting the getCalculateValue from its different Public Attributes and its parameters to perform certain task
            double returnInvestment = getCalculateValue.Calculate_Roi((int)netProfit, capital);

            // X: Display Textboxes to Webpage
            Txb_Return_Investment.Text = returnInvestment.ToString("F2");

            // N: Getting the getCalculateValue from its different Public Attributes and its parameters to perform certain task
            double roiPrediction = getCalculateValue.Calculate_Roi_Prediction(monthlySales, netProfit);

            // X: Display Textboxes to Webpage
            Txb_Roi_Prediction.Text = roiPrediction.ToString("F2");
        }

        // ? A Void to Display All Textboxes and convert to String
        protected void Final_Display_For_Text(int capital, int days, double averagePrice, int population, double percentPopulation, double targetMarket, int dailyTarget, double salesPerDay, double monthlySales, double salaryPerDay, double monthlySalary, double monthlyExpenses, double totalExpenses, double netProfit, double returnInvestMent, double roiPrediction)
        {
            Txb_Capital.Text = "₱ " + capital.ToString(); Txb_Num_Days.Text = days.ToString() + " Day(s)"; Txb_Average_Price.Text = "₱ " + averagePrice.ToString(); Txb_Population.Text = population.ToString(); Txb_Percent_Population.Text = percentPopulation.ToString() + "%"; Txb_Target_Market.Text = targetMarket.ToString(); Txb_Daily_Target.Text = dailyTarget.ToString(); Txb_Sales_Per_Day.Text = "₱ " + salesPerDay.ToString(); Txb_Monthly_Sales.Text = "₱ " + monthlySales.ToString(); Txb_Salary_Per_Day.Text = "₱ " + salaryPerDay.ToString(); Txb_Monthly_Salary.Text = "₱ " + monthlySalary.ToString(); Txb_Monthly_Expenses.Text = "₱ " + monthlyExpenses.ToString(); Txb_Total_Expenses.Text = "₱ " + totalExpenses.ToString(); Txb_Net_Profit.Text = "₱ " + netProfit.ToString(); Txb_Return_Investment.Text = returnInvestMent.ToString() + "%"; Txb_Roi_Prediction.Text = roiPrediction.ToString() + " Year(s)";
        }
    }
}