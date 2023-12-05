using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

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
                using(SqlConnection obj_Connect_Db = new SqlConnection(sqlConnect))
                {
                    // N: Instanstiating Connection Database to Open
                    obj_Connect_Db.Open();
                    obj_Connect_Db.ChangeDatabase(connectDatabase);

                    string insertQuery = @"INSERT INTO [dbo].[User_Capital_Items] ([Company_ID], [Item_Qty], [Item_Name], [Item_Price]) VALUES (@Company_ID, @Item_Qty, @Item_Name, @Item_Price)";

                    using(SqlCommand obj_Command_Db = new SqlCommand(insertQuery, obj_Connect_Db))
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
    }
}