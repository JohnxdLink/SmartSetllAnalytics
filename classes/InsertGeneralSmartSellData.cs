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
                string sqlConnect = "Data Source=ECCLESIASTES\\SQLEXPRESS;Initial Catalog=SmartSell_Db;User ID=ustyroid;Password=2315";
                using (SqlConnection obj_Connect_Db = new SqlConnection(sqlConnect))
                {
                    obj_Connect_Db.Open();

                    string insertQuery = "INSERT INTO [dbo].[General_SmartSell_Tbl] ([Capital], [Days], [Average_Price], [Population], [Percent_Population], [Target_Market], [Daily_Target], [Sales_Per_Day], [Monthly_Sales], [Salary_Per_Day], [Monthly_Salary], [Monthly_Expenses], [Total_Expenses], [Net_Profit], [Return_Investment], [Roi_Prediction]) VALUES (@capital, @days, @averagePrice, @population, @percentPopulation, @targetMarket, @dailyTarget, @salesPerDay, @monthlySales, @salaryPerDay, @monthlySalary, @monthlyExpenses, @totalExpenses, @netProfit, @returnInvestment, @roiPrediction);";

                    using(SqlCommand obj_Command_Db = new SqlCommand(insertQuery, obj_Connect_Db))
                    {

                        obj_Command_Db.Parameters.AddWithValue("@capital", capital);
                        obj_Command_Db.Parameters.AddWithValue("@days", days);
                        obj_Command_Db.Parameters.AddWithValue("@averagePrice", averagePrice);
                        obj_Command_Db.Parameters.AddWithValue("@population", population);
                        obj_Command_Db.Parameters.AddWithValue("@percentPopulation", percentPopulation);
                        obj_Command_Db.Parameters.AddWithValue("@targetMarket", targetMarket);
                        obj_Command_Db.Parameters.AddWithValue("@dailyTarget", dailyTarget);
                        obj_Command_Db.Parameters.AddWithValue("@salesPerDay", salesPerDay);
                        obj_Command_Db.Parameters.AddWithValue("@monthlySales", monthlySales);
                        obj_Command_Db.Parameters.AddWithValue("@salaryPerDay", salaryPerDay);
                        obj_Command_Db.Parameters.AddWithValue("@monthlySalary", monthlySalary);
                        obj_Command_Db.Parameters.AddWithValue("@monthlyExpenses", monthlyExpenses);
                        obj_Command_Db.Parameters.AddWithValue("@totalExpenses", totalExpenses);
                        obj_Command_Db.Parameters.AddWithValue("@netProfit", netProfit);
                        obj_Command_Db.Parameters.AddWithValue("@returnInvestment", returnInvestment);
                        obj_Command_Db.Parameters.AddWithValue("@roiPrediction", roiPrediction);
                        
                        obj_Command_Db.ExecuteNonQuery();
                    }

                    obj_Connect_Db.Close();
                }
            } catch(Exception ex)
            {
            }
        }
    }

}