using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Nhan_Vien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Danh sách nhân vien
        List<NhanVien> ListNhanVien = new List<NhanVien>();
        private void Form1_Load(object sender, EventArgs e)
        {
            //Thêm các phòng ban vào cbPhongBan
            cbPhongBan.Items.Add("Tiếp tân");
            cbPhongBan.Items.Add("Nấu ăn");
            cbPhongBan.Items.Add("Phục vụ");

            //index mặc định là "Tiếp tân";
            cbPhongBan.SelectedIndex = 0;

            lvDanhSach.FullRowSelect = true; // chọn nguyên 1 hàng
            lvDanhSach.GridLines = true;
            lvDanhSach.View = View.Details; // hiển thị chế đô chi tiết



            //Thêm các cột dữ liệu cho ListView
            // lvDanhSach.Columns.Add("Giá trị cột cần thêm", "khoảng cách giữa các cột);
            lvDanhSach.Columns.Add("Mã nhân viên", 115);
            lvDanhSach.Columns.Add("Tên nhân viên", 160);
            lvDanhSach.Columns.Add("Giới tính", 100);
            lvDanhSach.Columns.Add("Ngày sinh", 130);
            lvDanhSach.Columns.Add("Hệ số lương", 100);
            lvDanhSach.Columns.Add("Phòng ban", 150);

        }

        //Tính năng thêm
        public void AddStaffinListViewAndList()
        {
            //Thêm vào ListNhanVien
            NhanVien nv;
            if (rdNam.Checked)
            {
                nv = new NhanVien(txtTenNhanVien.Text, txtMaNhanVien.Text, cbPhongBan.Text, double.Parse(txtHeSoLuong.Text), "Nam", dtpNgaySinh.Value);
            }
            else
            {
                nv = new NhanVien(txtTenNhanVien.Text, txtMaNhanVien.Text, cbPhongBan.Text, double.Parse(txtHeSoLuong.Text), "Nữ", dtpNgaySinh.Value);
            }

            ListNhanVien.Add(nv);
            //Thêm vào ListView
            ListViewItem item = new ListViewItem(nv.ID);

            item.SubItems.Add(nv.NAME); // thêm Name

            if (rdNam.Checked)
            {
                item.SubItems.Add("Nam"); // thêm giới tính
            }
            else
            {
                item.SubItems.Add("Nữ");

            }

            item.SubItems.Add(nv.DATE.ToString("dd/MM/yyyy")); // thêm ngày sinh

            item.SubItems.Add(nv.COSALARY.ToString()); // thêm hệ số lương

            item.SubItems.Add(cbPhongBan.Text); // thêm phòng ban

            lvDanhSach.Items.Add(item);

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            //Kiểm tra xem người dùng đã nhập dữ liệu hết hay chưa
            bool Check = true;
            if (txtTenNhanVien.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập dữ liệu tên nhân viên. Xin kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Check = false;
                txtTenNhanVien.Focus();
            }
            if (txtMaNhanVien.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập dữ liệu mã nhân viên. Xin kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNhanVien.Focus();

            }
            if (rdNam.Checked == false && rdNu.Checked == false)
            {
                MessageBox.Show("Bạn chưa nhập dữ liệu giới tính. Xin kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Check = false;
            }
            //Kiểm tra kiểu dữ liệu của hệ số lương
            try
            {
                double cosalary = double.Parse(txtHeSoLuong.Text);
            }
            catch
            {
                MessageBox.Show("Kiểu dữ liệu hiệu số lương chưa đúng. Xin kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Check = false;
                txtHeSoLuong.Clear();
                txtHeSoLuong.Focus();
            }
            //Tới đây đã kiểm tra xong dữ liệu
            //Kiểm tra trùng, nếu ko trùng thì thêm vào ListView và List
            int size = ListNhanVien.Count;
            for (int i = 0; i < size; ++i)
            {
                if (txtMaNhanVien.Text == ListNhanVien[i].ID)
                {
                    MessageBox.Show("Đã trùng mã nhân viên. Xin kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Check = false;
                    break;
                }
            }
            if (Check)
            {
                AddStaffinListViewAndList();
            }

        }


        //Tính năng xóa

        //Tìm kiếm nhân viên
        private NhanVien TimKiemNhanVien(string id)
        {
            int size = ListNhanVien.Count;
            NhanVien nv = new NhanVien();
            for (int i = 0; i < size; ++i)
            {
                if (ListNhanVien[i].ID == id)
                {
                    nv = ListNhanVien[i];
                    break;
                    ;
                }
            }
            return nv;
        }

        NhanVien NhanVienDangChon;
        private void lvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {


            //chỉ xử lý khi listview có danh sách
            if (lvDanhSach.SelectedItems.Count > 0) // số lượng các NhanVien trong listView
            {
                //khi ấn double click vào 1 hàng thì sẽ đổ dữ liệu đó vào các textbox
                ListViewItem item = lvDanhSach.SelectedItems[0]; // luôn luôn là số 0

                string maNhanVien = item.SubItems[0].Text;  //cột đầu tiên
                NhanVienDangChon = TimKiemNhanVien(maNhanVien);

                //sau đó đổ dữ liệu vào textbox
                txtMaNhanVien.Text = item.SubItems[0].Text;

                txtTenNhanVien.Text = item.SubItems[1].Text;

                if (item.SubItems[2].Text == "Nam")
                {
                    rdNam.Checked = true;
                }
                else
                {
                    rdNu.Checked = true;
                }
                dtpNgaySinh.Value = NhanVienDangChon.DATE;

                txtHeSoLuong.Text = item.SubItems[4].Text;

                cbPhongBan.Text = item.SubItems[5].Text;

            }
        }

        //Tính năng xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (NhanVienDangChon != null)
            {
                if (MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Xóa trong ListNhanVien
                    string id = NhanVienDangChon.ID;
                    ListNhanVien.Remove(NhanVienDangChon);

                    //Xóa trong ListView
                    //Sau khi xóa nhân viên trong ListNhanVien thì phải cập nhật NhanVienDangChon là null để ko còn nhân viên nào đang được chọn
                    NhanVienDangChon = null;
                    int size = lvDanhSach.Items.Count;
                    for (int i = 0; i < size; ++i)
                    {
                        //So sánh id với cột 0 của hàng listView đang chọn
                        if (id == lvDanhSach.Items[i].SubItems[0].Text) // dòng i cột 0 là ID
                        {
                            lvDanhSach.Items.RemoveAt(i);
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Hãy suy nghĩ kĩ hơn lần sau nhé", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn nhân viên nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Tính năng sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (NhanVienDangChon != null)
            {
                if (MessageBox.Show("Bạn có muốn sửa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Không được sửa mã số
                    //Cập nhật dữ liệu cho nhân viên đang chọn

                    NhanVienDangChon.NAME = txtTenNhanVien.Text;
                    NhanVienDangChon.DATE = dtpNgaySinh.Value;
                    NhanVienDangChon.COSALARY = double.Parse(txtHeSoLuong.Text);
                    if(rdNam.Checked)
                    {
                        NhanVienDangChon.GENDER = "Nam";
                    }    
                    else
                    {
                        NhanVienDangChon.GENDER = "Nữ";
                    }
                    NhanVienDangChon.DEPARTMENT = cbPhongBan.Text;

                    //Sửa lại nhân viên trong mảng
                    for (int i = 0; i < ListNhanVien.Count; ++i)
                    {
                        if(NhanVienDangChon.ID == ListNhanVien[i].ID)
                        {
                            ListNhanVien[i] = NhanVienDangChon;
                            break;
                        }    
                    }

                    //Sửa lại nhân viên trong ListView
                    ListViewItem item = lvDanhSach.SelectedItems[0];

                    item.SubItems[1].Text = NhanVienDangChon.NAME;
                    item.SubItems[2].Text = NhanVienDangChon.GENDER;
                    item.SubItems[3].Text = NhanVienDangChon.DATE.ToString("dd/MM/yyyy");
                    item.SubItems[4].Text = NhanVienDangChon.COSALARY.ToString();
                    item.SubItems[5].Text = NhanVienDangChon.DEPARTMENT.ToString();


                }
                else
                {
                    MessageBox.Show("Hãy suy nghĩ kĩ hơn lần sau nhé", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn nhân viên nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Tính năng tìm kiếm
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            //Có 2 kiểu tìm kiếm
            //1. Tìm kiếm theo tên
            //2. Tìm kiếm theo mã số

            //Trước khi tìm kiếm thì phải tô listview màu trắng
            for (int i = 0; i < lvDanhSach.Items.Count; ++i)
            {
                lvDanhSach.Items[i].BackColor = Color.White;
            }

            //Mở ra 1 form mới
            TimKiem tk = new TimKiem();
            tk.ShowDialog();
            for (int i = 0; i < lvDanhSach.Items.Count; ++i)
            {
                if (tk.LuaChon == 0)
                {
                    //Nếu dữ liệu tìm kiếm là item thứ i cột 0 (là ID)
                    if (tk.DuLieu == lvDanhSach.Items[i].SubItems[0].Text)
                    {
                        lvDanhSach.Items[i].BackColor = Color.Red;
                        break;
                    }
                }
                else
                {
                    if (tk.DuLieu == lvDanhSach.Items[i].SubItems[1].Text)
                    {
                        lvDanhSach.Items[i].BackColor = Color.Red;
                        break;
                    }
                }
            }
        }


        //Tính năng sắp xếp
        void HoanViNhanVien(ref NhanVien nhanvien1, ref NhanVien nhanvien2)
        {
            NhanVien Temp = nhanvien1;
            nhanvien1 = nhanvien2;
            nhanvien2 = Temp;
        }
        void HoanViNhanVien(ref int a, ref int b)
        {
            int Temp = a;
            a = b;
            b = Temp;
        }
        void SapXepTheoHeSoLuong(int LuaChon)
        {
            //0: giảm dần
            //1: tăng dần
            int size = ListNhanVien.Count;
            for (int i = 0; i < size - 1; ++i)
            {
                for(int j = i + 1; j < size; ++j)
                {
                    if(LuaChon == 0)
                    {
                        if(ListNhanVien[i].COSALARY < ListNhanVien[j].COSALARY)
                        {
                            NhanVien temp = ListNhanVien[i];
                            ListNhanVien[i] = ListNhanVien[j];
                            ListNhanVien[j] = temp;
                        }    
                    }
                    else
                    {
                        if (ListNhanVien[i].COSALARY > ListNhanVien[j].COSALARY)
                        {
                            NhanVien temp = ListNhanVien[i];
                            ListNhanVien[i] = ListNhanVien[j];
                            ListNhanVien[j] = temp;
                        }
                    }    
                }    
            }
        }
        
        private void btnSapXep_Click(object sender, EventArgs e)
        {
            //Mở form
            SapXep sx = new SapXep();
            sx.ShowDialog();

            if (sx.LuaChon == 0)
            {
                SapXepTheoHeSoLuong(0);
            }
            else
            {
                SapXepTheoHeSoLuong(1);
            }

            //Xóa toàn bộ hàng và cột trong ListView để đổ dữ liệu mới vào
            lvDanhSach.Clear();

            //Thêm cột
            lvDanhSach.Columns.Add("Mã nhân viên", 115);
            lvDanhSach.Columns.Add("Tên nhân viên", 160);
            lvDanhSach.Columns.Add("Giới tính", 100);
            lvDanhSach.Columns.Add("Ngày sinh", 130);
            lvDanhSach.Columns.Add("Hệ số lương", 100);
            lvDanhSach.Columns.Add("Phòng ban", 150);

            lvDanhSach.FullRowSelect = true; // chọn nguyên 1 hàng
            lvDanhSach.GridLines = true;
            lvDanhSach.View = View.Details; // hiển thị chế đô chi tiết

            int size = ListNhanVien.Count;
            for (int i = 0; i < size; ++i)
            {
                ListViewItem item = new ListViewItem(ListNhanVien[i].ID);

                item.SubItems.Add(ListNhanVien[i].NAME); // thêm Name

                item.SubItems.Add(ListNhanVien[i].GENDER); // thêm giới tính


                item.SubItems.Add(ListNhanVien[i].DATE.ToString("dd/MM/yyyy")); // thêm ngày sinh

                item.SubItems.Add(ListNhanVien[i].COSALARY.ToString()); // thêm hệ số lương

                item.SubItems.Add(ListNhanVien[i].DEPARTMENT); // thêm phòng ban

                lvDanhSach.Items.Add(item);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Hãy suy nghĩ kĩ hơn lần sau nhé", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
