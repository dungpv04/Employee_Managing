using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace QuanLiNhanSu
{
    public class Search: ISearch
    {

        public string Searching(string json)
        {

            
            if (json == "")
            {
                Console.WriteLine("Danh sach trong");
            }
            else
            {
                List<Profile> list = new List<Profile>();
                list = JsonSerializer.Deserialize<List<Profile>>(json);

                int id = 0;
                bool found = false;

                for (; ; )
                {
                    try
                    {
                        Console.WriteLine("Nhap id nhan vien can tim: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Nhap khong hop le !");
                    }
                }

                foreach (Profile i in list)
                {

                    if (i.id == id)
                    {

                        Console.WriteLine("Ket qua tim kiem: ");
                        Console.WriteLine("Ten: {0}, ngay sinh: {1}/{2}/{3}, chuc vu: {4}, muc luong co ban: {5}", i.ten, i.ngay, i.thang, i.nam, i.role, i.BaseSalary);
                        found = true;
                        break;
                    }

                }
                if (found == false) Console.WriteLine("Khong tim thay nhan vien nay !");
                

            }

            return json;

        }

    }
}
