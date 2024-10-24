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
    public partial class ListingViewControl : UserControl
    {
        GlobalProcedure globalProcedure = new GlobalProcedure();
        private bool initial = false;
        private List<ListingDto> listings = new List<ListingDto>();
        private int currentPage = 1;
        private const int rowsPerPage = 10;
        private int totalRecords = 0;

        public ListingViewControl()
        {
            InitializeComponent();
            initial = true;
            if (!this.globalProcedure.FncConnectToDatabase())
                MessageBox.Show("Not Connected");

            listings = globalProcedure.ProcGetListings(currentPage, rowsPerPage, false);
            totalRecords = globalProcedure.ProcCountListings(searchBox.Text.ToLower(), false);
            SetPlaceholder();
            searchBox.Enter += RemovePlaceholder;
            searchBox.Leave += SetPlaceholder;
            searchButton.Click += SearchButton_Click;
            prevPageBtn.Click += PrevPageBtn_Click;
            nextPageBtn.Click += NextPageBtn_Click;
            firstPageBtn.Click += FirstPageBtn_Click;
            lastPageBtn.Click += LastPageBtn_Click;

            DisplayListings();
        }

        private void DisplayListings()
        {
            pnlListings.Controls.Clear();

            if (listings.Count > 0)
            {
                for (int i = listings.Count - 1; i >= 0; i--)
                {
                    var listing = listings[i];
                    ListingDataRowInstance panel = new ListingDataRowInstance(listing);
                    panel.Dock = DockStyle.Top;
                    // Add the card to the grid
                    pnlListings.Controls.Add(panel);
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
            int totalPages = (listings.Count + rowsPerPage - 1) / rowsPerPage;

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
            totalRecords = globalProcedure.ProcCountListings(searchQuery, false);
            SearchListings();
        }
        private void SearchListings()
        {
            string searchQuery = searchBox.Text.ToLower();
            if (initial) searchQuery = "";
            List<ListingDto> filteredListings = globalProcedure.ProcSearchListings(searchQuery, currentPage, rowsPerPage, false);
            if (filteredListings.Count > 0)
            {
                listings = filteredListings;
                DisplayListings();
            }
            else
            {
                MessageBox.Show("No listings found matching your search.");
            }
        }

        private void FirstPageBtn_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            DisplayListings();
        }

        private void PrevPageBtn_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                DisplayListings();
            }
        }

        private void NextPageBtn_Click(object sender, EventArgs e)
        {
            int totalPages = (listings.Count + rowsPerPage - 1) / rowsPerPage;
            if (currentPage < totalPages)
            {
                currentPage++;
                DisplayListings();
            }
        }

        private void LastPageBtn_Click(object sender, EventArgs e)
        {
            currentPage = (listings.Count + rowsPerPage - 1) / rowsPerPage;
            DisplayListings();
        }

        private void SellButton_Click(object sender, EventArgs e)
        {
            // Open the Sell Form
            //SellForm sellForm = new SellForm();
            //sellForm.ShowDialog();
        }
    }
}
