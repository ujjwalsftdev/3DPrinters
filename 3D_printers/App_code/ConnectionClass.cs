using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Collections;
using System.Data;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _3D_printers
{
    public static class ConnCls
    {
        private static SqlConnection conn;
        private static SqlCommand command;

        static ConnCls()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["PrintersConnection"].ToString();
            conn = new SqlConnection(connectionString);
            command = new SqlCommand("", conn);
        }
        public static ArrayList GetPrintersByName(string PrintersName)
        {
            ArrayList list = new ArrayList();
            string query = string.Format("SELECT * FROM Printers WHERE name LIKE '{0}'", PrintersName);
            try
            {
                conn.Open();
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    double price = reader.GetDouble(2);
                    string image = reader.GetString(3);
                    string review = reader.GetString(4);

                    prin printers = new prin(id, name, price, image, review);
                    list.Add(printers);
                }
            }
            finally
            {
                conn.Close();
            }
            return list;
        }
    }
}