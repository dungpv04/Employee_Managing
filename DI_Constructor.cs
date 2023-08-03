using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhanSu
{
    public class Data_Loading_DI
    {
        public IData_Loading _Data;
        public Data_Loading_DI(IData_Loading Data)
        {
            this._Data = Data;
        }

        public string Load()
        {
            return _Data.Load();
        }

        public string Save(List<Profile> profile)
        {
            return _Data.Save(profile);
        }

    }

    public class Show_DI
    {
        public IShow _ishow;

        public Show_DI(IShow ishow)
        {
            this._ishow = ishow;

        }
        public string Display(string json1)
        {

            return _ishow.Display(json1);
        }
    }


    public class Add_DI
    {
        public IAdd _iadd;
        public Add_DI(IAdd iadd)
        {
            this._iadd = iadd;

        }
        public List<Profile> Adding(string json1)
        {
            return _iadd.Adding(json1);
        }
    }

    public class Del_DI
    {
        public IDel _idel;

        public Del_DI(IDel idel)
        {
            this._idel = idel;

        }
        public List<Profile> Deleting(string json)
        {
            return _idel.Deleting(json);

        }
    }

    public class Search_DI
    {
        public ISearch _isearch;

        public Search_DI(ISearch isearch)
        {
            this._isearch = isearch;
        }

        public string Searching(string json) 
        {
            return _isearch.Searching(json);
        }
    }

}

