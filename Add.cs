using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Text.Json;

namespace QuanLiNhanSu
{

    public class Add : IAdd
    {
        public List<Profile> Adding(string json1)
        {
            int amount = 0;

            for (; ; )
            {
                try
                {
                    Console.WriteLine("Nhap so luong nhan vien muon them: ");
                    amount = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Nhap khong hop le !");
                }
            }

            Profile[] profile = new Profile[amount];
            List<Profile>? members = new List<Profile>();

            members = JsonSerializer.Deserialize<List<Profile>>(json1);

            for (int i = 0; i < amount; i++)
            {

                profile[i] = new Profile();

                Console.WriteLine("Nhan vien thu {0}", i + 1);
                Console.WriteLine("Ho ten: ");
                profile[i].ten = Convert.ToString(Console.ReadLine());

                for (; ; )
                {
                    try
                    {
                        Console.WriteLine("Ngay sinh: ");
                        profile[i].ngay = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Thang sinh: ");
                        profile[i].thang = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Nam sinh: ");
                        profile[i].nam = Convert.ToInt32(Console.ReadLine());

                        if ((profile[i].ngay < 1 || profile[i].ngay > 31) ||
                            (profile[i].ngay > 29 && profile[i].thang == 2 && (profile[i].nam % 400 == 0 || profile[i].nam % 4 == 0)) ||
                            (profile[i].nam < 1950 || profile[i].nam > 2022) ||
                            (profile[i].thang < 1 || profile[i].thang > 12))
                            Console.WriteLine("Ngay sinh khong hop le !");
                        else break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Nhap khong hop le !");
                    }


                }

                Console.WriteLine("ID: ");
                profile[i].id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("1.Employee");
                Console.WriteLine("2.Manager");
                Console.WriteLine("3.CEO");

                for (; ; )
                {

                    try
                    {
                        Console.WriteLine("Chuc vu: ");
                        int GetRole = Convert.ToInt32(Console.ReadLine());

                        if (GetRole == 1)
                        {
                            profile[i].role = "Employee";
                            Employee employee = new Employee();
                            profile[i].BaseSalary = employee.SetSalary();
                            break;
                        }

                        else if (GetRole == 2)
                        {
                            profile[i].role = "Manager";
                            Manager manager = new Manager();
                            profile[i].BaseSalary = manager.SetSalary();
                            break;
                        }
                        else if (GetRole == 3)
                        {
                            profile[i].role = "CEO";
                            CEO ceo = new CEO();
                            profile[i].BaseSalary = ceo.SetSalary();
                            break;
                        }
                        else Console.WriteLine("Nhap khong hop le !");
                    }

                    catch (FormatException) { Console.WriteLine("Nhap khong hop le !"); }

                }
            }
            members.AddRange(profile);
            Console.WriteLine("Them nhan vien thanh cong !");
            return members;
        }
    }
}


    



