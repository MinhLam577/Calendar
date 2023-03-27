using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThucHangGitHub.DTO;
using ThucHangGitHub.DAL;
using System.Data;

namespace ThucHangGitHub.BLL
{
    class QLSVBLL
    {
        public DataTable GetRecord()
        {
            return QLSVDAL.Instance.GetRecord("All", "");
        }

        public DataTable SortSV(string yc, DataTable dt)
        {
            return QLSVDAL.Instance.SortSV(yc, dt);
        }
        DataTable dt = null;
        QLSVBLL db = null;
        private static QLSVBLL instance;
        public static QLSVBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new QLSVBLL();
                return instance;
            }
            private set { }
        }
        public DataTable GetRecord(string clname, string txt)
        {
            return QLSVDAL.Instance.GetRecord(clname, txt);
        }
        public List<string> GetCBCL()
        {
            return QLSVDAL.Instance.GetCBCL();
        }
        public void Delete(int id)
        {
            QLSVDAL.Instance.DeleteSV(id);
        }

    }
}
