using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace QuanLiNhanSu
{
    public class ShowSalary
    {

        public ShowSalary()
        {
            string DateList = "";
            try
            {
                DateList = File.ReadAllText(@"E:\\data\\MemberSalary\\list.txt");
            }
            catch (System.IO.FileNotFoundException)
            {
                string empty = "";
                File.WriteAllText(@"E:\\data\\MemberSalary\\list.txt", empty);
            }
            Console.WriteLine(DateList);
            Console.WriteLine("Nhap ngay gio muon xem: ");

            if (string.IsNullOrEmpty(DateList)) Console.WriteLine("Danh sach trong !");
            else
            {
                for (; ; )
                {
                    try
                    {
                        string gio, phut, ngay, thang, nam;
                        Console.WriteLine("Gio: ");
                        gio = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Phut: ");
                        phut = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Ngay: ");
                        ngay = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Thang: ");
                        thang = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Nam: ");
                        nam = Convert.ToString(Console.ReadLine());

                        string final = @"E:\\data\\MemberSalary\\" + gio + phut + ngay + thang + nam + ".json";
                        SalaryDisplay(final);
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Nhap khong hop le !");
                    }
                }
            }
            
        }

        void SalaryDisplay(string final)
        {

            List<Profile> members = new List<Profile>();
            try
            {
                string json = File.ReadAllText(final);

                members = JsonSerializer.Deserialize<List<Profile>>(json);
                Console.WriteLine("Ten          ID          Chuc vu     Luong co ban        so gio lam          Luong ngay");
                foreach (Profile i in members)
                {

                    Console.WriteLine("{0}          {1}       {2}        {3}        {4}         {5}", i.ten, i.id, i.role, i.BaseSalary, i.hours, i.LastSalary);
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("Khong tim thay ket qua !");

            }
        }


    }

    

}
