using System;
using System.Configuration;
using System.Windows;
using System.Windows.Input;
using System.Data.SqlClient;

namespace DropDownMenu
{
    /// <summary>
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Window
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;

        public login()
        {
            InitializeComponent();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString();
        }

       

        private bool VerifyUser(string username, string password)
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "select Status from Login_admin where Username ='" + username + "' and Password ='" + password + "'" ;
            dr = com.ExecuteReader();

            if (dr.Read())
            {
                if (Convert.ToBoolean(dr["Status"]) == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

      
        private void masuk(object sender, RoutedEventArgs e)
        {
            if(con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }

            if (VerifyUser(userid.Text, sandi.Password))
            {
                MessageBox.Show("Login Berhasil", "Anda sedang dialihkan masuk", MessageBoxButton.OK, MessageBoxImage.Information);
                MainWindow dashboard = new MainWindow();
                dashboard.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Maaf, username atau sandi anda salah !", "Silahkan coba lagi", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void Exitlogin(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
