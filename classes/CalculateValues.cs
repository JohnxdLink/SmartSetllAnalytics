using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartSetll_Analytics_V2.classes
{
    public class CalculateValues : GetSetValues
    {
        const int HUNDREDPERCENT = 100;
        
        public double Calculate_TargetMarket(int population, double percentPopulation)
        {
            return TargetMarket = population * (percentPopulation / HUNDREDPERCENT);
        }

        public double Calculate_DailyTarget(double targetMarket, int days)
        {
            return DailyTarget = (int)(targetMarket / days);
        }

        public double Calculate_Sales_PerDay(double dailyTarget, double averagePrice)
        {
            return SalesPerDay = dailyTarget * averagePrice;
        }

        public double Calculate_Monthly_Sales(double salesPerDay, int days)
        {
            return MonthlySales = salesPerDay * days;
        }

        public double Calculate_MonthlySalary(double salaryPerDay, int days)
        {
            return MonthlySalary = salaryPerDay * days;
        }

        public double Calculate_TotalExpenses(double monthlyExpenses, double monthlysalary)
        {
            return TotalExpenses = monthlyExpenses + monthlysalary;
        }

        public double Calculate_NetProfit(double monthlySales, double totalExpenses)
        {
            return NetProfit = monthlySales - totalExpenses;
        }
    }
}