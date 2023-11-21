using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartSetll_Analytics_V2.classes
{
    public class CalculateValues : GetSetValues
    {
        // N: Constant Value Hundred Percent
        const int HUNDREDPERCENT = 100;

        // ? Calculate TargetMarket Method and its parameters population and percenPopulation
        public double Calculate_TargetMarket(int population, double percentPopulation)
        {
            // N: From GetSetValues setting the TargetMarket Value
            return TargetMarket = population * (percentPopulation / HUNDREDPERCENT);
        }

        // ? Calculate DailyTarget Method and its parameters targetMarket and days
        public double Calculate_DailyTarget(double targetMarket, int days)
        {
            // N: From GetSetValues setting the DailyTarget Value
            return DailyTarget = (int)(targetMarket / days);
        }

        // ? Caclcultae Sales Per Day and its parameters dailyTarget and averagePrice
        public double Calculate_Sales_PerDay(double dailyTarget, double averagePrice)
        {
            // N: From GetSetValues setting the SalesPerDay Value
            return SalesPerDay = dailyTarget * averagePrice;
        }

        // ? Calculate Monthly Sales and its parameters salesPerDay and days
        public double Calculate_Monthly_Sales(double salesPerDay, int days)
        {
            // N: From GetSetValues setting the MonthlySales Value
            return MonthlySales = salesPerDay * days;
        }

        // ? Calculate MonthlySalary and its parameters salaryPerDay and days
        public double Calculate_MonthlySalary(double salaryPerDay, int days)
        {
            // N: From GetSetValue setting the MonthlySalary Value
            return MonthlySalary = salaryPerDay * days;
        }

        // ? Calculate Total Expenses and its parameters monthlyExpenses and monthlySalary
        public double Calculate_TotalExpenses(double monthlyExpenses, double monthlysalary)
        {
            // N: From GetSetValue setting the TotalExpenses Value
            return TotalExpenses = monthlyExpenses + monthlysalary;
        }

        // ? Calculate Net Profit and its parameters monthlyExpenses and totalExpenses
        public double Calculate_NetProfit(double monthlySales, double totalExpenses)
        {
            // N: From GetSetValue setting the NetProfit Value
            return NetProfit = monthlySales - totalExpenses;
        }

        // ? Calculate ROI and its parameters netProfit and capital
        public double Calculate_Roi(int netProfit, double capital)
        {
            // N: From GetSetValue setting the ReturnInvestMent Value
            return ReturnInvestMent = (netProfit / capital) * HUNDREDPERCENT;
        }

        // ? Calculate ROI Prediction and its parameters monthlySales and netProfit
        public double Calculate_Roi_Prediction(double monthlySales, double netProfit)
        {
            // n: From GetSetValue setting the RoiPrediction Value
            return RoiPrediction = monthlySales / netProfit;
        }
    }
}