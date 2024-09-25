using ReaLTaiizor;
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
    public partial class BuyViewControl : UserControl
    {
        private List<string> cars = new List<string>();
        private int currentPage = 1;
        private const int carsPerPage = 10;

        public BuyViewControl()
        {
            InitializeComponent();

            // Simulate placeholder text
            SetPlaceholder();
            searchBox.Enter += RemovePlaceholder;
            searchBox.Leave += SetPlaceholder;

            searchButton.Click += SearchButton_Click;

            prevPageBtn.Click += PrevPageBtn_Click;

            nextPageBtn.Click += NextPageBtn_Click;
            firstPageBtn.Click += FirstPageBtn_Click;
            lastPageBtn.Click += LastPageBtn_Click;

            //pageSelector.ValueChanged += PageSelector_ValueChanged;
            // Load data and display initial car list
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

        // Event handler to remove the placeholder text when user starts typing
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
            // Get the search query from the searchBox
            string searchQuery = searchBox.Text.ToLower();
            SearchCars(searchQuery); // Implement search logic
        }

        private void SearchCars(string searchQuery)
        {
            // Filter the car list based on the search query
            List<string> filteredCars = cars
                .Where(car => car.ToLower().Contains(searchQuery))
                .ToList();

            if (filteredCars.Count > 0)
            {
                // Replace the original car list with the filtered list
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

        // Display cars in 5 columns, 2 rows (10 cars per page)
        private void DisplayCars()
        {
            carTableLayoutPanel.Controls.Clear(); // Clear previous cars

            int start = (currentPage - 1) * carsPerPage;
            int end = Math.Min(start + carsPerPage, cars.Count);

            for (int i = start; i < end; i++)
            {
                System.Windows.Forms.GroupBox carCard = new System.Windows.Forms.GroupBox();
                carCard.Text = cars[i];
                carCard.Padding = new Padding(10);
                carCard.Dock = DockStyle.Fill;

                Label carDetails = new Label();
                carDetails.Text = $"Car details for {cars[i]}";
                carDetails.AutoSize = true;
                carCard.Controls.Add(carDetails);

                carTableLayoutPanel.Controls.Add(carCard);
            }

            UpdatePaginationButtons();
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

        //private void PageSelector_ValueChanged(object sender, EventArgs e)
        //{
        //    currentPage = (int)pageSelector.Value;
        //    DisplayCars();
        //}
    }

}
