using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace QuanLiNhanSu
{
    public class Salary
    {
        public Salary()
        {
            string json = "";
            try
            {
                json = File.ReadAllText(@"E:\\data\\MemberList\\Members.json");
            }
            catch (System.IO.FileNotFoundException)
            {
                string empty = "[]";
                File.WriteAllText(@"E:\\data\\MemberList\\Members.json", empty);
            }
            if (string.IsNullOrEmpty(json))
            {
                Console.WriteLine("Danh sach trong");
            }
            else
            {
                List<Profile> profile = new List<Profile>();
                profile = JsonSerializer.Deserialize<List<Profile>>(json);
                foreach (Profile i in profile)
                {
                    Console.WriteLine("{0} {1}, ID: {2}",i.role, i.ten, i.id);
                    Console.WriteLine("Nhap so gio da lam: ");
                    i.hours = Convert.ToDouble(Console.ReadLine());

                    if (i.role == "Employee")
                    {
                        Employee employee = new Employee();
                        i.LastSalary = employee.Salary(i.hours, i.BaseSalary);
                    }
                    else if (i.role == "Manager")
                    {
                        Manager manager = new Manager();
                        i.LastSalary = manager.Salary(i.hours, i.BaseSalary);
                    }
                    else if (i.role == "CEO")
                    {
                        CEO ceo = new CEO();
                        i.LastSalary = ceo.Salary(i.hours, i.BaseSalary);
                    }
                }
                SaveSalary(profile);
                
            }

            void SaveSalary(List<Profile> members)
            {
                DateTime date = DateTime.Now;
                string FileName = Convert.ToString(date.Hour) + Convert.ToString(date.Minute) + Convert.ToString(date.Day) + Convert.ToString(date.Month) + Convert.ToString(date.Year);
                string SaveTime = "ngay " + Convert.ToString(date) + "\n";
                string json = JsonSerializer.Serialize(members);
                string dir = @"E:\\data\\MemberSalary\\" + FileName + ".json";
                File.WriteAllText(dir, json);
                File.AppendAllText(@"E:\\data\\MemberSalary\\list.txt", SaveTime);
            }

        }

    }

    
}
