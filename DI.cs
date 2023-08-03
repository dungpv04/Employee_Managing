using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhanSu
{

    public interface IShow
    {
        public string Display(string json1);
    }

    public interface IDel
    {
        public List<Profile> Deleting(string json);
    }

    public interface IAdd
    {
        public List<Profile> Adding(string json1);
    }

    public interface ISalary
    {
        public void Display();
    }

    public interface ISalaryShow
    {
        public void Display();
    }

    public interface ISearch
    {
        public string Searching(string json);
    }

    public interface IData_Loading
    {
        public string Load();
        public string Save(List<Profile> profile);
    }
}

    

