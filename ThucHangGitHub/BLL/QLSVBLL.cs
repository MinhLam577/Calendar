﻿using System;
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
<<<<<<< HEAD
        public List<string> GetCBCL()
        {
            return QLSVDAL.Instance.GetCBCL();
=======
        public void Delete(int id)
        {
            QLSVDAL.Instance.DeleteSV(id);
>>>>>>> main
        }
    }
}
