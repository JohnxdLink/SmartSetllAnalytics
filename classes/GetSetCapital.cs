using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

namespace SmartSetll_Analytics_V2.classes
{
    public class GetSetCapital
    {
        // N: SqlConnection String and Connect Database
        string sqlConnect = "Data Source=ECCLESIASTES\\SQLEXPRESS;Initial Catalog=SmartSell_Db;User ID=ustyroid;Password=2315";
        string connectDatabase = "SmartSell_Db";

        public void Insert_Capital(int companyID, int quantity, string itemName, double itemPrice)
        {
            try
            {
                using (SqlConnection obj_Connect_Db = new SqlConnection(sqlConnect))
                {
                    // N: Instanstiating Connection Database to Open
                    obj_Connect_Db.Open();
                    obj_Connect_Db.ChangeDatabase(connectDatabase);

                    string insertQuery = @"INSERT INTO [dbo].[User_Capital_Items] ([Company_ID], [Item_Qty], [Item_Name], [Item_Price]) VALUES (@Company_ID, @Item_Qty, @Item_Name, @Item_Price)";

                    using (SqlCommand obj_Command_Db = new SqlCommand(insertQuery, obj_Connect_Db))
                    {
                        obj_Command_Db.Parameters.AddWithValue("@Company_ID", companyID);
                        obj_Command_Db.Parameters.AddWithValue("@Item_Qty", quantity);
                        obj_Command_Db.Parameters.AddWithValue("@Item_Name", itemName);
                        obj_Command_Db.Parameters.AddWithValue("@Item_Price", itemPrice);

                        obj_Command_Db.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine(sqlEx);
            }
        }

        public DataTable Get_Capital(int companyID)
        {
            DataTable obj_DataCapital = new DataTable();
            try
            {
                using (SqlConnection obj_Connect_Db = new SqlConnection(sqlConnect))
                {
                    // N: Instanstiating Connection Database to Open
                    obj_Connect_Db.Open();
                    obj_Connect_Db.ChangeDatabase(connectDatabase);

                    string readQuery = @"SELECT [Item_Qty], [Item_Name], [Item_Price] FROM [dbo].[User_Capital_Items] WHERE [Company_ID] = @Company_ID";

                    using (SqlCommand obj_Command_Db = new SqlCommand(readQuery, obj_Connect_Db))
                    {
                        obj_Command_Db.Parameters.AddWithValue("@Company_ID", companyID);

                        using (SqlDataReader obj_DataReader_Db = obj_Command_Db.ExecuteReader())
                        {
                            if (obj_DataReader_Db.Read())
                            {
                                obj_DataCapital.Load(obj_DataReader_Db);
                            }
                        }

                    }
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine(sqlEx);
            }

            return obj_DataCapital;
        }

        public void Insert_RealTime_Month(int companyID, string month, double rlMonthlySales, double rlMonthlySalary, double rlMonthlyExpenses, double rlTotalExpenses, double rlNetProfit, double rlRoi, double rlRoiPrediction)
        {
            try
            {
                using (SqlConnection obj_Connect_Db = new SqlConnection(sqlConnect))
                {
                    // N: Instanstiating Connection Database to Open
                    obj_Connect_Db.Open();
                    obj_Connect_Db.ChangeDatabase(connectDatabase);

                    string insertQuery = @"INSERT INTO [dbo].[User_RealTime_SmartSell] ([Company_ID], [Month_SmartSell], [Monthly_Sales], [Monthly_Salary], [Monthly_Expenses], [Total_Expenses], [Net_Profit], [Return_Investment], [Roi_Prediction]) VALUES (@Company_ID, @Month_SmartSell, @Monthly_Sales, @Monthly_Salary, @Monthly_Expenses, @Total_Expenses, @Net_Profit, @Return_Investment, @Roi_Prediction)";

                    using (SqlCommand obj_Command_Db = new SqlCommand(insertQuery, obj_Connect_Db))
                    {
                        obj_Command_Db.Parameters.AddWithValue("@Company_ID", companyID);
                        obj_Command_Db.Parameters.AddWithValue("@Month_SmartSell", month);
                        obj_Command_Db.Parameters.AddWithValue("@Monthly_Sales", rlMonthlySales);
                        obj_Command_Db.Parameters.AddWithValue("@Monthly_Salary", rlMonthlySalary);
                        obj_Command_Db.Parameters.AddWithValue("@Monthly_Expenses", rlMonthlyExpenses);
                        obj_Command_Db.Parameters.AddWithValue("@Total_Expenses", rlTotalExpenses);
                        obj_Command_Db.Parameters.AddWithValue("@Net_Profit", rlNetProfit);
                        obj_Command_Db.Parameters.AddWithValue("@Return_Investment", rlRoi);
                        obj_Command_Db.Parameters.AddWithValue("@Roi_Prediction", rlRoiPrediction);

                        obj_Command_Db.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                // Specify the correct relative path from the application root
                string errorLogPath = HttpContext.Current.Server.MapPath("~/resources/errorlogs/errorlog.txt");

                using (StreamWriter writer = new StreamWriter(errorLogPath, true))
                {
                    writer.WriteLine($"Timestamp: {DateTime.Now}");
                    writer.WriteLine($"Error Message:\n{sqlEx.Message}");
                    writer.WriteLine($"StackTrace:\n{sqlEx.StackTrace}");
                    writer.WriteLine(new string('-', 50));
                }
            }
        }


    }
}