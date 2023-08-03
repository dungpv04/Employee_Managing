using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace QuanLiNhanSu
{
   
    public class Show : IShow
    {
       
       public string Display(string json1)
       {
 
            if (json1 == "" || json1 == "[]") Console.WriteLine("Danh sach trong");
            else
            {
                List<Profile> members = new List<Profile>();
                members = JsonSerializer.Deserialize<List<Profile>>(json1);
                Console.WriteLine("         Ten          ngay sinh           ID              Chuc vu             Luong co ban");
                foreach (Profile i in members)
                {
                    Console.WriteLine("{0}          {1}/{2}/{3}         {4}             {5}             {6}", i.ten, i.ngay, i.thang, i.nam, i.id, i.role, i.BaseSalary);
                }
            } 
               
          
            return json1;
       }

    }
}
