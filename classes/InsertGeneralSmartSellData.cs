using System;
using System.Data.SqlClient; // N: System for SQL Server
using System.Diagnostics; // N: System Diagnostics for Error Log


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

            // N: SqlException to identify the specific SQL Error such as Login
            catch (SqlException sqlEx)
            {
                Error_Log("SQL Error Occured: " + sqlEx);
            }

            // N: General Error in SQL Server
            catch (Exception ex)
            {
                Error_Log("General Error Occured: " + ex);
            }
        }

        public void Insert_Registered_Account(string companyName, string firstName, string middleName, string lastName, string username, string password, string confirmPassword, string email)
        {
            try
            {
                using(SqlConnection obj_Connect_Db = new SqlConnection(sqlConnect))
                {
                    // N: Instanstiating Connection Database to Open
                    obj_Connect_Db.Open();
                    obj_Connect_Db.ChangeDatabase(connectDatabase);

                    string insertQuery = @"INSERT INTO [dbo].[Registered_Account] ([Company_Name], [First_Name], [Middle_Name], [Last_Name], [Username], [Password], [Confirm_Password], [Email]) VALUES (@Company_Name, @First_Name, @Middle_Name, @Last_Name, @Username, @Password, @Confirm_Password, @Email)";

                    using(SqlCommand obj_Command_Db = new SqlCommand(insertQuery, obj_Connect_Db))
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
                Error_Log("SQL Error Occured: " + sqlEx);
            }
            catch (Exception ex)
            {
                Error_Log("General Error Occured: " + ex);
            }
        }

        // N: Error Log Function
        private void Error_Log(String errorMessage)
        {
            // X: Displaying the Error in Catch Statement
            Trace.WriteLine(errorMessage);
        }
    }

}