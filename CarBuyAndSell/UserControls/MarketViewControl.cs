using CarBuyAndSell.Cards;
using CarBuyAndSell.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarBuyAndSell
{
    public partial class MarketViewControl : UserControl
    {
        GlobalProcedure globalProcedure = new GlobalProcedure();
        private List<ListingDto> listings = new List<ListingDto>();
        private int totalRecords = 0;
        private int currentPage = 1;
        private const int carsPerPage = 10;
        private bool initial = true;

        public MarketViewControl()
        {
            InitializeComponent();
            initial = true;
            if (!this.globalProcedure.FncConnectToDatabase())
                MessageBox.Show("Not Connected");

            listings = globalProcedure.ProcGetListings(currentPage, carsPerPage, true);
            totalRecords = globalProcedure.ProcCountVehicles(searchBox.Text.ToLower());
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
            SearchMarketListings();
        }

        private void SearchMarketListings()
        {
            string searchQuery = searchBox.Text.ToLower();
            if (initial) searchQuery = "";
            List<ListingDto> filteredCars = globalProcedure.ProcSearchListings(searchQuery, currentPage, carsPerPage);
            if (filteredCars.Count > 0)
            {
                listings = filteredCars;
                DisplayListings();
            }
            else
            {
                MessageBox.Show("No cars found matching your search.");
            }
        }

        private void DisplayListings()
        {
            flwMarket.Controls.Clear();

            if (listings.Count > 0)
            {
                for (int i = 0; i < listings.Count; i++)
                {
                    var listing = listings[i];
                    ListingCardView cardPanel = new ListingCardView(listing);
                    // Add the card to the grid
                    flwMarket.Controls.Add(cardPanel);
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

        private void BtnAddVehicle_Click(object sender, EventArgs e)
        {

        }

        private void UpdatePaginationButtons()
        {
            int totalPages = (totalRecords + carsPerPage - 1) / carsPerPage;

            prevPageBtn.Enabled = currentPage > 1;
            firstPageBtn.Enabled = currentPage > 1;
            nextPageBtn.Enabled = currentPage < totalPages;
            lastPageBtn.Enabled = currentPage < totalPages;

            pageLabel.Text = $"Page {currentPage} of {totalPages}";
            // pageSelector.Maximum = totalPages;
            //pageSelector.Value = currentPage;
        }

        private void FirstPageBtn_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            SearchMarketListings();
        }

        private void PrevPageBtn_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                SearchMarketListings();
            }
        }

        private void NextPageBtn_Click(object sender, EventArgs e)
        {
            int totalPages = (totalRecords + carsPerPage - 1) / carsPerPage;
            if (currentPage < totalPages)
            {
                currentPage++;
                SearchMarketListings();
            }
        }

        private void LastPageBtn_Click(object sender, EventArgs e)
        {
            currentPage = (totalRecords + carsPerPage - 1) / carsPerPage;
            SearchMarketListings();
        }

        private Image LoadCarImage(string imagePath)
        {
            if (File.Exists(imagePath))
            {
                return Image.FromFile(imagePath);
            }
            else
            {
                // Return a default image if no image is found
                return Properties.Resources.DefaultVehicleImage;
            }
        }
    }
}
