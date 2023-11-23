using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace SmartSetll_Analytics_V2.classes
{
    public class InsertGeneralSmartSellData
    {
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

                    using(SqlCommand obj_Command_Db = new SqlCommand(insertQuery, obj_Connect_Db))
                    {
                        obj_Command_Db.ExecuteNonQuery();
                    }

                    obj_Connect_Db.Close();
                }
            } catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }

}