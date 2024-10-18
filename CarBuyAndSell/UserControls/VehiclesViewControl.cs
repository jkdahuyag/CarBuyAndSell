using CarBuyAndSell.Forms;
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
        private List<string> cars = new List<string>();
        private int currentPage = 1;
        private const int carsPerPage = 10;

        public VehiclesViewControl()
        {
            InitializeComponent();
            if (!this.globalProcedure.FncConnectToDatabase())
                MessageBox.Show("Not Connected");

            SetPlaceholder();
            searchBox.Enter += RemovePlaceholder;
            searchBox.Leave += SetPlaceholder;
            searchButton.Click += SearchButton_Click;
            prevPageBtn.Click += PrevPageBtn_Click;
            nextPageBtn.Click += NextPageBtn_Click;
            firstPageBtn.Click += FirstPageBtn_Click;
            lastPageBtn.Click += LastPageBtn_Click;

            //pageSelector.ValueChanged += PageSelector_ValueChanged;
            LoadCars();
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
                searchBox.Text = "";
                searchBox.ForeColor = Color.Black;
            }
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchQuery = searchBox.Text.ToLower();
            SearchCars(searchQuery); 
        }

        private void SearchCars(string searchQuery)
        {
            List<string> filteredCars = cars
                .Where(car => car.ToLower().Contains(searchQuery))
                .ToList();

            if (filteredCars.Count > 0)
            {
                cars = filteredCars;
                currentPage = 1; // Reset to the first page
                DisplayCars();
            }
            else
            {
                MessageBox.Show("No cars found matching your search.");
            }
        }
        private void LoadCars()
        {
            for (int i = 1; i <= 100; i++)
            {
                cars.Add("Car " + i);
            }
        }

        private void DisplayCars()
        {
            carTableLayoutPanel.Controls.Clear(); 

            try
            {
                MySqlCommand gProcCmd = globalProcedure.sqlCommand;

                this.globalProcedure.sqlAdapter = new MySqlDataAdapter();
                this.globalProcedure.datBuyAndSell = new DataTable();

                gProcCmd.Parameters.Clear();
                gProcCmd.CommandText = "procGetAllVehicles";
                gProcCmd.CommandType = CommandType.StoredProcedure;
                gProcCmd.Parameters.AddWithValue("@p_page", currentPage);
                gProcCmd.Parameters.AddWithValue("@p_page_size", carsPerPage);
                this.globalProcedure.sqlAdapter.SelectCommand = this.globalProcedure.sqlCommand;
                this.globalProcedure.datBuyAndSell.Clear();
                this.globalProcedure.sqlAdapter.Fill(this.globalProcedure.datBuyAndSell);

                if (globalProcedure.datBuyAndSell.Rows.Count > 0)
                {
                    DataTable dataTable = globalProcedure.datBuyAndSell;
                    int totalRecords = globalProcedure.datBuyAndSell.Rows.Count;
                    for (int i = 0; i < totalRecords; i++)
                    {
                        var car = dataTable.Rows[i];
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
                            Text = "Owner: " + car["owner_name"],
                            Dock = DockStyle.Bottom,
                            TextAlign = ContentAlignment.MiddleCenter,
                            Padding = new Padding(0, 5, 0, 0)
                        };
                        cardPanel.Controls.Add(lblOwner);

                        Label lblBrand = new Label
                        {
                            Text = "Brand: " + car["brand_name"],
                            Dock = DockStyle.Bottom,
                            TextAlign = ContentAlignment.MiddleCenter,
                            Padding = new Padding(0, 5, 0, 0)
                        };
                        cardPanel.Controls.Add(lblBrand);

                        Label lblModel = new Label
                        {
                            Text = "Model: " + car["model"],
                            Dock = DockStyle.Bottom,
                            TextAlign = ContentAlignment.MiddleCenter,
                            Padding = new Padding(0, 5, 0, 0)
                        };
                        cardPanel.Controls.Add(lblModel);
                        cardPanel.Click += ShowVehicleDetails(int.Parse(car["vehicle_id"].ToString()));
                        // Add the card to the grid
                        carTableLayoutPanel.Controls.Add(cardPanel);
                    }
                }
                else
                {
                    MessageBox.Show("Record not found!");
                }

                this.globalProcedure.sqlAdapter.Dispose();
                this.globalProcedure.datBuyAndSell.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            

            UpdatePaginationButtons();
        }

        private EventHandler ShowVehicleDetails(int vehicleId)
        {
            return (sender, e) =>
            {
                // Get the vehicle ID from the card
                // Open the vehicle details form
                VehicleDetailsForm vehicleDetailsForm = new VehicleDetailsForm(vehicleId);
                vehicleDetailsForm.Show();
            };  
        }

        private void BtnAddVehicle_Click(object sender, EventArgs e)
        {

        }

        private void UpdatePaginationButtons()
        {
            int totalPages = (cars.Count + carsPerPage - 1) / carsPerPage;

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
            int totalPages = (cars.Count + carsPerPage - 1) / carsPerPage;
            if (currentPage < totalPages)
            {
                currentPage++;
                DisplayCars();
            }
        }

        private void LastPageBtn_Click(object sender, EventArgs e)
        {
            currentPage = (cars.Count + carsPerPage - 1) / carsPerPage;
            DisplayCars();
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
