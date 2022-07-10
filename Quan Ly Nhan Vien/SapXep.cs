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
    public partial class SapXep : Form
    {
        public SapXep()
        {
            InitializeComponent();
        }

        public int LuaChon;
        private void SapXep_Load(object sender, EventArgs e)
        {
            cbSapXep.Items.Add("Giảm dần");
            cbSapXep.Items.Add("Tăng dần");

            cbSapXep.SelectedIndex = 0;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            LuaChon = cbSapXep.SelectedIndex;
            this.Close();

        }
    }
}
