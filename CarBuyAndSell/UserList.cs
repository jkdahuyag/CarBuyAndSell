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
    public partial class UserList : UserControl
    {
        private List<Car> cars = new List<Car>();
        private int currentPage = 1;
        private const int carsPerPage = 10;

        public UserList()
        {
            InitializeComponent();

            // Load example data for the cars table
            LoadCars();
            DisplayCars();
        }

        private void LoadCars()
        {
            // Load car data for testing purposes
            cars.Add(new Car(1, "Toyota", "Corolla", 15000, "Listed"));
            cars.Add(new Car(2, "Honda", "Civic", 20000, "Sold"));
            // Add more car data...

            DisplayCars();
        }

        private void DisplayCars()
        {
            carsDataGridView.Rows.Clear();

            int start = (currentPage - 1) * carsPerPage;
            int end = Math.Min(start + carsPerPage, cars.Count);

            for (int i = start; i < end; i++)
            {
                var car = cars[i];
                carsDataGridView.Rows.Add(car.ItemNo, car.BrandName, car.Model, car.Price, car.SellStatus);
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
            pageSelector.Maximum = totalPages;
            pageSelector.Value = currentPage;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            // Implement search functionality here
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

        private void PageSelector_ValueChanged(object sender, EventArgs e)
        {
            currentPage = (int)pageSelector.Value;
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
