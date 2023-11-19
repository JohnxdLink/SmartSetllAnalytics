using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartSetll_Analytics_V2.classes
{
    public class GetSetValues
    {
        private int capital = 0; // ! Capital Private Field

        // ? Get Set Capital
        public int Capital
        {
            get { return capital; }
            set { capital = value; }
        }

        private int days = 0;  // ! Number of Days Private Field

        // ? Get Set Days
        public int Days
        {
            get { return days; }
            set { days = value; }
        }

        private double averagePrice = 0;  // ! Average Price Private Field

        // ? Get Set Average Price
        public double AveragePrice
        {
            get { return averagePrice; }
            set { averagePrice = value; }
        }

        private int population = 0;  // ! Population Private Field

        // ? Get Set Population
        public int Population
        {
            get { return population; }
            set { population = value; }
        }

        private double percentPopulation = 0;  // ! Percent Population Private Field

        // ? Get Set Percent Population
        public double PercentPopulation
        {
            get { return percentPopulation; }
            set { percentPopulation = value; }
        }

        private double targetMarket = 0;  // ! Target Market Private Field

        // ? Get Set Target Market
        public double TargetMarket
        {
            get { return targetMarket; }
            set { targetMarket = value; }
        }

        private int dailyTarget = 0;  // ! Daily Target Market Private Field

        // ? Get Set Daily Target
        public int DailyTarget
        {
            get { return dailyTarget; }
            set { dailyTarget = value; }
        }

        private double salesPerDay = 0;  // ! Sales Per Day Private Field

        // ? Get Set Sales Per Day
        public double SalesPerDay
        {
            get { return salesPerDay; }
            set { salesPerDay = value; }
        }

        private double monthlySales = 0;  // ! Monthly Sales Private Field

        // ? Get Set Monthly Sales
        public double MonthlySales
        {
            get { return monthlySales; }
            set { monthlySales = value; }
        }

        private double salaryPerDay = 0;  // ! Salary Per Day Private Field

        // ? Get Set Salary Per Day
        public double SalaryPerDay
        {
            get { return salaryPerDay; }
            set { salaryPerDay = value; }
        }

        private double monthlySalary = 0;  // ! Monthly Salary Private Field

        // ? Get Set Monthly Salary
        public double MonthlySalary
        {
            get { return monthlySalary; }
            set { monthlySalary = value; }
        }

        private double monthlyExpenses = 0;  // ! Monthly Expenses Private Field

        // ? Get Set Monthly Expenses
        public double MonthlyExpenses
        {
            get { return monthlyExpenses; }
            set { monthlyExpenses = value; }
        }

        private double totalExpenses = 0;  // ! Total Expenses Private Field

        // ? Get Set Total Expenses
        public double TotalExpenses
        {
            get { return totalExpenses; }
            set { totalExpenses = value; }
        }

        private double netProfit = 0;  // ! Net Profit Private Field

        // ? Get Set Net Profit
        public double NetProfit
        {
            get { return netProfit; }
            set { netProfit = value; }
        }

        private double returnInvestment = 0;  // ! Return of Investment Private Field

        // ? Get Set Return of Investment
        public double ReturnInvestMent
        {
            get { return returnInvestment; }
            set { returnInvestment = value; }
        }

        private double roiPrediction = 0;  // ! ROI Prediction Private Field

        // ? Get Set ROI Prediction
        public double RoiPrediction
        {
            get { return roiPrediction; }
            set { roiPrediction = value; }
        }

    }
}