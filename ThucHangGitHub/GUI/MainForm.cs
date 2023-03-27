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

        private void btn_delelte_Click(object sender, EventArgs e)
        {
            QLSVBLL db = new QLSVBLL();
            if (dgv_sv.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow r in dgv_sv.SelectedRows)
                {
                   db.Delete(Convert.ToInt32(r.Cells["ID"].Value.ToString()));

                }
                LoadDGV();
            }
        }
    }
}
