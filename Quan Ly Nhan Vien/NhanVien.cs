using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Nhan_Vien
{
    class NhanVien
    {
        private string Name, Id, Department, Gender;
        private double CoSalary;
        private DateTime Date;

        public NhanVien()
        {
        }


        //Khởi tạo constructor
        public NhanVien(string name, string id, string department, double cosalary, string gender, DateTime date)
        {
            Name = name;
            ID = id;
            Department = department;
            CoSalary = cosalary;
            Gender = gender;
            Date = date;
        }

        //Getter - Setter
        public string NAME
        {
            get { return Name; }
            set { Name = value; }
        }
        public string ID
        {
            get { return Id; }
            set { Id = value; }
        }
        public DateTime DATE
        {
            get { return Date; }
            set { Date = value; }
        }
        public double COSALARY
        {
            get { return CoSalary; }
            set { CoSalary = value; }
        }
        public string GENDER
        {
            get { return Gender; }
            set { Gender = value; }
        }
        public string DEPARTMENT
        {
            get { return Department; }
            set { Department = value; }
        }
    }
}
