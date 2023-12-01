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

        // ? A Void to insert Registered Account
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


        // ? A Void to Insert Or Update SmartSell Data from SmartSell page
        public void Insert_Or_Update_User_Data(string username, string password, int companyID, int capital, int days, double averagePrice, int population, double percentPopulation, double targetMarket, int dailyTarget, double salesPerDay, double monthlySales, double salaryPerDay, double monthlySalary, double monthlyExpenses, double totalExpenses, double netProfit, double returnInvestment, double roiPrediction)
        {
            try
            {
                using (SqlConnection obj_Connect_Db = new SqlConnection(sqlConnect))
                {
                    obj_Connect_Db.Open();
                    obj_Connect_Db.ChangeDatabase(connectDatabase);

                    // N: Selecting useer and its password
                    string selectQuery = @"SELECT COUNT(*) FROM [dbo].[Registered_Account] WHERE Username = @Username AND Password = @Password";

                    using (SqlCommand obj_Command_Db = new SqlCommand(selectQuery, obj_Connect_Db))
                    {
                        // N: This is where that if the account exist it will proceed to check if theres an existing data or need to be update
                        obj_Command_Db.Parameters.AddWithValue("@Username", username);
                        obj_Command_Db.Parameters.AddWithValue("@Password", password);

                        int count = (int)obj_Command_Db.ExecuteScalar();

                        if (count > 0)
                        {
                            string insertQuery = @"
                                                MERGE INTO [dbo].[User_SmartSell] AS Target
                                                USING (
                                                    SELECT
                                                        @Company_ID AS Company_ID,
                                                        @Capital AS Capital,
                                                        @Days AS Days,
                                                        @Average_Price AS Average_Price,
                                                        @Population AS Population,
                                                        @Percent_Population AS Percent_Population,
                                                        @Target_Market AS Target_Market,
                                                        @Daily_Target AS Daily_Target,
                                                        @Sales_Per_Day AS Sales_Per_Day,
                                                        @Monthly_Sales AS Monthly_Sales,
                                                        @Salary_Per_Day AS Salary_Per_Day,
                                                        @Monthly_Salary AS Monthly_Salary,
                                                        @Monthly_Expenses AS Monthly_Expenses,
                                                        @Total_Expenses AS Total_Expenses,
                                                        @Net_Profit AS Net_Profit,
                                                        @Return_Investment AS Return_Investment,
                                                        @Roi_Prediction AS Roi_Prediction
                                                ) AS Source
                                                ON Target.[Company_ID] = Source.Company_ID
                                                WHEN MATCHED THEN
                                                    UPDATE SET
                                                        Target.[Capital] = Source.Capital,
                                                        Target.[Days] = Source.Days,
                                                        Target.[Average_Price] = Source.Average_Price,
                                                        Target.[Population] = Source.Population,
                                                        Target.[Percent_Population] = Source.Percent_Population,
                                                        Target.[Target_Market] = Source.Target_Market,
                                                        Target.[Daily_Target] = Source.Daily_Target,
                                                        Target.[Sales_Per_Day] = Source.Sales_Per_Day,
                                                        Target.[Monthly_Sales] = Source.Monthly_Sales,
                                                        Target.[Salary_Per_Day] = Source.Salary_Per_Day,
                                                        Target.[Monthly_Salary] = Source.Monthly_Salary,
                                                        Target.[Monthly_Expenses] = Source.Monthly_Expenses,
                                                        Target.[Total_Expenses] = Source.Total_Expenses,
                                                        Target.[Net_Profit] = Source.Net_Profit,
                                                        Target.[Return_Investment] = Source.Return_Investment,
                                                        Target.[Roi_Prediction] = Source.Roi_Prediction
                                                WHEN NOT MATCHED THEN
                                                    INSERT (
                                                        [Company_ID],
                                                        [Capital],
                                                        [Days],
                                                        [Average_Price],
                                                        [Population],
                                                        [Percent_Population],
                                                        [Target_Market],
                                                        [Daily_Target],
                                                        [Sales_Per_Day],
                                                        [Monthly_Sales],
                                                        [Salary_Per_Day],
                                                        [Monthly_Salary],
                                                        [Monthly_Expenses],
                                                        [Total_Expenses],
                                                        [Net_Profit],
                                                        [Return_Investment],
                                                        [Roi_Prediction]
                                                    )
                                                    VALUES (
                                                        Source.Company_ID,
                                                        Source.Capital,
                                                        Source.Days,
                                                        Source.Average_Price,
                                                        Source.Population,
                                                        Source.Percent_Population,
                                                        Source.Target_Market,
                                                        Source.Daily_Target,
                                                        Source.Sales_Per_Day,
                                                        Source.Monthly_Sales,
                                                        Source.Salary_Per_Day,
                                                        Source.Monthly_Salary,
                                                        Source.Monthly_Expenses,
                                                        Source.Total_Expenses,
                                                        Source.Net_Profit,
                                                        Source.Return_Investment,
                                                        Source.Roi_Prediction
                                                    );";


                            using (SqlCommand obj_Insert_Db = new SqlCommand(insertQuery, obj_Connect_Db))
                            {
                                // N: Using this method for prevention of SQL Injection
                                obj_Insert_Db.Parameters.AddWithValue("@Company_ID", companyID);
                                obj_Insert_Db.Parameters.AddWithValue("@Capital", capital);
                                obj_Insert_Db.Parameters.AddWithValue("@Days", days);
                                obj_Insert_Db.Parameters.AddWithValue("@Average_Price", averagePrice);
                                obj_Insert_Db.Parameters.AddWithValue("@Population", population);
                                obj_Insert_Db.Parameters.AddWithValue("@Percent_Population", percentPopulation);
                                obj_Insert_Db.Parameters.AddWithValue("@Target_Market", targetMarket);
                                obj_Insert_Db.Parameters.AddWithValue("@Daily_Target", dailyTarget);
                                obj_Insert_Db.Parameters.AddWithValue("@Sales_Per_Day", salesPerDay);
                                obj_Insert_Db.Parameters.AddWithValue("@Monthly_Sales", monthlySales);
                                obj_Insert_Db.Parameters.AddWithValue("@Salary_Per_Day", salaryPerDay);
                                obj_Insert_Db.Parameters.AddWithValue("@Monthly_Salary", monthlySalary);
                                obj_Insert_Db.Parameters.AddWithValue("@Monthly_Expenses", monthlyExpenses);
                                obj_Insert_Db.Parameters.AddWithValue("@Total_Expenses", totalExpenses);
                                obj_Insert_Db.Parameters.AddWithValue("@Net_Profit", netProfit);
                                obj_Insert_Db.Parameters.AddWithValue("@Return_Investment", returnInvestment);
                                obj_Insert_Db.Parameters.AddWithValue("@Roi_Prediction", roiPrediction);

                                // N: Executing Query to Insert in Database
                                obj_Insert_Db.ExecuteNonQuery();
                            }
                        }
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