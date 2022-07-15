using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static public string TenDangNhap;
        static public string MatKhau;
        static public string SoDienThoai;
        static public string Email;
        private void linkDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy FormDangKy = new DangKy();
            FormDangKy.Show();

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //Kiểm tra dữ liệu hợp lệ của txtTenDangNhap và txtMatKhau
            if (txtTenDangNhap.Text == "admin" && txtMatKhau.Text == "admin")
            {
                QuayThuong FormQuayThuong = new QuayThuong();
                FormQuayThuong.ShowDialog();
                txtTenDangNhap.Clear();
                txtMatKhau.Clear();
                return;
            }
            bool Check = true;

            bool CheckAccount = false;
            //Kiểm tra tên đăng nhập/Email và mật khẩu có đúng không
            for (int i = 0; i < DanhSachNguoiDung.ListNguoiDung.Count; ++i)
            {
                if ((txtTenDangNhap.Text == DanhSachNguoiDung.ListNguoiDung[i].TenDangNhap1 || txtTenDangNhap.Text == DanhSachNguoiDung.ListNguoiDung[i].Email1) && txtMatKhau.Text == DanhSachNguoiDung.ListNguoiDung[i].MatKhau1)
                {
                    CheckAccount = true;
                    TenDangNhap = DanhSachNguoiDung.ListNguoiDung[i].TenDangNhap1;
                    MatKhau = DanhSachNguoiDung.ListNguoiDung[i].MatKhau1;
                    Email = DanhSachNguoiDung.ListNguoiDung[i].Email1;
                    SoDienThoai = DanhSachNguoiDung.ListNguoiDung[i].SoDienThoai1;


                    break;
                }
            }

            if (CheckAccount == false)
            {
                MessageBox.Show("Tên đăng nhập/Email hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK);
            }

            if (Check && CheckAccount)
            {
                Menu FormMenu = new Menu();
                txtTenDangNhap.Clear();
                txtMatKhau.Clear();
                FormMenu.ShowDialog();
            }


        }

        private void linkLayLaiMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LayLaiMatKhau FormLayLaiMatKhau = new LayLaiMatKhau();
            FormLayLaiMatKhau.Show();
        }



        private void DocFileDanhSachThongTinNguoiDung()
        {
            string directoryPath = Application.StartupPath + @"\ThongTinNguoiDung.TXT";
            string[] a = File.ReadAllLines(directoryPath);
            NguoiDung User;
            
            if (a.Length != 0) // khi dữ liệu chưa có người dùng nào khi đọc file sẽ lỗi
            {
                for (int i = 0; i < a.Length; ++i)
                {
                    string[] MySubString = a[i].Split(' ');

                    User = new NguoiDung();
                    User.TenDangNhap1 = MySubString[0];

                    User.MatKhau1 = MySubString[2];

                    User.SoDienThoai1 = MySubString[4];

                    User.Email1 = MySubString[6];

                    DanhSachNguoiDung.ListNguoiDung.Add(User);
                }
            }
        }

        private void DocFileDanhSachVeDaMua()
        {
            string directoryPath = Application.StartupPath + @"\DanhSachVeDaMua.TXT";
            string[] a = File.ReadAllLines(directoryPath);
            Ve Ticket;
            if (a.Length != 0) // khi dữ liệu chưa có người dùng nào khi đọc file sẽ lỗi
            {
                for (int i = 0; i < a.Length; ++i)
                {
                    string[] MySubString = a[i].Split(' ');

                    Ticket = new Ve();
                    Ticket.TenTaiKhoan1 = MySubString[0];

                    Ticket.NgayMua1 = DateTime.Parse(MySubString[2]).Date;

                    Ticket.LoaiVe1 = int.Parse(MySubString[4]);

                    Ticket.SoVe1 = int.Parse(MySubString[6]);

                    int j = 8;

                    List<int> VeDaMua = new List<int>();
                    VeDaMua.Add(int.Parse(MySubString[8]));

                    while (j < MySubString.Length - 1)
                    {
                        VeDaMua.Add(int.Parse(MySubString[++j]));
                    }

                    Ticket.ThongTinVeMua1 = VeDaMua;

                    DanhSachVeDatMua.ListVeDatMua1.Add(Ticket);
                }
            }
        }
        private void DocFileDanhSachGiaiThuong()
        {
            string directoryPath = Application.StartupPath + @"\GiaiThuong.TXT";
            string[] a = File.ReadAllLines(directoryPath);
            GiaiThuong Prize;
            if (a.Length != 0) // khi dữ liệu chưa có người dùng nào khi đọc file sẽ lỗi
            {
                for (int i = 0; i < a.Length; ++i)
                {
                    string[] MySubString = a[i].Split(' ');

                    Prize = new GiaiThuong();
                    Prize.NgayMua1 = DateTime.Parse(MySubString[0]);

                    Prize.LoaiVe1 = int.Parse(MySubString[2]);

                    int j = 4;
                    List<int> KetQuaQuaySo = new List<int>();
                    KetQuaQuaySo.Add(int.Parse(MySubString[4]));

                    while (j < MySubString.Length - 2)
                    {
                        KetQuaQuaySo.Add(int.Parse(MySubString[++j]));

                    }
                    Prize.ThongTinVeTrungThuong1 = KetQuaQuaySo;

                    Prize.SoTienTrung1 = double.Parse(MySubString[++j]);

                    DanhSachGiaiThuong.ListGiaiThuong1.Add(Prize);
                }
            }
        }
        private void SapXepTheoNgayDanhSachVeDatMua()
        {
            //0: tăng dần
            //1: giảm dần
            for (int i = 0; i < DanhSachVeDatMua.ListVeDatMua1.Count - 1; ++i)
            {
                for (int j = i + 1; j < DanhSachVeDatMua.ListVeDatMua1.Count; ++j)
                {
                    if (DanhSachVeDatMua.ListVeDatMua1[i].NgayMua1.Date < DanhSachVeDatMua.ListVeDatMua1[j].NgayMua1.Date)
                    {
                        Ve temp = DanhSachVeDatMua.ListVeDatMua1[i];
                        DanhSachVeDatMua.ListVeDatMua1[i] = DanhSachVeDatMua.ListVeDatMua1[j];
                        DanhSachVeDatMua.ListVeDatMua1[j] = temp;

                    }
                }

            }
        }

        private void SapXepTheoNgayDanhSachGiaiThuong()
        {
            //0: tăng dần
            //1: giảm dần
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
        private void Form1_Load(object sender, EventArgs e)
        {
            DocFileDanhSachThongTinNguoiDung();

            DocFileDanhSachGiaiThuong();

            DocFileDanhSachVeDaMua();

            SapXepTheoNgayDanhSachVeDatMua();

            SapXepTheoNgayDanhSachGiaiThuong();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
            }    
            else
            {
                e.Cancel = true;
            }    
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            if(txtTenDangNhap.Text != "" && txtMatKhau.Text != "")
            {
                btnDangNhap.Enabled = true;
            }    
            else
            {
                btnDangNhap.Enabled = false;
            }    
        }
    }
}
