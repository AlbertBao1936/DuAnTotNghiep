﻿using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DuAn_QuanLiKhachSan.Views
{
    /// <summary>
    /// Interaction logic for KhachHang.xaml
    /// </summary>
    public partial class KhachHang : Page
    {
        QL_KhachSanEntities db = new QL_KhachSanEntities();
        public static BUS_KHACHHANG bUS_KhachHang = new BUS_KHACHHANG();

        public KhachHang()
        {
            InitializeComponent();
        }

        public void load()
        {
            var load = bUS_KhachHang.GetAll();
            dataGrid.ItemsSource = load;
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            /*đếm stt theo cột*/
            int index = dataGrid.SelectedIndex;
            /*chọn hàng theo stt*/
            var row = (DataGridRow)dataGrid.ItemContainerGenerator.ContainerFromIndex(index);

            DTO.KhachHang khach = new DTO.KhachHang();

            if (row != null)
            {
                var cell = dataGrid.Columns[0].GetCellContent(row) as TextBlock;


                if (cell != null)
                {
                    khach = bUS_KhachHang.GetAll().Where(c => c.MaKH == cell.Text).FirstOrDefault();
                }

                cell = dataGrid.Columns[1].GetCellContent(row) as TextBlock;


                if (cell != null)
                {
                    khach.TenKH = cell.Text;
                }

                cell = dataGrid.Columns[2].GetCellContent(row) as TextBlock;


                if (cell != null)
                {
                    khach.MaCMT = cell.Text;
                }

                cell = dataGrid.Columns[3].GetCellContent(row) as TextBlock;


                if (cell != null)
                {
                    khach.SDT = cell.Text;
                }

                cell = dataGrid.Columns[4].GetCellContent(row) as TextBlock;


                if (cell != null)
                {
                    khach.DiaChi = cell.Text;
                }

                cell = dataGrid.Columns[5].GetCellContent(row) as TextBlock;


                if (cell != null)
                {
                    bool temp = false;
                    if (cell.Text.ToLower() == "Nam")
                    {
                        temp = true;
                    }
                    if (cell.Text.ToLower() == "Nữ")
                    {
                        temp = false;
                    }

                    khach.Phai = temp;
                }

                cell = dataGrid.Columns[6].GetCellContent(row) as TextBlock;


                if (cell != null)
                {
                    khach.QuocTich = cell.Text;
                }


            }
            var ThongBao = new DialogCustoms("Xác nhận thay đổi thông tin khách hàng !", "Thông báo", DialogCustoms.YesNo);
            if (ThongBao.ShowDialog() == true)
            {
                bUS_KhachHang.Update(khach);
                var ThongBao1 = new DialogCustoms("Cập nhật thành công", "Thông báo", DialogCustoms.OK);
                ThongBao1.ShowDialog();
                load();
            }
            else
            {
                var ThongBao1 = new DialogCustoms("Cập nhật thất bại!", "Thông báo", DialogCustoms.OK);
                ThongBao1.ShowDialog();
                return;
            }



        }



        private void txt_searchBill_TextChanged(object sender, TextChangedEventArgs e)
        {
            var timkiem = txt_searchBill.Text.ToLower();
            List<DTO.KhachHang> result = bUS_KhachHang.GetAll().Where(c => c.TenKH.ToLower().Contains(timkiem)).ToList();
            dataGrid.ItemsSource = result;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            load();
        }


    }
}
