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

                    obj_Connect_Db.Close();
                }
            }
            catch (SqlException sqlEx)
            {

            }

            catch (Exception ex)
            {

            }
        }
    }

}