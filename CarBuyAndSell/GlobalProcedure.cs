using CarBuyAndSell.Dto;
using CarBuyAndSell.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
        private int FncGetTotalRecords()
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
            
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@p_page", pageNum },
                    { "@p_page_size", pageSize }
                };
                ExecuteStoredProcedure("procGetAllUsersInPage", parameters);
                if (this.datCarBuyAndSellMgr.Rows.Count > 0)
                {
                    for (int row = 0; row < datCarBuyAndSellMgr.Rows.Count; row++)
                    {
                        var dataRow = this.datCarBuyAndSellMgr.Rows[row];
                        list.Add(new UserDto(
                            int.Parse(dataRow["user_id"].ToString()),
                            dataRow["role_name"].ToString(),
                            dataRow["first_name"].ToString(),
                            dataRow["last_name"].ToString(),
                            dataRow["address"].ToString(),
                            dataRow["username"].ToString(),
                            dataRow["password"].ToString(),
                            dataRow["number"].ToString(),
                            dataRow["profile_picture"].ToString()
                        ));
                    }
                }
                else
                {
                    MessageBox.Show("No users found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

            ClearData();
            return list;
        }

        public List<UserDto> ProcSearchUsers(string name, int pageSize, int page)
        {
            List<UserDto> list = new List<UserDto>();
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    {"@p_user_id", 1 },
                    { "@p_search_keyword", name },
                    { "@p_page_size", pageSize },
                    { "@p_page", page }
                };
                ExecuteStoredProcedure("procSearchUsers", parameters);

                if (this.datCarBuyAndSellMgr.Rows.Count > 0)
                {
                    for (int row = 0; row < datCarBuyAndSellMgr.Rows.Count; row++)
                    {
                        var dataRow = this.datCarBuyAndSellMgr.Rows[row];
                        list.Add(new UserDto(
                        int.Parse(dataRow["user_id"].ToString()),
                            dataRow["role_name"].ToString(),
                            dataRow["first_name"].ToString(),
                            dataRow["last_name"].ToString(),
                            dataRow["address"].ToString(),
                            dataRow["username"].ToString(),
                            dataRow["password"].ToString(),
                            dataRow["number"].ToString(),
                            dataRow["profile_picture"].ToString()
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

        public List<UserDto> ProcGetUserById(int userId)
        {
            List<UserDto> list = new List<UserDto>();
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@p_user_id", userId }
                };
                ExecuteStoredProcedure("procGetUserById", parameters);

                if (this.datCarBuyAndSellMgr.Rows.Count > 0)
                {
                    for (int row = 0; row < datCarBuyAndSellMgr.Rows.Count; row++)
                    {
                        var dataRow = this.datCarBuyAndSellMgr.Rows[row];
                        list.Add(new UserDto(
                            int.Parse(dataRow["user_id"].ToString()),
                            dataRow["role_name"].ToString(),
                            dataRow["first_name"].ToString(),
                            dataRow["last_name"].ToString(),
                            dataRow["address"].ToString(),
                            dataRow["username"].ToString(),
                            dataRow["password"].ToString(),
                            dataRow["number"].ToString(),
                            dataRow["profile_picture"].ToString()
                        ));
                    }
                }
                else
                {
                    MessageBox.Show("User not found.");
                }

                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return list;
        }

        public int ProcCountUsers(string searchKeyWord)
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@p_user_id", LoginInfo.UserId },
                    { "@p_search_keyword", searchKeyWord }
                };
                ExecuteStoredProcedure("procCountUsers", parameters);
                return int.Parse(this.datCarBuyAndSellMgr.Rows[0]["total_count"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public UserDto ProcValidateUser(string username, string password)
        {
            UserDto user = null;
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@p_username", username },
                    { "@p_password", password }
                };
                ExecuteStoredProcedure("procValidateUser", parameters);

                if (this.datCarBuyAndSellMgr.Rows.Count > 0)
                {
                    var dataRow = this.datCarBuyAndSellMgr.Rows[0];
                    user = new UserDto(
                        int.Parse(dataRow["user_id"].ToString()),
                        dataRow["role_name"].ToString(),
                        dataRow["first_name"].ToString(),
                        dataRow["last_name"].ToString(),
                        dataRow["address"].ToString(),
                        dataRow["username"].ToString(),
                        dataRow["password"].ToString(),
                        dataRow["number"].ToString(),
                        dataRow["profile_picture"].ToString()
                    );
                }
                else
                {
                    MessageBox.Show("Invalid username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return user;
        }

        public bool ProcCreateUser(User user)
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@p_first_name", user.FirstName },
                    { "@p_last_name", user.LastName },
                    { "@p_username", user.Username },
                    { "@p_role", user.RoleId },
                    { "@p_address", user.Address },
                    { "@p_number", user.Number },
                    { "@p_password", user.Password },
                    { "@p_profile_picture", user.ProfilePicture }
                };
                ExecuteStoredProcedure("procCreateUser", parameters);
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
                    { "@p_user_id", user.UserId },
                    { "@p_first_name", user.FirstName },
                    { "@p_last_name", user.LastName },
                    { "@p_username", user.Username },
                    { "@p_role", user.RoleId },
                    { "@p_address", user.Address },
                    { "@p_number", user.Number },
                    { "@p_password", user.Password },
                    { "@p_profile_picture", user.ProfilePicture }
                };
                ExecuteStoredProcedure("procUpdateUser", parameters);
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
                Dictionary<string, object> parameters = new Dictionary<string, object> { { "@p_user_id", userId } };
                ExecuteStoredProcedure("procDeleteUser", parameters);
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
                { "@p_user_id", LoginInfo.UserId },
                { "@p_page", pageNum },
                { "@p_page_size", pageSize }
            };
            ExecuteStoredProcedure("procGetAllVehicles",parameters);

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
                        double.Parse(dataRow["mileage"].ToString()),
                        double.Parse(dataRow["market_value"].ToString()),
                        dataRow["file_name"].ToString()
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

        public List<VehicleDto> ProcGetVehicleById(int vehicleId)
        {
            List<VehicleDto> list = new List<VehicleDto>();
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@p_vehicle_id", vehicleId }
                };
                ExecuteStoredProcedure("procGetVehicleById", parameters);

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
                            double.Parse(dataRow["mileage"].ToString()),
                            double.Parse(dataRow["market_value"].ToString()),
                            dataRow["file_name"].ToString()
                        ));
                    }
                }
                else
                {
                    MessageBox.Show("Vehicle not found.");
                }

                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return list;
        }

        public int ProcCountVehicles(string searchKeyWord)
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@p_user_id", LoginInfo.UserId },
                    { "@p_search_keyword", searchKeyWord }
                };
                ExecuteStoredProcedure("procCountVehicles",parameters);
                return int.Parse(this.datCarBuyAndSellMgr.Rows[0]["total_count"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public List<VehicleDto> ProcSearchVehicles(string searchKeyWord, int pageNum, int pageSize)
        {
            List<VehicleDto> list = new List<VehicleDto>();
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@p_user_id", LoginInfo.UserId },
                    { "@p_page", pageNum },
                    { "@p_page_size", pageSize },
                    { "@p_search_keyword", searchKeyWord }
                };
                ExecuteStoredProcedure("procSearchVehicles", parameters);

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
                            double.Parse(dataRow["mileage"].ToString()),
                            double.Parse(dataRow["market_value"].ToString()),
                            dataRow["file_name"].ToString()
                        ));
                    }
                }
                else
                {
                    MessageBox.Show("No vehicles found.");
                }

                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return list;

        }

        public bool ProcCreateVehicle(Vehicle vehicle)
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@p_brand_id", vehicle.BrandId },
                    { "@p_condition_id", vehicle.ConditionId },
                    { "@p_transmission_type_id", vehicle.TransmissionTypeId },
                    { "@p_model", vehicle.Model },
                    { "@p_manufacture_year", vehicle.ManufactureYear },
                    { "@p_plate_number", vehicle.PlateNumber },
                    { "@p_mileage", vehicle.Mileage },
                    { "@p_owner_id", vehicle.OwnerId },
                    { "@p_file_name", vehicle.FileName }
                };
                ExecuteStoredProcedure("procCreateVehicle", parameters);
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
                    { "@p_brand_id", vehicle.BrandId },
                    { "@p_condition_id", vehicle.ConditionId },
                    { "@p_transmission_type_id", vehicle.TransmissionTypeId },
                    { "@p_model", vehicle.Model },
                    { "@p_manufacture_year", vehicle.ManufactureYear },
                    { "@p_plate_number", vehicle.PlateNumber },
                    { "@p_mileage", vehicle.Mileage },
                    { "@p_owner_id", vehicle.OwnerId },
                    { "@p_file_name", vehicle.FileName }
                };
                ExecuteStoredProcedure("procUpdateVehicle", parameters);
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
                Dictionary<string, object> parameters = new Dictionary<string, object> { { "@p_vehicle_id", vehicleId } };
                ExecuteStoredProcedure("procDeleteVehicle", parameters);
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
                { "@p_user_id", LoginInfo.UserId },
                { "@p_page", pageNum },
                { "@p_page_size", pageSize }
            };
            ExecuteStoredProcedure("procGetAllBids",parameters);

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
                        DateTime.Parse(dataRow["bid_date"].ToString()),
                        int.Parse(dataRow["bidder_id"].ToString())
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

        public List<BidDto> ProcGetBidById(int bidId)
        {
            List<BidDto> list = new List<BidDto>();
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@p_bid_id", bidId }
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
                            DateTime.Parse(dataRow["bid_date"].ToString()),
                            int.Parse(dataRow["bidder_id"].ToString())
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


        public List<BidDto> ProcGetBidsByListingId(int listingId)
        {
            List<BidDto> list = new List<BidDto>();
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@p_listing_id", listingId }
                };
                ExecuteStoredProcedure("procGetBidsByListingId", parameters);

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
                            DateTime.Parse(dataRow["bid_date"].ToString()),
                            int.Parse(dataRow["bidder_id"].ToString())
                        ));
                    }
                }
                else
                {
                    MessageBox.Show("No bids found.");
                }

                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return list;
        }

        public int ProcCountBids(string searchKeyWord)
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@p_user_id", LoginInfo.UserId },
                    { "@p_search_keyword", searchKeyWord }
                };
                ExecuteStoredProcedure("procCountBids", parameters);
                return int.Parse(this.datCarBuyAndSellMgr.Rows[0]["total_count"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public List<BidDto> ProcSearchBids(string searchKeyWord, int pageNum, int pageSize) 
        { 
            List<BidDto> list = new List<BidDto>();
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@p_user_id", LoginInfo.UserId },
                    { "@p_page", pageNum },
                    { "@p_page_size", pageSize },
                    { "@p_search_keyword", searchKeyWord }
                };
                ExecuteStoredProcedure("procSearchBids", parameters);

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
                            DateTime.Parse(dataRow["bid_date"].ToString()),
                            int.Parse(dataRow["bidder_id"].ToString())
                        ));
                    }
                }
                else
                {
                    MessageBox.Show("No bids found.");
                }

                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return list;
        }
        public bool ProcCreateBid(Bid bid)
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@p_user_id", bid.UserId },
                    { "@p_listing_id", bid.ListingId },
                    { "@p_bid_amount", bid.BidAmount },
                    { "@p_bid_date", bid.BidDate }
                };
                ExecuteStoredProcedure("procCreateBid", parameters);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool ProcUpdateBid(Bid bid)
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@p_user_id", bid.UserId },
                    { "@p_listing_id", bid.ListingId },
                    { "@p_bid_amount", bid.BidAmount },
                    { "@p_bid_date", bid.BidDate }
                };
                ExecuteStoredProcedure("procUpdateBid", parameters);
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
                Dictionary<string, object> parameters = new Dictionary<string, object> { { "@p_bid_id", bidId } };
                ExecuteStoredProcedure("procDeleteBid", parameters);
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
            ExecuteStoredProcedure("procGetAllBrands");

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
        public List<Brand> ProcGetBrandById(int brandId)
        {
            List<Brand> list = new List<Brand>();
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@p_brand_id", brandId }
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

        public int ProcCountBrands()
        {
            try
            {
                ExecuteStoredProcedure("procCountBrands");
                return int.Parse(this.datCarBuyAndSellMgr.Rows[0]["total_count"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        // -----------------------------------
        // Listings
        // -----------------------------------
        public List<ListingDto> ProcGetListings(int pageNum, int pageSize, bool isMarket)
        {
            List<ListingDto> list = new List<ListingDto>();

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@p_user_id", LoginInfo.UserId },
                { "@p_page", pageNum },
                { "@p_page_size", pageSize }
            };

            if (isMarket)
            {
                parameters["@p_user_id"] = 1;
            }

            ExecuteStoredProcedure("procGetAllListings", parameters);

            if (this.datCarBuyAndSellMgr.Rows.Count > 0)
            {
                for (int row = 0; row < datCarBuyAndSellMgr.Rows.Count; row++)
                {
                    var dataRow = this.datCarBuyAndSellMgr.Rows[row];
                    DateTime.TryParse(dataRow["listing_expiry"].ToString(), out DateTime expiryDate);
                    list.Add(new ListingDto(
                        int.Parse(dataRow["listing_id"].ToString()),
                        int.Parse(dataRow["vehicle_id"].ToString()),
                        DateTime.Parse(dataRow["date_listed"].ToString()),
                        double.Parse(dataRow["asking_price"].ToString()),
                        expiryDate,
                        dataRow["description"].ToString(),
                        dataRow["first_name"].ToString(),
                        dataRow["last_name"].ToString(),
                        dataRow["status_name"].ToString(),
                        int.Parse(dataRow["owner_id"].ToString())
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

        public List<ListingDto> ProcGetListingById(int listingId)
        {
            List<ListingDto> list = new List<ListingDto>();
            try
            {
                // Define the parameters to be passed to the stored procedure
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@p_listing_id", listingId }
                };

                // Call the stored procedure
                ExecuteStoredProcedure("procGetListingById", parameters);

                // Check if any data was returned
                if (this.datCarBuyAndSellMgr.Rows.Count > 0)
                {
                    for (int row = 0; row < FncGetTotalRecords(); row++)
                    {
                        var dataRow = this.datCarBuyAndSellMgr.Rows[row];

                        DateTime.TryParse(dataRow["listing_expiry"].ToString(), out DateTime expiryDate);
                        list.Add(new ListingDto(
                            int.Parse(dataRow["listing_id"].ToString()),
                            int.Parse(dataRow["vehicle_id"].ToString()),
                            DateTime.Parse(dataRow["date_listed"].ToString()),
                            double.Parse(dataRow["asking_price"].ToString()),
                            expiryDate,
                            dataRow["description"].ToString(),
                            dataRow["first_name"].ToString(),
                            dataRow["last_name"].ToString(),
                            dataRow["status_name"].ToString(),
                            int.Parse(dataRow["owner_id"].ToString())
                        ));
                    }
                }
                else
                {
                    MessageBox.Show("Listing not found.");
                }

                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return list;
        }

        public int ProcCountListings(string searchKeyWord, bool isMarket)
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@p_user_id", LoginInfo.UserId },
                    { "@p_search_keyword", searchKeyWord }
                };
                if (isMarket)
                {
                    parameters["@p_user_id"] = 1;
                }
                ExecuteStoredProcedure("procCountListings", parameters);
                return int.Parse(this.datCarBuyAndSellMgr.Rows[0]["total_count"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public List<ListingDto> ProcSearchListings(string searchKeyWord, int pageNum, int pageSize, bool isMarket)
        {
            List<ListingDto> list = new List<ListingDto>();
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@p_user_id", LoginInfo.UserId },
                    { "@p_page", pageNum },
                    { "@p_page_size", pageSize },
                    { "@p_search_keyword", searchKeyWord }
                };
                if(isMarket)
                {
                    parameters["@p_user_id"] = 1;
                }
                ExecuteStoredProcedure("procSearchListings", parameters);

                if (this.datCarBuyAndSellMgr.Rows.Count > 0)
                {
                    for (int row = 0; row < datCarBuyAndSellMgr.Rows.Count; row++)
                    {
                        var dataRow = this.datCarBuyAndSellMgr.Rows[row];

                        DateTime.TryParse(dataRow["listing_expiry"].ToString(), out DateTime expiryDate);
                        list.Add(new ListingDto(
                            int.Parse(dataRow["listing_id"].ToString()),
                            int.Parse(dataRow["vehicle_id"].ToString()),
                            DateTime.Parse(dataRow["listing_date"].ToString()),
                            double.Parse(dataRow["asking_price"].ToString()),
                            expiryDate,
                            dataRow["description"].ToString(),
                            dataRow["first_name"].ToString(),
                            dataRow["last_name"].ToString(),
                            dataRow["status_name"].ToString(),
                            int.Parse(dataRow["owner_id"].ToString())
                        ));
                    }
                }
                else
                {
                    MessageBox.Show("No listings found.");
                }

                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return list;
        }

        public bool ProcCreateListing(Listing listing)
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@p_vehicle_id", listing.VehicleId },
                    { "@p_user_id", listing.UserId },
                    { "@p_description", listing.Description },
                    { "@p_asking_price", listing.AskingPrice },
                    { "@p_date_listed", listing.DateListed },
                    { "@p_status_id", listing.StatusId },
                    { "@p_listing_expiry", listing.ListingExpiry }
                };
                ExecuteStoredProcedure("procCreateListing", parameters);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        public bool ProcUpdateListing(Listing listing)
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@p_vehicle_id", listing.VehicleId },
                    { "@p_user_id", listing.UserId },
                    { "@p_description", listing.Description },
                    { "@p_asking_price", listing.AskingPrice },
                    { "@p_date_listed", listing.DateListed },
                    { "@p_status_id", listing.StatusId },
                    { "@p_listing_expiry", listing.ListingExpiry }
                };
                ExecuteStoredProcedure("procUpdateListing", parameters);
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
                Dictionary<string, object> parameters = new Dictionary<string, object> { { "@p_listing_id", listingId } };
                ExecuteStoredProcedure("procDeleteListing", parameters);
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
                { "@p_user_id", LoginInfo.UserId },
                { "@p_page", pageNum },
                { "@p_page_size", pageSize }
            };
            ExecuteStoredProcedure("procGetAllTransactions", parameters);

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
                        dataRow["payment_method_name"].ToString(),
                        int.Parse(dataRow["buyer_id"].ToString()),
                        int.Parse(dataRow["seller_id"].ToString())
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

        public List<TransactionDto> ProcGetTransactionById(int transactionId, int pageSize, int page)
        {
            List<TransactionDto> list = new List<TransactionDto>();
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@p_transaction_id", transactionId },
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
                            dataRow["payment_method_name"].ToString(),
                            int.Parse(dataRow["buyer_id"].ToString()),
                            int.Parse(dataRow["seller_id"].ToString())
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

        public List<TransactionDto> ProcGetTransactionsByDate(DateTime startDate, DateTime endDate, int pageSize, int page)
        {
            List<TransactionDto> list = new List<TransactionDto>();
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@p_start_date", startDate },
                    { "@p_end_date", endDate },
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
                            dataRow["payment_method_name"].ToString(),
                            int.Parse(dataRow["buyer_id"].ToString()),
                            int.Parse(dataRow["seller_id"].ToString())
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

        public List<TransactionDto> ProcGetTransactionsByNameOfUser(string userName, int pageSize, int page)
        {
            List<TransactionDto> list = new List<TransactionDto>();
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@p_user_name", userName },
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
                            dataRow["payment_method_name"].ToString(),
                            int.Parse(dataRow["buyer_id"].ToString()),
                            int.Parse(dataRow["seller_id"].ToString())
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

        public int ProcCountTransactions(string searchKeyWord)
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@p_user_id", LoginInfo.UserId },
                    { "@p_search_keyword", searchKeyWord }
                };
                ExecuteStoredProcedure("procCountTransactions", parameters);
                return int.Parse(this.datCarBuyAndSellMgr.Rows[0]["total_count"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public List<TransactionDto> ProcSearchTransactions(string searchKeyWord, int pageNum, int pageSize)
        {
            List<TransactionDto> list = new List<TransactionDto>();
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@p_user_id", LoginInfo.UserId },
                    { "@p_page", pageNum },
                    { "@p_page_size", pageSize },
                    { "@p_search_keyword", searchKeyWord }
                };
                ExecuteStoredProcedure("procSearchTransactions", parameters);

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
                            dataRow["payment_method_name"].ToString(),
                            int.Parse(dataRow["buyer_id"].ToString()),
                            int.Parse(dataRow["seller_id"].ToString())
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

        public bool ProcCreateTransaction(Transaction transaction)
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@p_seller_id", transaction.SellerId },
                    { "@p_buyer_id", transaction.BuyerId },
                    { "@p_vehicle_id", transaction.VehicleId },
                    { "@p_date", transaction.TransactionDate },
                    { "@p_sale_price", transaction.SalePrice },
                    { "@p_payment_method_id", transaction.PaymentMethodId }
                };
                ExecuteStoredProcedure("procCreateTransaction", parameters);
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
                Dictionary<string, object> parameters = new Dictionary<string, object> { { "@p_transaction_id", transactionId } };
                ExecuteStoredProcedure("procDeleteTransaction", parameters);
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
