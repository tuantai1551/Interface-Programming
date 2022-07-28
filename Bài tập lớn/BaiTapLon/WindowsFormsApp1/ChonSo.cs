using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ChonSo : Form
    {
        public ChonSo()
        {
            InitializeComponent();
        }
         static public List<int> List3SoDuocChon = new List<int>();
         static public List<int> List4SoDuocChon = new List<int>();
         static public List<int> List5SoDuocChon = new List<int>();
         static public int LuaChon;

        void LuuCacSoVaoList(List<int> ListCacSo)
        {
            ListCacSo.Clear();
            if (MessageBox.Show("Bạn có chắc chưa", " Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (Control item in this.Controls)
                {
                    if (item.GetType() == typeof(CheckBox))
                    {
                        CheckBox cb = (CheckBox)item;
                        if (cb.Checked)
                        {
                            ListCacSo.Add(int.Parse(cb.Text));
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy suy nghĩ kĩ hơn nhé", " Thông báo", MessageBoxButtons.Yes, MessageBoxIcon.Question);
            }
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (LuaChon == 3)
            {
                LuuCacSoVaoList(List3SoDuocChon);
                if (List3SoDuocChon.Count != 3)
                {
                    MessageBox.Show("Bạn được phép chon 3 số", " Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Bạn đã chọn thành công", " Thông báo", MessageBoxButtons.OK);
                    this.Close();
                }
            }
            else if (LuaChon == 4)
            {
                LuuCacSoVaoList(List4SoDuocChon);
                if (List4SoDuocChon.Count != 4)
                {
                    MessageBox.Show("Bạn được phép chon 4 số", " Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Bạn đã chọn thành công", " Thông báo", MessageBoxButtons.OK);
                    this.Close();
                }
            }   
            else
            {
                LuuCacSoVaoList(List5SoDuocChon);
                if (List5SoDuocChon.Count != 5)
                {
                    MessageBox.Show("Bạn được phép chon 5 số", " Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Bạn đã chọn thành công", " Thông báo", MessageBoxButtons.OK);
                    this.Close();
                }
            }
        }

        private void ChonSo_Load(object sender, EventArgs e)
        {
            List3SoDuocChon.Clear();
            List4SoDuocChon.Clear();
            List5SoDuocChon.Clear();
        }
    }
}
