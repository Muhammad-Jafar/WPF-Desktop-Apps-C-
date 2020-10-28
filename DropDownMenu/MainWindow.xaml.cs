using BeautySolutions.View.ViewModel;
using MaterialDesignThemes.Wpf;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using System.IO.Compression;
using System.IO.Compression.FileSystem;
using System.Windows.Input;
using DropDownMenu.Pendaftaran;

namespace DropDownMenu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
  {
        public MainWindow()
        {
          InitializeComponent();


            HalamanDepan dashboard = new HalamanDepan();
            myframe.NavigationService.Navigate(dashboard);

                var menuRegister = new List<SubItem>
                {
                    new SubItem("Pelanggan"),
                    new SubItem("Penyedia"),
                    new SubItem("Karyawan"),
                    new SubItem("Produk")
                };
                var item6 = new ItemMenu("Pendaftaran", menuRegister, PackIconKind.Register);

                var menuSchedule = new List<SubItem>
                {
                    new SubItem("Layanan"),
                    new SubItem("Informasi")
                };
                var item1 = new ItemMenu("Notifikasi", menuSchedule, PackIconKind.Schedule);

                var menuReports = new List<SubItem>
                {
                    new SubItem("Pelanggan"),
                    new SubItem("Penyedia"),
                    new SubItem("Produk"),
                    new SubItem("Stok Barang"),
                    new SubItem("Penjual")
                };
                var item2 = new ItemMenu("Laporan", menuReports, PackIconKind.FileReport);

                var menuExpenses = new List<SubItem>
                {
                    new SubItem("Masalah harian"),
                    new SubItem("Catatan")
                };
                var item3 = new ItemMenu("Lain-lain", menuExpenses, PackIconKind.ShoppingBasket);


                var item4 = new ItemMenu("Tentang Aplikasi", new UserControl(), PackIconKind.AboutCircleOutline);

                var item0 = new ItemMenu("Dashboard", new UserControl(), PackIconKind.ViewDashboard);

              Menu.Children.Add(new UserControlMenuItem(item0));
              Menu.Children.Add(new UserControlMenuItem(item6));
              Menu.Children.Add(new UserControlMenuItem(item1));
              Menu.Children.Add(new UserControlMenuItem(item2));
              Menu.Children.Add(new UserControlMenuItem(item3));
              Menu.Children.Add(new UserControlMenuItem(item4));
        }

    }
}
