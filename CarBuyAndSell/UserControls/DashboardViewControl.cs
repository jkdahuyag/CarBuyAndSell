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

        public DashboardViewControl()
        {
            InitializeComponent();
            LoadDashboardData();
        }

        private void InitializeMonthlySalesTable()
        {
            // Create a table with months and sales
            monthlySalesTable.ColumnCount = 2;
            monthlySalesTable.Columns[0].Name = "Month";
            monthlySalesTable.Columns[1].Name = "Sales";
            monthlySalesTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            monthlySalesTable.AllowUserToAddRows = false;

            // Load dummy data for now, real data would be fetched from a database
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            for (int i = 0; i < months.Length; i++)
            {
                monthlySalesTable.Rows.Add(months[i], 0); // Placeholder sales values (set to 0 initially)
            }
        }

        private void LoadDashboardData()
        {
            // Load the main statistics
            int totalCarsBeingSold = GetTotalCarsBeingSold();
            int totalCarsSold = GetTotalCarsSold();
            decimal averageProfit = GetAverageProfit();
            int numberOfUsers = GetNumberOfUsers();

            // Update labels with data
            totalCarsBeingSoldLabel.Text = totalCarsBeingSold.ToString();
            totalCarsSoldLabel.Text = totalCarsSold.ToString();
            avgProfitLabel.Text = $"${averageProfit:F2}";
            numUsersLabel.Text = numberOfUsers.ToString();

            // Load the monthly sales data
            LoadMonthlySalesData();
        }

        private void LoadMonthlySalesData()
        {
            chrtTransactionsAndEarningsPerMonth.Series = new ISeries[]
           {
                new LineSeries<double>
                {
                    Values = new double[] { 2, 1, 3, 5, 3, 4, 6 },
                    Fill = null
                }
           };
            // Replace with actual logic to get sales per month
            int[] sales = GetSalesForEachMonth();

            // Update the table with sales data
            for (int i = 0; i < sales.Length; i++)
            {
                monthlySalesTable.Rows[i].Cells[1].Value = sales[i];
            }
        }

        private int GetTotalCarsBeingSold()
        {
            // Replace with actual logic to get the total cars being sold
            return 50;
        }

        private int GetTotalCarsSold()
        {
            // Replace with actual logic to get the total cars sold
            return 100;
        }

        private decimal GetAverageProfit()
        {
            // Replace with actual logic to calculate the average profit
            return 2500.75M;
        }

        private int GetNumberOfUsers()
        {
            // Replace with actual logic to get the total number of users
            return 200;
        }

        private int[] GetSalesForEachMonth()
        {
            // Replace this with actual data retrieval from your database
            return new int[] { 5, 10, 7, 12, 9, 15, 8, 11, 6, 14, 9, 10 };
        }
    }
}