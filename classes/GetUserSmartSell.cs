using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace SmartSetll_Analytics_V2.classes
{
    public class GetUserSmartSell
    {
        // N: SqlConnection String and Connect Database
        string sqlConnect = "Data Source=ECCLESIASTES\\SQLEXPRESS;Initial Catalog=SmartSell_Db;User ID=ustyroid;Password=2315";
        string connectDatabase = "SmartSell_Db";

        public void RetrieveUserSmartSellData(int companyID, Label capitalLabel, Label numDaysLabel, Label averagePriceLabel, Label populationLabel, Label percentPopulationLabel, Label targetMarketLabel, Label dailyTargetLabel, Label salesPerDayLabel, Label monthlySalesLabel, Label salaryPerDayLabel, Label monthlySalaryLabel, Label monthlyExpensesLabel, Label totalExpensesLabel, Label netProfitLabel, Label returnInvestmentLabel, Label roiPredictionLabel)
        {
            try
            {
                using (SqlConnection obj_Connect_Db = new SqlConnection(sqlConnect))
                {
                    obj_Connect_Db.Open();
                    obj_Connect_Db.ChangeDatabase(connectDatabase);

                    string selectQuery = @" SELECT [Capital], [Days], [Average_Price], [Population], [Percent_Population], [Target_Market], [Daily_Target], [Sales_Per_Day], [Monthly_Sales], [Salary_Per_Day], [Monthly_Salary], [Monthly_Expenses], [Total_Expenses], [Net_Profit], [Return_Investment], [Roi_Prediction] FROM [dbo].[User_SmartSell] WHERE Company_ID = @Company_ID";

                    using (SqlCommand obj_Command_Db = new SqlCommand(selectQuery, obj_Connect_Db))
                    {
                        obj_Command_Db.Parameters.AddWithValue("@Company_ID", companyID);

                        using (SqlDataReader obj_DataReader_Db = obj_Command_Db.ExecuteReader())
                        {
                            if (obj_DataReader_Db.Read())
                            {
                                capitalLabel.Text = obj_DataReader_Db["Capital"].ToString();
                                numDaysLabel.Text = obj_DataReader_Db["Days"].ToString();
                                averagePriceLabel.Text = obj_DataReader_Db["Average_Price"].ToString();
                                populationLabel.Text = obj_DataReader_Db["Population"].ToString();
                                percentPopulationLabel.Text = obj_DataReader_Db["Percent_Population"].ToString();
                                targetMarketLabel.Text = obj_DataReader_Db["Target_Market"].ToString();
                                dailyTargetLabel.Text = obj_DataReader_Db["Daily_Target"].ToString();
                                salesPerDayLabel.Text = obj_DataReader_Db["Sales_Per_Day"].ToString();
                                monthlySalesLabel.Text = obj_DataReader_Db["Monthly_Sales"].ToString();
                                salaryPerDayLabel.Text = obj_DataReader_Db["Salary_Per_Day"].ToString();
                                monthlySalaryLabel.Text = obj_DataReader_Db["Monthly_Salary"].ToString();
                                monthlyExpensesLabel.Text = obj_DataReader_Db["Monthly_Expenses"].ToString();
                                totalExpensesLabel.Text = obj_DataReader_Db["Total_Expenses"].ToString();
                                netProfitLabel.Text = obj_DataReader_Db["Net_Profit"].ToString();
                                returnInvestmentLabel.Text = obj_DataReader_Db["Return_Investment"].ToString();
                                roiPredictionLabel.Text = obj_DataReader_Db["Roi_Prediction"].ToString();
                            }
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine(sqlEx);
                // Handle the exception as needed
            }
        }

    }
}