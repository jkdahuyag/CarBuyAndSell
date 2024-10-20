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

            carTableLayoutPanel.ColumnCount = this.Width / 310;
            carTableLayoutPanel.RowCount = (cars.Count + carTableLayoutPanel.ColumnCount - 1) / carTableLayoutPanel.ColumnCount;

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
            carTableLayoutPanel.Controls.Clear();

            if (cars.Count > 0)
            {
                for (int i = 0; i < cars.Count; i++)
                {
                    var car = cars[i];
                    System.Windows.Forms.Panel cardPanel = new System.Windows.Forms.Panel
                    {
                        BorderStyle = BorderStyle.FixedSingle,
                        Margin = new Padding(5),
                        Dock = DockStyle.Fill
                    };

                    PictureBox carImage = new PictureBox
                    {
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Dock = DockStyle.Top,
                        Image = LoadCarImage("")
                    };
                    cardPanel.Controls.Add(carImage);

                    Label lblOwner = new Label
                    {
                        Text = "Owner: " + car.OwnerName,
                        Dock = DockStyle.Bottom,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Padding = new Padding(0, 5, 0, 0)
                    };
                    cardPanel.Controls.Add(lblOwner);

                    Label lblBrand = new Label
                    {
                        Text = "Brand: " + car.BrandName,
                        Dock = DockStyle.Bottom,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Padding = new Padding(0, 5, 0, 0)
                    };
                    cardPanel.Controls.Add(lblBrand);

                    Label lblModel = new Label
                    {
                        Text = "Model: " + car.Model,
                        Dock = DockStyle.Bottom,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Padding = new Padding(0, 5, 0, 0)
                    };
                    cardPanel.Controls.Add(lblModel);
                    cardPanel.Click += ShowVehicleDetails(car.VehicleId);
                    // Add the card to the grid
                    carTableLayoutPanel.Controls.Add(cardPanel);
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




        private EventHandler ShowVehicleDetails(int vehicleId)
        {
            return (sender, e) =>
            {
                VehicleDetailsForm vehicleDetailsForm = new VehicleDetailsForm(vehicleId);
                vehicleDetailsForm.Show();
            };
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

        private void UsrCtrlResize(object sender, EventArgs e)
        {
            carTableLayoutPanel.ColumnCount = this.Width / 310;
            carTableLayoutPanel.RowCount = (cars.Count + carTableLayoutPanel.ColumnCount - 1)/ carTableLayoutPanel.ColumnCount;
        }
    }
}