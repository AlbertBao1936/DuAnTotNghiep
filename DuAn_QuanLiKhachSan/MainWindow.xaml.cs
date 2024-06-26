﻿using DuAn_QuanLiKhachSan.Themes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DuAn_QuanLiKhachSan.Views;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DuAn_QuanLiKhachSan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;
        }
        private void Themes_Click(object sender, RoutedEventArgs e)
        {
            if (Themes.IsChecked == true)
                ThemesController.SetTheme(ThemesController.ThemeTypes.Dark);
            else
                ThemesController.SetTheme(ThemesController.ThemeTypes.Light);
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnRestore_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
                WindowState = WindowState.Maximized;
            else
                WindowState = WindowState.Normal;
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void rdHome_Click(object sender, RoutedEventArgs e)
        {
            frameContent.Navigate(new trangChu());
        }


        private void rdRoom_Click(object sender, RoutedEventArgs e)
        {
            frameContent.Navigate(new Phong());
        }

        private void rdBookroom_Click(object sender, RoutedEventArgs e)
        {
            
            frameContent.Navigate(new DatPhong());

        }

        private void rdClient_Click(object sender, RoutedEventArgs e)
        {
            frameContent.Navigate(new KhachHang());

        }

        private void rdBills_Click(object sender, RoutedEventArgs e)
        {
            frameContent.Navigate(new HoaDon());

        }

        private void rdServices_Click(object sender, RoutedEventArgs e)
        {
            frameContent.Navigate(new DichVu());

        }

        private void rdKindOfRoom_Click(object sender, RoutedEventArgs e)
        {
            
            frameContent.Navigate(new LoaiPhong());

        }

        private void rdStaff_Click(object sender, RoutedEventArgs e)
        {
            frameContent.Navigate(new NhanVien());

        }

        private void rdChart_Click(object sender, RoutedEventArgs e)
        {
            frameContent.Navigate(new thongKe());

        }
    }
}
