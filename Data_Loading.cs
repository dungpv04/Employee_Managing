using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace QuanLiNhanSu
{
    internal class Data_Loading : IData_Loading
    {

        public string Load() 
        {
            string json1 = "";
            try
            {
                json1 = File.ReadAllText(@"E:\\data\\MemberList\\Members.json");
            }
            catch (System.IO.FileNotFoundException)
            {
                string empty = "[]";
                File.WriteAllText(@"E:\\data\\MemberList\\Members.json", empty);
                json1 = empty;
            }

            return json1;
        }

        public string Save(List<Profile> profile)
        {
            string json = JsonSerializer.Serialize(profile);
            File.WriteAllText(@"E:\\data\\MemberList\\Members.json", json);
            string success = "Luu danh sach thanh cong";
            return success;
        }

    }
}
