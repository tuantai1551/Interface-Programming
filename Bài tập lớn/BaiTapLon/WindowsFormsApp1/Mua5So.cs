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
    public partial class Mua5So : Form
    {
        public Mua5So()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chưa", " Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string directoryPath = Application.StartupPath + @"\DanhSachVeDaMua.TXT";

                File.AppendAllText(directoryPath, Form1.TenDangNhap);
                File.AppendAllText(directoryPath, " - ");

                string today = DateTime.Now.ToString("MM/dd/yyyy");
                File.AppendAllText(directoryPath, today);
                File.AppendAllText(directoryPath, " - ");

                File.AppendAllText(directoryPath, "5");
                File.AppendAllText(directoryPath, " - ");

                File.AppendAllText(directoryPath, (cbSoLuongVe.SelectedIndex + 1).ToString());
                File.AppendAllText(directoryPath, " - ");

                File.AppendAllText(directoryPath, int.Parse(txtSo1.Text) < 10 ? "0" + txtSo1.Text : txtSo1.Text);

                File.AppendAllText(directoryPath, " ");
                File.AppendAllText(directoryPath, int.Parse(txtSo2.Text) < 10 ? "0" + txtSo2.Text : txtSo2.Text);

                File.AppendAllText(directoryPath, " ");
                File.AppendAllText(directoryPath, int.Parse(txtSo3.Text) < 10 ? "0" + txtSo3.Text : txtSo3.Text);

                File.AppendAllText(directoryPath, " ");
                File.AppendAllText(directoryPath, int.Parse(txtSo4.Text) < 10 ? "0" + txtSo4.Text : txtSo4.Text);

                File.AppendAllText(directoryPath, " ");
                File.AppendAllText(directoryPath, int.Parse(txtSo5.Text) < 10 ? "0" + txtSo5.Text : txtSo5.Text);


                File.AppendAllText(directoryPath, "\n");

                MessageBox.Show("Bạn đã mua thành công", " Thông báo", MessageBoxButtons.OK);

                //Thêm vào danh sách vé đã mua
                List<int> SoDaMua = new List<int>();
                SoDaMua.Add(int.Parse(txtSo1.Text));
                SoDaMua.Add(int.Parse(txtSo2.Text));
                SoDaMua.Add(int.Parse(txtSo3.Text));
                SoDaMua.Add(int.Parse(txtSo4.Text));
                SoDaMua.Add(int.Parse(txtSo5.Text));

                Ve Ticket = new Ve(Form1.TenDangNhap, DateTime.Parse(today), 5, cbSoLuongVe.SelectedIndex + 1, SoDaMua);

                DanhSachVeDatMua.ListVeDatMua1.Add(Ticket);

                txtSo1.Clear();
                txtSo2.Clear();
                txtSo3.Clear();
                txtSo4.Clear();
                txtSo5.Clear();
                cbSoLuongVe.SelectedIndex = 0;
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            ChonSo.LuaChon = 5;
            ChonSo FormChonSo = new ChonSo();
            FormChonSo.ShowDialog();

            txtSo1.Text = ChonSo.List5SoDuocChon[0].ToString();
            txtSo2.Text = ChonSo.List5SoDuocChon[1].ToString();
            txtSo3.Text = ChonSo.List5SoDuocChon[2].ToString();
            txtSo4.Text = ChonSo.List5SoDuocChon[3].ToString();
            txtSo5.Text = ChonSo.List5SoDuocChon[4].ToString();
        }

        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int So1 = rd.Next(0, 99);
            int So2 = rd.Next(0, 99);
            int So3 = rd.Next(0, 99);
            int So4 = rd.Next(0, 99);
            int So5 = rd.Next(0, 99);

            txtSo1.Text = So1.ToString();
            txtSo2.Text = So2.ToString();
            txtSo3.Text = So3.ToString();
            txtSo4.Text = So4.ToString();
            txtSo5.Text = So5.ToString();
        }

        private void txtSo1_TextChanged(object sender, EventArgs e)
        {
            if (txtSo1.Text != "" && txtSo2.Text != "" && txtSo3.Text != "" && txtSo4.Text != "" && txtSo5.Text != "")
            {
                btnXacNhan.Enabled = true;
            }
            else
            {
                btnXacNhan.Enabled = false;
            }
        }

        private void Mua5So_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; ++i)
            {
                cbSoLuongVe.Items.Add(i);
            }

            cbSoLuongVe.SelectedIndex = 0;
        }
    }
}
