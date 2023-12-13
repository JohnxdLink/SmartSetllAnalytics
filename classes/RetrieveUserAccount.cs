using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace SmartSetll_Analytics_V2.classes
{
    public class RetrieveUserAccount
    {
        // N: SqlConnection String and Connect Database
        string sqlConnect = "Data Source=ECCLESIASTES\\SQLEXPRESS;Initial Catalog=SmartSell_Db;User ID=ustyroid;Password=2315";
        string connectDatabase = "SmartSell_Db";

        // ! Need description about this Tuple Object
        public Tuple<bool, int, string> Retrieve_User_Account(string username, string password)
        {
            try
            {
                using (SqlConnection obj_Connect_Db = new SqlConnection(sqlConnect))
                {
                    obj_Connect_Db.Open();
                    obj_Connect_Db.ChangeDatabase(connectDatabase);

                    string selectQuery = @"SELECT COUNT(*) FROM [dbo].[Registered_Account] WHERE Username = @Username AND Password = @Password";

                    using (SqlCommand obj_Command_db = new SqlCommand(selectQuery, obj_Connect_Db))
                    {
                        obj_Command_db.Parameters.AddWithValue("@Username", username);
                        obj_Command_db.Parameters.AddWithValue("@Password", password);

                        int count = (int)obj_Command_db.ExecuteScalar();

                        if (count > 0)
                        {
                            // N: Retrieve Company_ID and Company_Name
                            string retrieveCompanyInfoQuery = @"SELECT Company_ID, Company_Name FROM [dbo].[Registered_Account] WHERE Username = @Username";
                            using (SqlCommand obj_Retrieve_Command_Db = new SqlCommand(retrieveCompanyInfoQuery, obj_Connect_Db))
                            {
                                obj_Retrieve_Command_Db.Parameters.AddWithValue("@Username", username);
                                SqlDataReader reader = obj_Retrieve_Command_Db.ExecuteReader();

                                if (reader.Read())
                                {
                                    int companyId = reader.GetInt32(0);
                                    string companyName = reader.GetString(1);

                                    return new Tuple<bool, int, string>(true, companyId, companyName);
                                }
                            }
                        }

                        return new Tuple<bool, int, string>(false, 0, string.Empty);
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                // N: Log the exception using your custom exception class
                ExceptionLogger.LogCustomException(sqlEx, "Custom Error Message");

                return new Tuple<bool, int, string>(false, 0, string.Empty);
            }
        }
    }
}