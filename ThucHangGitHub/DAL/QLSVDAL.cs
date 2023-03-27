using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThucHangGitHub.DTO;
namespace ThucHangGitHub.DAL
{
    class QLSVDAL
    {
        DataTable dt = null;
        QLSVDB db = new QLSVDB();
        private static QLSVDAL instance;
        public static QLSVDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new QLSVDAL();
                return instance;
            }
            private set { }
        }
        public DataTable CreatDataTable()
        {
            dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn{ColumnName = "ID", DataType = typeof(int)},
                new DataColumn{ColumnName = "Name", DataType = typeof(string)},
                new DataColumn{ColumnName = "Class", DataType = typeof(string)},
                new DataColumn{ColumnName = "Score", DataType = typeof(double)},
                new DataColumn{ColumnName = "Date", DataType = typeof(DateTime)},
                new DataColumn{ColumnName = "Gender", DataType = typeof(bool)},
                new DataColumn{ColumnName = "Picture", DataType = typeof(bool)},
                new DataColumn{ColumnName = "HocBa", DataType = typeof(bool)},
                new DataColumn{ColumnName = "Cccd", DataType = typeof(bool)}
            });
            return dt;
        }
        public DataTable GetRecord(string clname, string txt)
        {
            dt = CreatDataTable();
            if (clname != "All")
            {
                var list = (from s in db.SVs
                            join c in db.LopSHes
                            on s.SVCLID equals c.CLID
                            where c.CLName.Equals(clname) && s.SVName.Contains(txt)
                            select new { s.SVID, s.LopSH.CLName, s.SVName, s.SVDtb, s.SVNS, s.SVGender, s.SVPicture, s.SVHb, s.SVCccd }).ToList();
                foreach (var i in list)
                {
                    dt.Rows.Add(i.SVID, i.SVName, i.CLName, i.SVDtb, i.SVNS, i.SVGender, i.SVPicture, i.SVHb, i.SVCccd);
                }
            }
            else
            {
                var list = (from s in db.SVs
                            join c in db.LopSHes
                on s.SVCLID equals c.CLID
                            where s.SVName.Contains(txt)
                            select new { s.SVID, s.LopSH.CLName, s.SVName, s.SVDtb, s.SVNS, s.SVGender, s.SVPicture, s.SVHb, s.SVCccd }).ToList();
                foreach (var i in list)
                {
                    dt.Rows.Add(i.SVID, i.SVName, i.CLName, i.SVDtb, i.SVNS, i.SVGender, i.SVPicture, i.SVHb, i.SVCccd);
                }
            }
            return dt;
        }
        public void DeleteSV(int id)
        {
            var sv = db.SVs.Where(s => s.SVID == id).FirstOrDefault();
            db.SVs.Remove(sv);
            db.SaveChanges();
        }
    }
}
