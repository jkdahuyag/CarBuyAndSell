﻿using CarBuyAndSell.Dto;
using CarBuyAndSell.Models;
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

namespace CarBuyAndSell
{
    public partial class BidsViewControl : UserControl
    {
        GlobalProcedure globalProcedure = new GlobalProcedure();
        private bool initial = false;
        private List<BidDto> bids = new List<BidDto>();
        private int currentPage = 1;
        private const int rowsPerPage = 10;
        private int totalRecords = 0;

        public BidsViewControl()
        {
            InitializeComponent();
            initial = true;
            if (!this.globalProcedure.FncConnectToDatabase())
                MessageBox.Show("Not Connected");

            bids = globalProcedure.ProcGetBids(currentPage, rowsPerPage);
            totalRecords = globalProcedure.ProcCountBids(searchBox.Text.ToLower());
            SetPlaceholder();
            searchBox.Enter += RemovePlaceholder;
            searchBox.Leave += SetPlaceholder;
            searchButton.Click += SearchButton_Click;
            prevPageBtn.Click += PrevPageBtn_Click;
            nextPageBtn.Click += NextPageBtn_Click;
            firstPageBtn.Click += FirstPageBtn_Click;
            lastPageBtn.Click += LastPageBtn_Click;

            DisplayCars();
        }

        private void DisplayCars()
        {
            pnlBids.Controls.Clear();

            if (bids.Count > 0)
            {
                for (int i = bids.Count - 1; i >= 0; i--)
                {
                    var bid = bids[i];
                    BidDataRowInstance panel = new BidDataRowInstance(bid);
                    panel.Dock = DockStyle.Top;

                    pnlBids.Controls.Add(panel);
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
            int totalPages = (bids.Count + rowsPerPage - 1) / rowsPerPage;

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
                initial = true;
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
            List<BidDto> filteredBids = globalProcedure.ProcSearchBids(searchQuery, currentPage, rowsPerPage);
            if (filteredBids.Count > 0)
            {
                bids = filteredBids;
                DisplayCars();
            }
            else
            {
                MessageBox.Show("No cars found matching your search.");
            }
        }

        private void FirstPageBtn_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            DisplayCars();
        }

        private void PrevPageBtn_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                DisplayCars();
            }
        }

        private void NextPageBtn_Click(object sender, EventArgs e)
        {
            int totalPages = (bids.Count + rowsPerPage - 1) / rowsPerPage;
            if (currentPage < totalPages)
            {
                currentPage++;
                DisplayCars();
            }
        }

        private void LastPageBtn_Click(object sender, EventArgs e)
        {
            currentPage = (bids.Count + rowsPerPage - 1) / rowsPerPage;
            DisplayCars();
        }

        private void SellButton_Click(object sender, EventArgs e)
        {
            // Open the Sell Form
            //SellForm sellForm = new SellForm();
            //sellForm.ShowDialog();
        }
    }
}
