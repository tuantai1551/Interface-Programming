using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }

        private void ThemVaoListView(GiaiThuong Prize)
        {
            ListViewItem item = new ListViewItem(Prize.NgayMua1.ToString("MM/dd/yyyy"));

            item.SubItems.Add(Prize.LoaiVe1.ToString() + " vé");

            int temp = Prize.ThongTinVeTrungThuong1.Count;

            string a = Prize.ThongTinVeTrungThuong1[0].ToString();

            int j = 0;
            while (j < temp - 1)
            {
                a += " ";
                a += Prize.ThongTinVeTrungThuong1[++j];
            }

            item.SubItems.Add(a.ToString());

            item.SubItems.Add(string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", Prize.SoTienTrung1));


            lvKetQua.Items.Add(item);
        }

        //Sắp xếp theo ngày tăng dần
        private void SapXepTheoNgay()
        {
            for (int i = 0; i < DanhSachGiaiThuong.ListGiaiThuong1.Count - 1; ++i)
            {
                for (int j = i + 1; j < DanhSachGiaiThuong.ListGiaiThuong1.Count; ++j)
                {
                    if (DanhSachGiaiThuong.ListGiaiThuong1[i].NgayMua1.Date < DanhSachGiaiThuong.ListGiaiThuong1[j].NgayMua1.Date)
                    {
                        GiaiThuong temp = DanhSachGiaiThuong.ListGiaiThuong1[i];
                        DanhSachGiaiThuong.ListGiaiThuong1[i] = DanhSachGiaiThuong.ListGiaiThuong1[j];
                        DanhSachGiaiThuong.ListGiaiThuong1[j] = temp;

                    }
                }

            }
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            lvKetQua.Clear();

            lvKetQua.Columns.Add("Ngày quay", 180, HorizontalAlignment.Center);
            lvKetQua.Columns.Add("Hạng mục", 150, HorizontalAlignment.Center);
            lvKetQua.Columns.Add("Kết quả", 200, HorizontalAlignment.Center);
            lvKetQua.Columns.Add("Số tiền trúng", 200, HorizontalAlignment.Center);

            lvKetQua.View = View.Details;
            lvKetQua.GridLines = true;
            lvKetQua.FullRowSelect = true;

            int size = DanhSachGiaiThuong.ListGiaiThuong1.Count;
            DateTime NgayBatDau = dtpNgayBatDau.Value;
            DateTime NgayKetThuc = dtpNgayKetThuc.Value;


            if (size > 0)
            {
                SapXepTheoNgay();
                for (int i = 0; i < size; ++i)
                {
                    if (rdTatCa.Checked)
                    {
                        ThemVaoListView(DanhSachGiaiThuong.ListGiaiThuong1[i]);
                    }
                    else if (rdLuaChon.Checked)
                    {
                        if (DanhSachGiaiThuong.ListGiaiThuong1[i].NgayMua1.Date >= NgayBatDau.Date && DanhSachGiaiThuong.ListGiaiThuong1[i].NgayMua1.Date <= NgayKetThuc.Date)
                        {
                            ThemVaoListView(DanhSachGiaiThuong.ListGiaiThuong1[i]);
                        }
                    }
                    else
                    {
                        if (DanhSachGiaiThuong.ListGiaiThuong1[i].NgayMua1.Date == DateTime.Now.Date)
                        {
                            ThemVaoListView(DanhSachGiaiThuong.ListGiaiThuong1[i]);
                        }
                    }
                }
            }
        }

    }

}
