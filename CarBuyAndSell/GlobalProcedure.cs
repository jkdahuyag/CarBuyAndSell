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
        public List<User> FncGetUsers(int pageNum, int pageSize)
        {
            List<User> list = new List<User>();
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@p_page", pageNum },
                { "@p_page_size", pageSize }
            };
            ExecuteStoredProcedure("procGetAllUsersInPage");

            if (this.datCarBuyAndSellMgr.Rows.Count > 0)
            {
                for (int row = 0; row < FncGetTotalRecords(); row++)
                {
                    var dataRow = this.datCarBuyAndSellMgr.Rows[row];
                    list.Add(new Models.User(
                        int.Parse(dataRow["user_id"].ToString()),
                        int.Parse(dataRow["role"].ToString()),
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

        public bool FncInsertUser(User user)
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

        public bool FncUpdateUser(User user)
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

        public bool FncDeleteUser(int userId)
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
        // Bids
        // -----------------------------------
        public List<Bid> FncGetBids(int pageNum, int pageSize)
        {
            List<Bid> list = new List<Bid>();
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@p_page", pageNum },
                { "@p_page_size", pageSize }
            };
            ExecuteStoredProcedure("proc_select_all_bids");

            if (this.datCarBuyAndSellMgr.Rows.Count > 0)
            {
                for (int row = 0; row < FncGetTotalRecords(); row++)
                {
                    var dataRow = this.datCarBuyAndSellMgr.Rows[row];
                    list.Add(new Bid(
                        int.Parse(dataRow["bid_id"].ToString()),
                        int.Parse(dataRow["user_id"].ToString()),
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

        public bool FncInsertBid(Bid bid)
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

        public bool FncDeleteBid(int bidId)
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
        public List<Brand> FncGetBrands()
        {
            List<Brand> list = new List<Brand>();
            ExecuteStoredProcedure("proc_select_all_brands");

            if (this.datCarBuyAndSellMgr.Rows.Count > 0)
            {
                for (int row = 0; row < FncGetTotalRecords(); row++)
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

    }
}
