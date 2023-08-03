using System;
using System.ComponentModel;
using System.IO;


namespace QuanLiNhanSu
{
    
    public class Process
    {
        public static void Main()
        {
            Data_Loading_DI data = new Data_Loading_DI(new Data_Loading());
            while (true)
            {
                Console.WriteLine("Chuong trinh quan li nhan su");
                Console.WriteLine("1.Xem danh sach");
                Console.WriteLine("2.Them nhan vien");
                Console.WriteLine("3.Xoa nhan vien");
                Console.WriteLine("4.Tim kiem nhan vien");
                Console.WriteLine("5.Cham cong");
                Console.WriteLine("6.Xem danh sach cham cong");
                Console.WriteLine("7.Thoat");

                
                try
                {
                    Console.WriteLine("Nhap lua chon: ");
                    int select = Convert.ToInt32(Console.ReadLine());

                    if (select == 1)
                    {
                        
                        Show_DI show = new Show_DI(new Show());
                        show.Display(data.Load());

                    }
                    else if (select == 2)
                    {

                        Add_DI add = new Add_DI(new Add());
                        data.Save(add.Adding(data.Load()));

                    }
                    else if (select == 3)
                    {

                        Show_DI show = new Show_DI(new Show());
                        Del_DI del = new Del_DI(new Del());
                        show.Display(data.Load());
                        data.Save(del.Deleting(data.Load()));


                    }
                    else if (select == 4)
                    {

                        Search_DI search = new Search_DI(new Search());
                        search.Searching(data.Load());

                    }
                    else if (select == 5)
                    {

                        

                    }
                    else if (select == 6)
                    {

                        

                    }
                    else if (select == 7) break;
                    else Console.WriteLine("Nhap khong hop le !");

                }
                catch (FormatException) {

                    Console.WriteLine("Nhap khong hop le !");
                }
                Console.WriteLine("An bat ki de tiep tuc ...");
                Console.ReadLine();
                Console.Clear();

            }
           
        }
    }

}