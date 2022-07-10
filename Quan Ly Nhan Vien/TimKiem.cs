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
    public partial class TimKiem : Form
    {
        public TimKiem()
        {
            InitializeComponent();
        }

        public int LuaChon;
        public string DuLieu;
        private void TimKiem_Load(object sender, EventArgs e)
        {
            cbTimKiem.Items.Add("Tìm kiếm theo mã số");
            cbTimKiem.Items.Add("Tìm kiếm theo tên");

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (cbTimKiem.Text == "Tìm kiếm theo mã số")
            {
                LuaChon = 0;
            }
            else
            {
                LuaChon = 1;
            }

            DuLieu = txtDuLieu.Text;

            this.Close();
        }
    }
}
