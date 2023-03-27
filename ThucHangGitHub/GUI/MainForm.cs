using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThucHangGitHub.BLL;
using ThucHangGitHub.DAL;
using ThucHangGitHub.DTO;
namespace ThucHangGitHub.GUI
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
            LoadDGV();
            //LoadCBBCL();
        }
        public void LoadDGV()
        {
            dgv_sv.DataSource = QLSVDAL.Instance.GetRecord("All", "");
        }
        public void LoadCBBCL()
        {
            QLSVBLL qLSVBLL = new QLSVBLL();
            cb_ClassName.DataSource = qLSVBLL.GetCBCL();
        }
    }
}
