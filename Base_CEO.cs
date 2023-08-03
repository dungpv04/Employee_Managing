using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhanSu
{
    public class CEO : Profile
    {
        public double SetSalary()
        {
            BaseSalary = 200000;
            return BaseSalary;
        }
        public double Salary(double hrs, double sal)
        {
            LastSalary = sal * hrs;
            return LastSalary;
        }
    }
}
