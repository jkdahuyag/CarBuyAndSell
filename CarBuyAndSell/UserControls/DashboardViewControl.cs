using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarBuyAndSell
{
    public partial class DashboardViewControl : UserControl
    {
        private Label totalCarsBeingSoldLabel, totalCarsSoldLabel, avgProfitLabel, numUsersLabel;
        private DataGridView monthlySalesTable;
        private GlobalProcedure globalProcedure = new GlobalProcedure();

        public DashboardViewControl()
        {
            InitializeComponent();
            if (!globalProcedure.FncConnectToDatabase())
            {
                MessageBox.Show("Not Connected");
            }
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            // Load the main statistics
            int totalVehicles = globalProcedure.ProcCountVehicles("");
            int numberOfUsers = globalProcedure.ProcCountUsers("");
            int totalBrands = globalProcedure.ProcCountBrands();
            double totalEarnings = globalProcedure.ProcGetTotalEarnings();

            // Update labels with data
            lblTotalVehicles.Text = totalVehicles.ToString();
            lblTotalUsers.Text = numberOfUsers.ToString();
            lblTotalBrands.Text = totalBrands.ToString();
            lblTotalPlatformEarnings.Text = totalEarnings.ToString("C");

            // Load the monthly sales data
            LoadMonthlySalesData();
        }

        private void LoadMonthlySalesData()
        {
            Dictionary<DateTime, double> monthlyEarnings = globalProcedure.ProcGetEarningsPerMonth();
            Dictionary<DateTime, double> monthlyTransactions = globalProcedure.ProcGetTransactionsPerMonth();
            List<BrandDistribution> brands = globalProcedure.ProcGetBrandDistribution();
            chrtEarningsPerMonth.Series = new ISeries[]
            {
                new LineSeries<double>
                {
                    Values = monthlyEarnings.Values
                }
            };
            chrtTransactionsPerMonth.Series = new ISeries[]
            {
                new ColumnSeries<double>
                {
                    Values = monthlyTransactions.Values
                }
            };
            chrtEarningsPerMonth.XAxes = new[] 
            { 
                new Axis 
                { 
                    Labels = monthlyEarnings.Keys.Select(x => x.ToString("MM-yyyy")).ToArray(),
                } 
            };
            chrtTransactionsPerMonth.XAxes = new[] 
            {
                new Axis 
                { 
                    Labels = monthlyTransactions.Keys.Select(x => x.ToString("MM-yyyy")).ToArray() 
                } 
            };
            chrtEarningsPerMonth.YAxes = new[]
            { 
                new Axis
                {
                    Name = "Earnings",
                    Labeler = value => value.ToString("C")
                } 
            };
            chrtTransactionsPerMonth.YAxes = new[]
            { 
                new Axis
                {
                    Name = "Transactions",
                    Labeler = value => value.ToString()
                } 
            };

        }

    }
}