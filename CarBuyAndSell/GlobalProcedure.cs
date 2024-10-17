using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
        public MySqlDataAdapter sqlBuyAndSellAdapter;
        public DataTable datBuyAndSell;

        public bool fncConnectToDatabase()
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

    }
}
