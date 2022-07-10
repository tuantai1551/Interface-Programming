using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Học_Sinh
{
    class HocSinh
    {
        //Khai báo biến
        private double Math, Phy, Chem;
        private string Name;
        private int Gender;

        //Constructor
        public HocSinh()
        {
            Math = Phy = Chem = 0;
            Name = "";
            Gender = 1;
        }

        public HocSinh(string name, int gender, double math, double phy, double chem)
        {
            Name = name;
            Gender = gender;
            Math = math;
            Phy = phy;
            Chem = chem;
        }

        public double CalcAverageMark()
        {
            return (Math + Phy + Chem) / 3;
        }

        public string classify()
        {
            double AverageMark = CalcAverageMark();

            if(AverageMark >= 9 && AverageMark <= 10)
            {
                return "Xuất xắc";
            }
            else if (AverageMark >= 8 && AverageMark < 9)
            {
                return "Giỏi";
            }
            else if (AverageMark >= 7 && AverageMark < 8)
            {
                return "Khá";
            }
            else if (AverageMark >= 6 && AverageMark < 7)
            {
                return "Trung bình khá";
            }
            else if (AverageMark >= 5 && AverageMark <= 6)
            {
                return "Trung bình";
            }
            else if (AverageMark >= 2 && AverageMark < 5)
            {
                return "Yếu";
            }
            return "Kém";
        }
    }
}
