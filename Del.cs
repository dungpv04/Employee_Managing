using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace QuanLiNhanSu
{
    public class Del : IDel
    {


        public List<Profile> Deleting(string json)
        {
            List<Profile> members = new List<Profile>();
            members = JsonSerializer.Deserialize<List<Profile>>(json);

            if (json == "" || json == "[]")
            {
                Console.WriteLine("Danh sach trong");
            }
            else
            {

                int id = 0;

                for (; ; )
                {
                    try
                    {
                        Console.WriteLine("Nhap id nhan vien can xoa(nhap 0 de thoat): ");
                        id = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Nhap khong hop le !");
                    }
                }

                bool found = false;
                foreach (Profile i in members)
                {

                    try
                    {
                        if (i.id == id)
                        {
                            Console.WriteLine("Ban co muon xoa {0} {1} sinh ngay {2}/{3}/{4} (y/n) ?", i.role, i.ten, i.ngay, i.thang, i.nam);
                            string choose = Convert.ToString(Console.ReadLine());
                            found = true;
                            if (choose == "y")
                            {
                                members.Remove(i);
                                Console.WriteLine("Da xoa nhan vien !");
                                break;
                            }
                            else if (choose == "n")
                            {
                                Console.WriteLine("Khong xoa nhan vien !");
                                break;
                            }

                        }
                        
                        else if (id == 0)
                        {
                            Console.WriteLine("Da thoat !");
                            break;
                        } 
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Nhap khong hop le !");
                    }

                }

                if(found == false) Console.WriteLine("Khong tim thay nhan vien !");

            }
            return members;
        }

    }

}

    

