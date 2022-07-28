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
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApp1
{
    public partial class Mua3So : Form
    {
        public Mua3So()
        {
            InitializeComponent();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            ChonSo.LuaChon = 3;
            ChonSo FormChonSo = new ChonSo();
            FormChonSo.ShowDialog();

            if(ChonSo.List3SoDuocChon.Count > 0)
            {
                txtSo1.Text = ChonSo.List3SoDuocChon[0].ToString();
                txtSo2.Text = ChonSo.List3SoDuocChon[1].ToString();
                txtSo3.Text = ChonSo.List3SoDuocChon[2].ToString();
            }    



        }

        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int So1 = rd.Next(0, 99);
            int So2 = rd.Next(0, 99);
            int So3 = rd.Next(0, 99);

            txtSo1.Text = So1.ToString();
            txtSo2.Text = So2.ToString();
            txtSo3.Text = So3.ToString();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chưa", " Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Ghi vào trong file
                string directoryPath = Application.StartupPath + @"\DanhSachVeDaMua.TXT";
                Form1 frm1 = new Form1();
                //Ghi file
                string today = DateTime.Now.ToString("MM/dd/yyyy");

                //Thêm vào danh sách vé đã mua
                List<int> SoDaMua = new List<int>();

                SoDaMua.Add(int.Parse(txtSo1.Text));
                SoDaMua.Add(int.Parse(txtSo2.Text));
                SoDaMua.Add(int.Parse(txtSo3.Text));

                Ve Ticket = new Ve(Form1.TenDangNhap, DateTime.Parse(today), 3, cbSoLuongVe.SelectedIndex + 1, SoDaMua);

                DanhSachVeDatMua.ListVeDatMua1.Add(Ticket);

                FileStream fs = null;
                fs = new FileStream(directoryPath, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();

                bf.Serialize(fs, DanhSachVeDatMua.ListVeDatMua1);
                fs.Close();

                MessageBox.Show("Bạn đã mua thành công", "Thông báo", MessageBoxButtons.OK);



                //GHi file thành công và xóa dữ liệu ở các ô textbox
                txtSo1.Clear();
                txtSo2.Clear();
                txtSo3.Clear();
                cbSoLuongVe.SelectedIndex = 0;
            }


        }

        private void txtSo1_TextChanged(object sender, EventArgs e)
        {
            if(txtSo1.Text != "" && txtSo2.Text != "" && txtSo3.Text != "")
            {
                btnXacNhan.Enabled = true;
            }
            else
            {
                btnXacNhan.Enabled = false;
            }
        }

        private void Mua3So_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; ++i)
            {
                cbSoLuongVe.Items.Add(i);
            }

            cbSoLuongVe.SelectedIndex = 0;
        }
    }
}
