using System;
using System.Data;
using MySql.Data.MySqlClient;


namespace DropDownMenu
{
    class Koneksi
    {
        private static void Main(string[] Arguments)
        {
            string connstring = "server=localhost;username=root;password=;database=BUMDES";

            MySqlConnection conn = null;

            try
            {
                conn = new MySqlConnection(connstring);
                conn.Open();

                string query = "SELECT * FROM login_admin;";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "login_admin");
                DataTable dt = ds.Tables["login_admin"];

                foreach (DataRow row in dt.Rows)
                {
                    foreach (DataColumn col in dt.Columns)
                    {
                        Console.Write(row[col] + "\t");
                    }

                    Console.Write("\n");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.ToString());
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }

}
