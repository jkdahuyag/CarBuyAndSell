using CarBuyAndSell.Cards;
using CarBuyAndSell.Dto;
using CarBuyAndSell.Row_Instance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarBuyAndSell.UserControls
{
    public partial class TransactionsViewControl : UserControl
    {
        GlobalProcedure globalProcedure = new GlobalProcedure();
        private bool initial = false;
        private List<TransactionDto> transactions = new List<TransactionDto>();
        private int currentPage = 1;
        private const int rowsPerPage = 10;
        private int totalRecords = 0;

        public TransactionsViewControl()
        {
            InitializeComponent();
            initial = true;
            if (!this.globalProcedure.FncConnectToDatabase())
                MessageBox.Show("Not Connected");

            transactions = globalProcedure.ProcGetTransactions(currentPage, rowsPerPage);
            totalRecords = globalProcedure.ProcCountTransactions(searchBox.Text.ToLower());
            SetPlaceholder();
            searchBox.Enter += RemovePlaceholder;
            searchBox.Leave += SetPlaceholder;
            searchButton.Click += SearchButton_Click;
            prevPageBtn.Click += PrevPageBtn_Click;
            nextPageBtn.Click += NextPageBtn_Click;
            firstPageBtn.Click += FirstPageBtn_Click;
            lastPageBtn.Click += LastPageBtn_Click;

            DisplayTransactions();
        }

        private void DisplayTransactions()
        {
            pnlTransactionsTable.Controls.Clear();

            if (transactions.Count > 0)
            {
                for (int i = transactions.Count - 1; i >= 0; i--)
                {
                    var transaction = transactions[i];
                    TransactionDataRowInstance transactionPanel = new TransactionDataRowInstance(transaction);
                    transactionPanel.Dock = DockStyle.Top;
                    // Add the card to the grid
                    pnlTransactionsTable.Controls.Add(transactionPanel);
                }
            }
            else
            {
                MessageBox.Show("Record not found!");
            }

            this.globalProcedure.sqlAdapter.Dispose();
            this.globalProcedure.datCarBuyAndSellMgr.Dispose();

            UpdatePaginationButtons();
        }

        private void UpdatePaginationButtons()
        {
            int totalPages = (transactions.Count + rowsPerPage - 1) / rowsPerPage;

            prevPageBtn.Enabled = currentPage > 1;
            firstPageBtn.Enabled = currentPage > 1;
            nextPageBtn.Enabled = currentPage < totalPages;
            lastPageBtn.Enabled = currentPage < totalPages;

            pageLabel.Text = $"Page {currentPage} of {totalPages}";
        }

        // Event handler to set the placeholder text
        private void SetPlaceholder(object sender = null, EventArgs e = null)
        {
            if (string.IsNullOrWhiteSpace(searchBox.Text))
            {
                searchBox.Text = "Search...";
                searchBox.ForeColor = Color.Gray;
            }
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            if (searchBox.Text == "Search...")
            {
                initial = false;
                searchBox.Text = "";
                searchBox.ForeColor = Color.Black;
            }
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            currentPage = 1; // Reset to the first page
            string searchQuery = searchBox.Text.ToLower();
            if (initial) searchQuery = "";
            totalRecords = globalProcedure.ProcCountVehicles(searchQuery);
            SearchTransactions();
        }
        private void SearchTransactions()
        {
            string searchQuery = searchBox.Text.ToLower();
            if (initial) searchQuery = "";
            List<TransactionDto> filteredTransactions = globalProcedure.ProcSearchTransactions(searchQuery, currentPage, rowsPerPage);
            if (filteredTransactions.Count > 0)
            {
                transactions = filteredTransactions;
                DisplayTransactions();
            }
            else
            {
                MessageBox.Show("No transaction found matching your search.");
            }
        }

        private void FirstPageBtn_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            DisplayTransactions();
        }

        private void PrevPageBtn_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                DisplayTransactions();
            }
        }

        private void NextPageBtn_Click(object sender, EventArgs e)
        {
            int totalPages = (transactions.Count + rowsPerPage - 1) / rowsPerPage;
            if (currentPage < totalPages)
            {
                currentPage++;
                DisplayTransactions();
            }
        }

        private void LastPageBtn_Click(object sender, EventArgs e)
        {
            currentPage = (transactions.Count + rowsPerPage - 1) / rowsPerPage;
            DisplayTransactions();
        }

        private void BtnMakeTransaction_Click(object sender, EventArgs e)
        {

        }
    }
}
