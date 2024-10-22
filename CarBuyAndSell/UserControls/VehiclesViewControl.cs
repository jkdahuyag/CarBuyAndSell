using CarBuyAndSell.Cards;
using CarBuyAndSell.Dto;
using CarBuyAndSell.Forms;
using CarBuyAndSell.Models;
using MySql.Data.MySqlClient;
using ReaLTaiizor;
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
    public partial class VehiclesViewControl : UserControl
    {
        GlobalProcedure globalProcedure = new GlobalProcedure();
        private List<VehicleDto> cars = new List<VehicleDto>();
        private int totalRecords = 0;
        private int currentPage = 1;
        private const int carsPerPage = 10;
        private bool initial = true;

        public VehiclesViewControl()
        {
            InitializeComponent();
            initial = true;
            if (!this.globalProcedure.FncConnectToDatabase())
                MessageBox.Show("Not Connected");

            cars = globalProcedure.ProcGetVehicles(currentPage, carsPerPage);
            totalRecords = globalProcedure.ProcCountVehicles(searchBox.Text.ToLower());
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
            SearchCars();
        }

        private void SearchCars()
        {
            string searchQuery = searchBox.Text.ToLower();
            if(initial) searchQuery = "";
            List<VehicleDto> filteredCars = globalProcedure.ProcSearchVehicles(searchQuery, currentPage, carsPerPage);
            if (filteredCars.Count > 0)
            {
                cars = filteredCars;
                DisplayCars();
            }
            else
            {
                MessageBox.Show("No cars found matching your search.");
            }
        } 

        private void DisplayCars()
        {
            flwVehicles.Controls.Clear();

            if (cars.Count > 0)
            {
                for (int i = 0; i < cars.Count; i++)
                {
                    var car = cars[i];
                    VehicleCardView cardPanel = new VehicleCardView(car);
                    // Add the card to the grid
                    flwVehicles.Controls.Add(cardPanel);
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
            VehicleForm form = new VehicleForm(null);
            form.ShowDialog();
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
            SearchCars();
        }

        private void PrevPageBtn_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                SearchCars();
            }
        }

        private void NextPageBtn_Click(object sender, EventArgs e)
        {
            int totalPages = (totalRecords + carsPerPage - 1) / carsPerPage;
            if (currentPage < totalPages)
            {
                currentPage++;
                SearchCars();
            }
        }

        private void LastPageBtn_Click(object sender, EventArgs e)
        {
            currentPage = (totalRecords + carsPerPage - 1) / carsPerPage;
            SearchCars();
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