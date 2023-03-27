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
        }
        public void LoadDGV()
        {
            dgv_sv.DataSource = QLSVBLL.Instance.GetRecord("All", "");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = dgv_sv.DataSource as DataTable;
            dgv_sv.DataSource = QLSVBLL.Instance.SortSV(cb_sort.Text, dt);
        }

        private void cb_sort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
