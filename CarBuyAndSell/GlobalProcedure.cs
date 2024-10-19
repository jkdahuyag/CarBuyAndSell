using CarBuyAndSell.Dto;
using CarBuyAndSell.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarBuyAndSell
{
    internal class GlobalProcedure
    {
        public string servername;
        public string databasename;
        public string username;
        public string password;
        public string port;

        public MySqlConnection conBuyAndSell;
        public MySqlCommand sqlCommand;
        public string strConnection;

        // packages and classes
        public MySqlDataAdapter sqlAdapter;
        public DataTable datCarBuyAndSellMgr;

        public bool FncConnectToDatabase()
        {
            try
            {
                servername = "localhost";
                databasename = "car_buy_and_sell";
                username = "root";
                password = "destructive_tihs_123";
                port = "3306";

                strConnection = "Server=" + servername + ";" +
                    "Database=" + databasename + ";" +
                    "User=" + username + ";" +
                    "Password=" + password + ";" +
                    "Port=" + port + ";" +
                    "Convert Zero Datetime=true";

                conBuyAndSell = new MySqlConnection(strConnection);
                sqlCommand = new MySqlCommand(strConnection, conBuyAndSell);
                //Debug.WriteLine("db connected");
                if (conBuyAndSell.State == ConnectionState.Closed)
                {
                    sqlCommand.Connection = conBuyAndSell;
                    conBuyAndSell.Open();
                    return true;
                }
                else
                {
                    conBuyAndSell.Close();
                    return false;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error Message" + err.Message);
            }
            return false;
        }
        private int ProcGetTotalRecords()
        {
            return this.datCarBuyAndSellMgr.Rows.Count;
        }

        private void ClearData()
        {
            this.sqlAdapter.Dispose();
            this.datCarBuyAndSellMgr.Dispose();
        }

        // Helper Function to Execute Queries
        private void ExecuteStoredProcedure(string procName, Dictionary<string, object> parameters = null)
        {
            try
            {
                sqlCommand.CommandText = procName;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Clear();

                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        sqlCommand.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }

                this.sqlAdapter = new MySqlDataAdapter();
                this.datCarBuyAndSellMgr = new DataTable();
                this.sqlAdapter.SelectCommand = this.sqlCommand;
                this.datCarBuyAndSellMgr.Clear();
                this.sqlAdapter.Fill(this.datCarBuyAndSellMgr);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // -----------------------------------
        // Users
        // -----------------------------------
        public List<UserDto> ProcGetUsers(int pageNum, int pageSize)
        {
            List<UserDto> list = new List<UserDto>();
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@p_page", pageNum },
                { "@p_page_size", pageSize }
            };
            ExecuteStoredProcedure("procGetAllUsersInPage");

            if (this.datCarBuyAndSellMgr.Rows.Count > 0)
            {
                for (int row = 0; row < datCarBuyAndSellMgr.Rows.Count; row++)
                {
                    var dataRow = this.datCarBuyAndSellMgr.Rows[row];
                    list.Add(new UserDto(
                        int.Parse(dataRow["user_id"].ToString()),
                        dataRow["role"].ToString(),
                        dataRow["first_name"].ToString(),
                        dataRow["last_name"].ToString(),
                        dataRow["address"].ToString(),
                        dataRow["username"].ToString(),
                        dataRow["password"].ToString(),
                        dataRow["number"].ToString()
                    ));
                }
            }
            else
            {
                MessageBox.Show("No users found.");
            }

            ClearData();
            return list;
        }

        public List<UserDto> FncSearchUsersByName(string name, int pageSize, int page)
        {
            List<UserDto> list = new List<UserDto>();
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@p_search_keyword", name },
                    { "@p_page_size", pageSize },
                    { "@p_page", page }
                };
                ExecuteStoredProcedure("procSearchUsersByName", parameters);

                if (this.datCarBuyAndSellMgr.Rows.Count > 0)
                {
                    for (int row = 0; row < datCarBuyAndSellMgr.Rows.Count; row++)
                    {
                        var dataRow = this.datCarBuyAndSellMgr.Rows[row];
                        list.Add(new UserDto(
                        int.Parse(dataRow["user_id"].ToString()),
                        dataRow["role"].ToString(),
                        dataRow["first_name"].ToString(),
                        dataRow["last_name"].ToString(),
                        dataRow["address"].ToString(),
                        dataRow["username"].ToString(),
                        dataRow["password"].ToString(),
                        dataRow["number"].ToString()
                        ));
                    }
                }
                else
                {
                    MessageBox.Show("No users found.");
                }

                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return list;
        }



        public bool ProcInsertUser(User user)
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@first_name", user.FirstName },
                    { "@last_name", user.LastName },
                    { "@username", user.Username },
                    { "@role", user.RoleId },
                    { "@address", user.Address },
                    { "@number", user.Number },
                    { "@password", user.Password }
                };
                ExecuteStoredProcedure("proc_insert_user", parameters);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool ProcUpdateUser(User user)
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@user_id", user.UserId },
                    { "@first_name", user.FirstName },
                    { "@last_name", user.LastName },
                    { "@username", user.Username },
                    { "@role", user.RoleId },
                    { "@address", user.Address },
                    { "@number", user.Number },
                    { "@password", user.Password }
                };
                ExecuteStoredProcedure("proc_update_user", parameters);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool ProcDeleteUser(int userId)
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object> { { "@user_id", userId } };
                ExecuteStoredProcedure("proc_delete_user", parameters);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        // -----------------------------------
        // Vehicles
        // -----------------------------------
        public List<VehicleDto> ProcGetVehicles(int pageNum, int pageSize)
        {
            List<VehicleDto> list = new List<VehicleDto>();

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@p_page", pageNum },
                { "@p_page_size", pageSize }
            };
            ExecuteStoredProcedure("proc_select_all_vehicles");

            if (this.datCarBuyAndSellMgr.Rows.Count > 0)
            {
                for (int row = 0; row < datCarBuyAndSellMgr.Rows.Count; row++)
                {
                    var dataRow = this.datCarBuyAndSellMgr.Rows[row];
                    list.Add(new VehicleDto(
                        int.Parse(dataRow["vehicle_id"].ToString()),
                        dataRow["brand_name"].ToString(),
                        dataRow["transmission_type_name"].ToString(),
                        dataRow["condition_name"].ToString(),
                        dataRow["owner_name"].ToString(),
                        dataRow["model"].ToString(),
                        DateTime.Parse(dataRow["manufacture_year"].ToString()),
                        dataRow["plate_number"].ToString(),
                        double.Parse(dataRow["mileage"].ToString())
                    ));
                }
            }
            else
            {
                MessageBox.Show("No vehicles found.");
            }

            ClearData();
            return list;
        }

        public bool ProcInsertVehicle(Vehicle vehicle)
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@brand_id", vehicle.BrandId },
                { "@condition_id", vehicle.ConditionId },
                { "@transmission_type_id", vehicle.TransmissionTypeId },
                { "@status_id", vehicle.StatusId },
                { "@location_stored", vehicle.LocationStored },
                { "@model", vehicle.Model },
                { "@manufacture_year", vehicle.ManufactureYear },
                { "@plate_number", vehicle.PlateNumber },
                { "@date_listed", vehicle.DateListed },
                { "@mileage", vehicle.Mileage },
                { "@owner_id", vehicle.OwnerId }
            };
                ExecuteStoredProcedure("proc_insert_vehicle", parameters);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool ProcUpdateVehicle(Vehicle vehicle)
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@vehicle_id", vehicle.VehicleId },
                { "@brand_id", vehicle.BrandId },
                { "@condition_id", vehicle.ConditionId },
                { "@transmission_type_id", vehicle.TransmissionTypeId },
                { "@status_id", vehicle.StatusId },
                { "@location_stored", vehicle.LocationStored },
                { "@model", vehicle.Model },
                { "@manufacture_year", vehicle.ManufactureYear },
                { "@plate_number", vehicle.PlateNumber },
                { "@date_listed", vehicle.DateListed },
                { "@mileage", vehicle.Mileage },
                { "@owner_id", vehicle.OwnerId }
            };
                ExecuteStoredProcedure("proc_update_vehicle", parameters);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool ProcDeleteVehicle(int vehicleId)
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object> { { "@vehicle_id", vehicleId } };
                ExecuteStoredProcedure("proc_delete_vehicle", parameters);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        // -----------------------------------
        // Bids
        // -----------------------------------
        public List<BidDto> ProcGetBids(int pageNum, int pageSize)
        {
            List<BidDto> list = new List<BidDto>();

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@p_page", pageNum },
                { "@p_page_size", pageSize }
            };
            ExecuteStoredProcedure("proc_select_all_bids");

            if (this.datCarBuyAndSellMgr.Rows.Count > 0)
            {
                for (int row = 0; row < datCarBuyAndSellMgr.Rows.Count; row++)
                {
                    var dataRow = this.datCarBuyAndSellMgr.Rows[row];
                    list.Add(new BidDto(
                        int.Parse(dataRow["bid_id"].ToString()),
                        dataRow["first_name"].ToString(),
                        dataRow["last_name"].ToString(),
                        int.Parse(dataRow["listing_id"].ToString()),
                        double.Parse(dataRow["bid_amount"].ToString()),
                        DateTime.Parse(dataRow["bid_date"].ToString())
                    ));
                }
            }
            else
            {
                MessageBox.Show("No bids found.");
            }

            ClearData();
            return list;
        }

        public List<BidDto> FncGetBidById(int bidId, int pageSize, int page)
        {
            List<BidDto> list = new List<BidDto>();
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
        {
            { "@bid_id", bidId },
            { "@p_page_size", pageSize },
            { "@p_page", page }
        };
                ExecuteStoredProcedure("procGetBidById", parameters);

                if (this.datCarBuyAndSellMgr.Rows.Count > 0)
                {
                    for (int row = 0; row < datCarBuyAndSellMgr.Rows.Count; row++)
                    {
                        var dataRow = this.datCarBuyAndSellMgr.Rows[row];
                        list.Add(new BidDto(
                            int.Parse(dataRow["bid_id"].ToString()),
                            dataRow["first_name"].ToString(),
                            dataRow["last_name"].ToString(),
                            int.Parse(dataRow["listing_id"].ToString()),
                            double.Parse(dataRow["bid_amount"].ToString()),
                            DateTime.Parse(dataRow["bid_date"].ToString())
                        ));
                    }
                }
                else
                {
                    MessageBox.Show("Bid not found.");
                }

                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return list;
        }


        public bool ProcInsertBid(Bid bid)
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@user_id", bid.UserId },
                    { "@listing_id", bid.ListingId },
                    { "@bid_amount", bid.BidAmount },
                    { "@bid_date", bid.BidDate }
                };
                ExecuteStoredProcedure("proc_insert_bid", parameters);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool ProcDeleteBid(int bidId)
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object> { { "@bid_id", bidId } };
                ExecuteStoredProcedure("proc_delete_bid", parameters);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        // -----------------------------------
        // Brands
        // -----------------------------------
        public List<Brand> ProcGetBrands()
        {
            List<Brand> list = new List<Brand>();
            ExecuteStoredProcedure("proc_select_all_brands");

            if (this.datCarBuyAndSellMgr.Rows.Count > 0)
            {
                for (int row = 0; row < datCarBuyAndSellMgr.Rows.Count; row++)
                {
                    var dataRow = this.datCarBuyAndSellMgr.Rows[row];
                    list.Add(new Brand(
                        int.Parse(dataRow["brand_id"].ToString()),
                        dataRow["brand_name"].ToString()
                    ));
                }
            }
            else
            {
                MessageBox.Show("No brands found.");
            }

            ClearData();
            return list;
        }
        public List<Brand> FncGetBrandById(int brandId, int pageSize, int page)
        {
            List<Brand> list = new List<Brand>();
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@brand_id", brandId },
                    { "@p_page_size", pageSize },
                    { "@p_page", page }
                };
                ExecuteStoredProcedure("procGetBrandById", parameters);

                if (this.datCarBuyAndSellMgr.Rows.Count > 0)
                {
                    for (int row = 0; row < datCarBuyAndSellMgr.Rows.Count; row++)
                    {
                        var dataRow = this.datCarBuyAndSellMgr.Rows[row];
                        list.Add(new Brand(
                            int.Parse(dataRow["brand_id"].ToString()),
                            dataRow["brand_name"].ToString()
                        ));
                    }
                }
                else
                {
                    MessageBox.Show("Brand not found.");
                }

                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return list;
        }

        // -----------------------------------
        // Listings
        // -----------------------------------
        public List<ListingDto> ProcGetListings(int pageNum, int pageSize)
        {
            List<ListingDto> list = new List<ListingDto>();

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@p_page", pageNum },
                { "@p_page_size", pageSize }
            };
            ExecuteStoredProcedure("proc_select_all_listings");

            if (this.datCarBuyAndSellMgr.Rows.Count > 0)
            {
                for (int row = 0; row < datCarBuyAndSellMgr.Rows.Count; row++)
                {
                    var dataRow = this.datCarBuyAndSellMgr.Rows[row];
                    list.Add(new ListingDto(
                        int.Parse(dataRow["listing_id"].ToString()),
                        int.Parse(dataRow["vehicle_id"].ToString()),
                        DateTime.Parse(dataRow["listing_date"].ToString()),
                        double.Parse(dataRow["asking_price"].ToString()),
                        DateTime.Parse(dataRow["listing_expiry"].ToString()),
                        dataRow["description"].ToString(),
                        dataRow["first_name"].ToString(),
                        dataRow["last_name"].ToString(),
                        dataRow["status_name"].ToString()
                    ));
                }
            }
            else
            {
                MessageBox.Show("No listings found.");
            }

            ClearData();
            return list;
        }

        public bool ProcInsertListing(Listing listing)
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@vehicle_id", listing.VehicleId },
                    { "@seller_id", listing.UserId },
                    { "@starting_price", listing.AskingPrice },
                    { "@listing_date", listing.DateListed }
                };
                ExecuteStoredProcedure("proc_insert_listing", parameters);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool ProcDeleteListing(int listingId)
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object> { { "@listing_id", listingId } };
                ExecuteStoredProcedure("proc_delete_listing", parameters);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        // -----------------------------------
        // Transactions
        // -----------------------------------
        public List<TransactionDto> ProcGetTransactions(int pageNum, int pageSize)
        {
            List<TransactionDto> list = new List<TransactionDto>();

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@p_page", pageNum },
                { "@p_page_size", pageSize }
            };
            ExecuteStoredProcedure("proc_select_all_transactions");

            if (this.datCarBuyAndSellMgr.Rows.Count > 0)
            {
                for (int row = 0; row < datCarBuyAndSellMgr.Rows.Count; row++)
                {
                    var dataRow = this.datCarBuyAndSellMgr.Rows[row];
                    list.Add(new TransactionDto(
                        int.Parse(dataRow["transaction_id"].ToString()),
                        dataRow["buyer_first_name"].ToString(),
                        dataRow["buyer_last_name"].ToString(),
                        dataRow["seller_first_name"].ToString(),
                        dataRow["seller_last_name"].ToString(),
                        double.Parse(dataRow["amount"].ToString()),
                        DateTime.Parse(dataRow["transaction_date"].ToString()),
                        dataRow["payment_method_name"].ToString()
                    ));
                }
            }
            else
            {
                MessageBox.Show("No transactions found.");
            }

            ClearData();
            return list;
        }

        public List<TransactionDto> FncGetTransactionById(int transactionId, int pageSize, int page)
        {
            List<TransactionDto> list = new List<TransactionDto>();
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@transaction_id", transactionId },
                    { "@p_page_size", pageSize },
                    { "@p_page", page }
                };
                ExecuteStoredProcedure("procGetTransactionById", parameters);

                if (this.datCarBuyAndSellMgr.Rows.Count > 0)
                {
                    for (int row = 0; row < datCarBuyAndSellMgr.Rows.Count; row++)
                    {
                        var dataRow = this.datCarBuyAndSellMgr.Rows[row];
                            list.Add(new TransactionDto(
                            int.Parse(dataRow["transaction_id"].ToString()),
                            dataRow["buyer_first_name"].ToString(),
                            dataRow["buyer_last_name"].ToString(),
                            dataRow["seller_first_name"].ToString(),
                            dataRow["seller_last_name"].ToString(),
                            double.Parse(dataRow["amount"].ToString()),
                            DateTime.Parse(dataRow["transaction_date"].ToString()),
                            dataRow["payment_method_name"].ToString()
                        ));
                    }
                }
                else
                {
                    MessageBox.Show("Transaction not found.");
                }

                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return list;
        }

        public List<TransactionDto> FncGetTransactionsByDate(DateTime startDate, DateTime endDate, int pageSize, int page)
        {
            List<TransactionDto> list = new List<TransactionDto>();
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@start_date", startDate },
                    { "@end_date", endDate },
                    { "@p_page_size", pageSize },
                    { "@p_page", page }
                };
                ExecuteStoredProcedure("procGetTransactionsByDate", parameters);

                if (this.datCarBuyAndSellMgr.Rows.Count > 0)
                {
                    for (int row = 0; row < datCarBuyAndSellMgr.Rows.Count; row++)
                    {
                        var dataRow = this.datCarBuyAndSellMgr.Rows[row];
                        list.Add(new TransactionDto(
                            int.Parse(dataRow["transaction_id"].ToString()),
                            dataRow["buyer_first_name"].ToString(),
                            dataRow["buyer_last_name"].ToString(),
                            dataRow["seller_first_name"].ToString(),
                            dataRow["seller_last_name"].ToString(),
                            double.Parse(dataRow["amount"].ToString()),
                            DateTime.Parse(dataRow["transaction_date"].ToString()),
                            dataRow["payment_method_name"].ToString()
                        ));
                    }
                }
                else
                {
                    MessageBox.Show("No transactions found.");
                }

                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return list;
        }

        public List<TransactionDto> FncGetTransactionsByNameOfUser(string userName, int pageSize, int page)
        {
            List<TransactionDto> list = new List<TransactionDto>();
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@user_name", userName },
                    { "@p_page_size", pageSize },
                    { "@p_page", page }
                };
                ExecuteStoredProcedure("procGetTransactionsByNameOfUser", parameters);

                if (this.datCarBuyAndSellMgr.Rows.Count > 0)
                {
                    for (int row = 0; row < datCarBuyAndSellMgr.Rows.Count; row++)
                    {
                        var dataRow = this.datCarBuyAndSellMgr.Rows[row];
                        list.Add(new TransactionDto(
                            int.Parse(dataRow["transaction_id"].ToString()),
                            dataRow["buyer_first_name"].ToString(),
                            dataRow["buyer_last_name"].ToString(),
                            dataRow["seller_first_name"].ToString(),
                            dataRow["seller_last_name"].ToString(),
                            double.Parse(dataRow["amount"].ToString()),
                            DateTime.Parse(dataRow["transaction_date"].ToString()),
                            dataRow["payment_method_name"].ToString()
                        ));
                    }
                }
                else
                {
                    MessageBox.Show("No transactions found.");
                }

                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return list;
        }

        public bool ProcInsertTransaction(Transaction transaction)
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@seller_id", transaction.SellerId },
                    { "@buyer_id", transaction.BuyerId },
                    { "@vehicle_id", transaction.VehicleId },
                    { "@date", transaction.TransactionDate },
                    { "@sale_price", transaction.SalePrice },
                    { "@payment_method_id", transaction.PaymentMethodId }
                };
                ExecuteStoredProcedure("proc_insert_transaction", parameters);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool ProcDeleteTransaction(int transactionId)
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object> { { "@transaction_id", transactionId } };
                ExecuteStoredProcedure("proc_delete_transaction", parameters);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
