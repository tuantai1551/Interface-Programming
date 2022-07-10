using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_Lý_Học_Sinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            
            string Name;
            int Gender;
            double Math, Phy, Chem;
            //Họ và tên
            Name = txtTen.Text;

            //Giới tính
            if (rdNam.Checked)
            {
                Gender = 1;
            }
            else if (rdNu.Checked)
            {
                Gender = 2;

            }
            else if (rdGay.Checked)
            {
                Gender = 3;
            }
            else
            {
                Gender = 4;
            }

            //Điểm toán, lý, hóa

            //try
            //{
            //    Math = double.Parse(txtToan.Text);
            //}
            //catch
            //{
            //    MessageBox.Show("Kieu du leu khong hop le. Xin kiem tra lai");
            //    txtToan.Clear();
            //    txtToan.Focus();
            //}

            //try
            //{
            //    Chem = double.Parse(txtHoa.Text);
            //}
            //catch
            //{
            //    MessageBox.Show("Kieu du leu khong hop le. Xin kiem tra lai");
            //    txtHoa.Clear();
            //    txtHoa.Focus();
            //}

            //try
            //{
            //    Phy = double.Parse(txtLy.Text);
            //}
            //catch
            //{
            //    MessageBox.Show("Kieu du leu khong hop le. Xin kiem tra lai");
            //    txtLy.Clear();
            //    txtLy.Focus();
            //}

            Math = double.Parse(txtToan.Text);
            Chem = double.Parse(txtHoa.Text);
            Phy = double.Parse(txtLy.Text);

            HocSinh hs = new HocSinh(Name, Gender, Math, Phy, Chem);



            //Điểm trung bình
            double AverageMark = hs.CalcAverageMark();
            lblDiemTrungBinh.Text += AverageMark.ToString();

            //Xếp loại
            string Classify = hs.classify();
            lblXepLoai.Text += Classify;



        }
    }
}
