using System;
using System.Data.SqlClient; // N: System for SQL Server
using System.Web.UI.WebControls;

namespace SmartSetll_Analytics_V2.classes
{
    public class InsertGeneralSmartSellData
    {
        // N: SqlConnection String and Connect Database
        string sqlConnect = "Data Source=ECCLESIASTES\\SQLEXPRESS;Initial Catalog=SmartSell_Db;User ID=ustyroid;Password=2315";
        string connectDatabase = "SmartSell_Db";

        // ? A Void to peform Inserting Data to Database that has pararmeters
        public void Insert_To_Database(int capital, int days, double averagePrice, int population, double percentPopulation, double targetMarket, int dailyTarget, double salesPerDay, double monthlySales, double salaryPerDay, double monthlySalary, double monthlyExpenses, double totalExpenses, double netProfit, double returnInvestment, double roiPrediction)
        {
            try
            {
                // N: Using "USing" statement so that it has a function that could dispose and close the Connection
                using (SqlConnection obj_Connect_Db = new SqlConnection(sqlConnect))
                {
                    // N: Instanstiating Connection Database to Open
                    obj_Connect_Db.Open();
                    obj_Connect_Db.ChangeDatabase(connectDatabase);

                    // N: String for Inset Query
                    string insertQuery = @"INSERT INTO [dbo].[General_SmartSell_Tbl] ([Capital], [Days], [Average_Price], [Population], [Percent_Population], [Target_Market], [Daily_Target], [Sales_Per_Day], [Monthly_Sales], [Salary_Per_Day], [Monthly_Salary], [Monthly_Expenses], [Total_Expenses], [Net_Profit], [Return_Investment], [Roi_Prediction]) VALUES (@Capital, @Days, @Average_Price, @Population, @Percent_Population, @Target_Market, @Daily_Target, @Sales_Per_Day, @Monthly_Sales, @Salary_Per_Day, @Monthly_Salary, @Monthly_Expenses, @Total_Expenses, @Net_Profit, @Return_Investment, @Roi_Prediction)";


                    // N: SqlCommand to insert Query
                    using (SqlCommand obj_Command_Db = new SqlCommand(insertQuery, obj_Connect_Db))
                    {
                        // N: Using this method for prevention of SQL Injection
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

                        // N: Executing Query to Insert in Database
                        obj_Command_Db.ExecuteNonQuery();
                    }
                }
            }

            catch (SqlException sqlEx)
            {
                Console.WriteLine(sqlEx);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void Insert_Registered_Account(string companyName, string firstName, string middleName, string lastName, string username, string password, string confirmPassword, string email)
        {
            try
            {
                using (SqlConnection obj_Connect_Db = new SqlConnection(sqlConnect))
                {
                    // N: Instanstiating Connection Database to Open
                    obj_Connect_Db.Open();
                    obj_Connect_Db.ChangeDatabase(connectDatabase);

                    string insertQuery = @"INSERT INTO [dbo].[Registered_Account] ([Company_Name], [First_Name], [Middle_Name], [Last_Name], [Username], [Password], [Confirm_Password], [Email]) VALUES (@Company_Name, @First_Name, @Middle_Name, @Last_Name, @Username, @Password, @Confirm_Password, @Email)";

                    using (SqlCommand obj_Command_Db = new SqlCommand(insertQuery, obj_Connect_Db))
                    {
                        obj_Command_Db.Parameters.AddWithValue("@Company_Name", companyName);
                        obj_Command_Db.Parameters.AddWithValue("@First_Name", firstName);
                        obj_Command_Db.Parameters.AddWithValue("@Middle_Name", middleName);
                        obj_Command_Db.Parameters.AddWithValue("@Last_Name", lastName);
                        obj_Command_Db.Parameters.AddWithValue("@Username", username);
                        obj_Command_Db.Parameters.AddWithValue("@Password", password);
                        obj_Command_Db.Parameters.AddWithValue("@Confirm_Password", confirmPassword);
                        obj_Command_Db.Parameters.AddWithValue("@Email", email);

                        obj_Command_Db.ExecuteNonQuery();
                    }

                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine(sqlEx);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void Insert_Or_Update_User_Data(int companyID, int capital, int days, double averagePrice, int population, double percentPopulation, double targetMarket, int dailyTarget, double salesPerDay, double monthlySales, double salaryPerDay, double monthlySalary, double monthlyExpenses, double totalExpenses, double netProfit, double returnInvestment, double roiPrediction)
        {
            try
            {
                using (SqlConnection obj_Connect_Db = new SqlConnection(sqlConnect))
                {
                    obj_Connect_Db.Open();
                    obj_Connect_Db.ChangeDatabase(connectDatabase);

                    string insertMergeQuery = @" MERGE INTO [dbo].[User_SmartSell] AS target USING (VALUES (@Company_ID, @Capital, @Days, @Average_Price, @Population, @Percent_Population, @Target_Market, @Daily_Target, @Sales_Per_Day, @Monthly_Sales, @Salary_Per_Day, @Monthly_Salary, @Monthly_Expenses, @Total_Expenses, @Net_Profit, @Return_Investment, @Roi_Prediction)) AS source ([Company_ID], [Capital], [Days], [Average_Price], [Population], [Percent_Population], [Target_Market], [Daily_Target], [Sales_Per_Day], [Monthly_Sales], [Salary_Per_Day], [Monthly_Salary], [Monthly_Expenses], [Total_Expenses], [Net_Profit], [Return_Investment], [Roi_Prediction]) ON target.[Company_ID] = source.[Company_ID]
                                                WHEN MATCHED THEN
                                                UPDATE SET
                                                [Capital] = source.[Capital],
                                                [Days] = source.[Days],
                                                [Average_Price] = source.[Average_Price],
                                                [Population] = source.[Population],
                                                [Percent_Population] = source.[Percent_Population],
                                                [Target_Market] = source.[Target_Market],
                                                [Daily_Target] = source.[Daily_Target],
                                                [Sales_Per_Day] = source.[Sales_Per_Day],
                                                [Monthly_Sales] = source.[Monthly_Sales],
                                                [Salary_Per_Day] = source.[Salary_Per_Day],
                                                [Monthly_Salary] = source.[Monthly_Salary],
                                                [Monthly_Expenses] = source.[Monthly_Expenses],
                                                [Total_Expenses] = source.[Total_Expenses],
                                                [Net_Profit] = source.[Net_Profit],
                                                [Return_Investment] = source.[Return_Investment],
                                                [Roi_Prediction] = source.[Roi_Prediction]
                                                WHEN NOT MATCHED THEN
                                                INSERT ([Company_ID], [Capital], [Days], [Average_Price], [Population], [Percent_Population], [Target_Market], [Daily_Target], [Sales_Per_Day], [Monthly_Sales], [Salary_Per_Day], [Monthly_Salary], [Monthly_Expenses], [Total_Expenses], [Net_Profit], [Return_Investment], [Roi_Prediction])
                                                VALUES (source.[Company_ID], source.[Capital], source.[Days], source.[Average_Price], source.[Population], source.[Percent_Population], source.[Target_Market], source.[Daily_Target], source.[Sales_Per_Day], source.[Monthly_Sales], source.[Salary_Per_Day], source.[Monthly_Salary], source.[Monthly_Expenses], source.[Total_Expenses], source.[Net_Profit], source.[Return_Investment], source.[Roi_Prediction]);";

                    using (SqlCommand obj_Command_Db = new SqlCommand(insertMergeQuery, obj_Connect_Db))
                    {
                        obj_Command_Db.Parameters.AddWithValue("@Company_ID", companyID);
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
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine(sqlEx);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


    }

}