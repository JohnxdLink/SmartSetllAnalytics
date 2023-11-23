﻿using SmartSetll_Analytics_V2.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

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

        protected void Btn_Save_Click(object sender, EventArgs e)
        {
            int capital = Convert.ToInt32(Txb_Capital.Text);
            int days = Convert.ToInt32(Txb_Num_Days.Text);
            double averagePrice = Convert.ToDouble(Txb_Average_Price.Text);
            int population = Convert.ToInt32(Txb_Population.Text);
            double percentPopulation = Convert.ToDouble(Txb_Percent_Population.Text);
            double targetMarket = Convert.ToDouble(Txb_Target_Market.Text);
            int dailyTarget = Convert.ToInt32(Txb_Daily_Target.Text);
            double salesPerDay = Convert.ToDouble(Txb_Sales_Per_Day.Text);
            double monthlySales = Convert.ToDouble(Txb_Monthly_Sales.Text);
            double salaryPerDay = Convert.ToDouble(Txb_Salary_Per_Day.Text);
            double monthlySalary = Convert.ToDouble(Txb_Monthly_Salary.Text);
            double monthlyExpenses = Convert.ToDouble(Txb_Monthly_Expenses.Text);
            double totalExpenses = Convert.ToDouble(Txb_Total_Expenses.Text);
            double netProfit = Convert.ToDouble(Txb_Net_Profit.Text);
            double returnInvestment = Convert.ToDouble(Txb_Return_Investment.Text);
            double roiPrediction = Convert.ToDouble(Txb_Roi_Prediction.Text);

            try
            {
                string sqlConnect = "Data Source=ECCLESIASTES\\SQLEXPRESS;Initial Catalog=SmartSell_Db;User ID=ustyroid;Password=2315";
                string connectDatabase = "SmartSell_Db";

                using (SqlConnection obj_Connect_Db = new SqlConnection(sqlConnect))
                {
                    obj_Connect_Db.Open();
                    obj_Connect_Db.ChangeDatabase(connectDatabase);

                    string insertQuery = @"INSERT INTO [dbo].[General_SmartSell_Tbl] 
                                    ([Capital], [Days], [Average_Price], [Population], [Percent_Population], 
                                    [Target_Market], [Daily_Target], [Sales_Per_Day], [Monthly_Sales], 
                                    [Salary_Per_Day], [Monthly_Salary], [Monthly_Expenses], [Total_Expenses], 
                                    [Net_Profit], [Return_Investment], [Roi_Prediction])
                                    VALUES 
                                    (@Capital, @Days, @Average_Price, @Population, @Percent_Population, 
                                    @Target_Market, @Daily_Target, @Sales_Per_Day, @Monthly_Sales, 
                                    @Salary_Per_Day, @Monthly_Salary, @Monthly_Expenses, @Total_Expenses, 
                                    @Net_Profit, @Return_Investment, @Roi_Prediction)";

                    using (SqlCommand obj_Command_Db = new SqlCommand(insertQuery, obj_Connect_Db))
                    {
                        // Add parameters
                        obj_Command_Db.Parameters.AddWithValue("@Capital", capital);
                        obj_Command_Db.Parameters.AddWithValue("@Days", days);
                        obj_Command_Db.Parameters.AddWithValue("@Average_Price", averagePrice);
                        obj_Command_Db.Parameters.AddWithValue("@Population", population);
                        obj_Command_Db.Parameters.AddWithValue("@Percent_Population", percentPopulation);
                        obj_Command_Db.Parameters.AddWithValue("@Target_Market", targetMarket);
                        obj_Command_Db.Parameters.AddWithValue("@Daily_Target", dailyTarget);
                        obj_Command_Db.Parameters.AddWithValue("@Sales_Per_Day", salesPerDay);
                        obj_Command_Db.Parameters.AddWithValue("@Monthly_Sales", monthlySales);
                        obj_Command_Db.Parameters.AddWithValue("@Salary_Per_Day", salaryPerDay);
                        obj_Command_Db.Parameters.AddWithValue("@Monthly_Salary", monthlySalary);
                        obj_Command_Db.Parameters.AddWithValue("@Monthly_Expenses", monthlyExpenses);
                        obj_Command_Db.Parameters.AddWithValue("@Total_Expenses", totalExpenses);
                        obj_Command_Db.Parameters.AddWithValue("@Net_Profit", netProfit);
                        obj_Command_Db.Parameters.AddWithValue("@Return_Investment", returnInvestment);
                        obj_Command_Db.Parameters.AddWithValue("@Roi_Prediction", roiPrediction);

                        obj_Command_Db.ExecuteNonQuery();
                    }

                    test_ID.Text = "Successfully Inserted";
                }
            }
            catch (SqlException sqlEx)
            {
                // Log the specific SQL Server exception
                test_ID.Text = "SQL Server Exception: " + sqlEx.Message;
            }

            catch (Exception ex)
            {
                test_ID.Text = ex.StackTrace;
            }

            Final_Display_For_Text(capital, days, averagePrice, population, percentPopulation, targetMarket, dailyTarget, salesPerDay, monthlySales, salaryPerDay, monthlySalary, monthlyExpenses, totalExpenses, netProfit, returnInvestment, roiPrediction);
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
            Txb_Return_Investment.Text = returnInvestment.ToString();

            // N: Getting the getCalculateValue from its different Public Attributes and its parameters to perform certain task
            double roiPrediction = getCalculateValue.Calculate_Roi_Prediction(monthlySales, netProfit);

            // X: Display Textboxes to Webpage
            Txb_Roi_Prediction.Text = roiPrediction.ToString("F2");
        }

        protected void Final_Display_For_Text(int capital, int days, double averagePrice, int population, double percentPopulation, double targetMarket, int dailyTarget, double salesPerDay, double monthlySales, double salaryPerDay, double monthlySalary, double monthlyExpenses, double totalExpenses, double netProfit, double returnInvestMent, double roiPrediction)
        {
            Txb_Capital.Text = "₱ " + capital.ToString();
            Txb_Num_Days.Text = days.ToString();
            Txb_Average_Price.Text = "₱ " + averagePrice.ToString();
            Txb_Population.Text = population.ToString();
            Txb_Percent_Population.Text = percentPopulation.ToString() + "%";
            Txb_Target_Market.Text = targetMarket.ToString();
            Txb_Daily_Target.Text = dailyTarget.ToString();
            Txb_Sales_Per_Day.Text = "₱ " + salesPerDay.ToString();
            Txb_Monthly_Sales.Text = "₱ " + monthlySales.ToString();
            Txb_Salary_Per_Day.Text = "₱ " + salaryPerDay.ToString();
            Txb_Monthly_Salary.Text = "₱ " + monthlySalary.ToString();
            Txb_Monthly_Expenses.Text = "₱ " + monthlyExpenses.ToString();
            Txb_Total_Expenses.Text = "₱ " + totalExpenses.ToString();
            Txb_Net_Profit.Text = "₱ " + netProfit.ToString();
            Txb_Return_Investment.Text = returnInvestMent.ToString() + "%";
            Txb_Roi_Prediction.Text = roiPrediction.ToString() + " Year(s)";
        }

        public void Insert_To_Database(int capital, int days, double averagePrice, int population, double percentPopulation, double targetMarket, int dailyTarget, double salesPerDay, double monthlySales, double salaryPerDay, double monthlySalary, double monthlyExpenses, double totalExpenses, double netProfit, double returnInvestment, double roiPrediction)
        {

            try
            {
                string sqlConnect = "Data Source=ECCLESIASTES\\SQLEXPRESS;Initial Catalog=SmartSell_Db;User ID=ustyroid;Password=***********";
                string connectDatabase = "SmartSell_Db";
                using (SqlConnection obj_Connect_Db = new SqlConnection(sqlConnect))
                {
                    obj_Connect_Db.Open();
                    obj_Connect_Db.ChangeDatabase(connectDatabase);

                    //string insertQuery = "INSERT INTO [dbo].[General_SmartSell_Tbl] ([Capital], [Days], [Average_Price], [Population], [Percent_Population], [Target_Market], [Daily_Target], [Sales_Per_Day], [Monthly_Sales], [Salary_Per_Day], [Monthly_Salary], [Monthly_Expenses], [Total_Expenses], [Net_Profit], [Return_Investment], [Roi_Prediction]) VALUES (@Capital, @Days, @Average_Price, @Population, @Percent_Population, @Target_Market, @Daily_Target, @Sales_Per_Day, @Monthly_Sales, @Salary_Per_Day, @Monthly_Salary, @Monthly_Expenses, @Total_Expenses, @Net_Profit, @Return_Investment, @Roi_Prediction)";
                    string insertQuery = "INSERT INTO [dbo].[General_SmartSell_Tbl] ([Capital], [Days], [Average_Price], [Population], [Percent_Population], [Target_Market], [Daily_Target], [Sales_Per_Day], [Monthly_Sales], [Salary_Per_Day], [Monthly_Salary], [Monthly_Expenses], [Total_Expenses], [Net_Profit], [Return_Investment], [Roi_Prediction]) VALUES " + capital.ToString() + " " + days.ToString() + " " + averagePrice.ToString() + " " + population.ToString() + " " + percentPopulation.ToString() + " " + targetMarket.ToString() + " " + dailyTarget.ToString() + " " + salesPerDay.ToString() + " " + monthlySales.ToString() + " " + salaryPerDay.ToString() + " " + monthlySalary.ToString() + " " + monthlyExpenses.ToString() + " " + totalExpenses.ToString() + " " + netProfit.ToString() + " " + returnInvestment.ToString() + " " + roiPrediction.ToString();

                    using (SqlCommand obj_Command_Db = new SqlCommand(insertQuery, obj_Connect_Db))
                    {
                        obj_Command_Db.ExecuteNonQuery();
                    }

                    obj_Connect_Db.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

    }
}