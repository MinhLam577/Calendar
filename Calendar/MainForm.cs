using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class MainForm : Form
    {
        Appointment app = null;
        Person h = null;
        public MainForm()
        {
            InitializeComponent();
            LoadAppointmentDGV();
            btn_join.Enabled = false;
        }
        public void LoadAppointmentDGV()
        {
            dgv_app.DataSource = AppointmentDAL.Instance.GetListAllAppointMent();
        }
        public void LoadListUserDGV(string name)
        {
            dgv_user.DataSource = PersonDAL.Instance.GetListAllPersonInAppointment(name);
        }
        void LockButton()
        {
            btn_addapp.Enabled = false;
            btn_addrmd.Enabled = false;
        }
        void ResetButton()
        {
            btn_join.Enabled = false;
            btn_addapp.Enabled = true;
            btn_addrmd.Enabled = true;
        }
        void ResetDuLieu()
        {
            ResetButton();
            LoadAppointmentDGV();
        }
        private void btn_addapp_Click(object sender, EventArgs e)
        {
            DataTable dt = AppointmentDAL.Instance.CreateDataTable(); 
            app = new Appointment();
            h = new Person();
            AddOrEditForm f = new AddOrEditForm("");
            f.ThayDoiThanhCong += (o, a) =>
            {
                (o as AddOrEditForm).Close();
                this.LoadAppointmentDGV();
            };
            f.XemThongTinCuocHop += (o, a) =>
            {
                app = (o as AddOrEditForm).app;
                h = (o as AddOrEditForm).host;
                (o as AddOrEditForm).Close();
                dt.Rows.Add(1, app.AppointmentID, app.AppName, h.PersonID, h.PersonName, h.Gmail, app.DateAppointmentStart, app.DateAppointmentEnd);
                LockButton();
                btn_join.Enabled = true;
                dgv_app.DataSource = dt;
            };
            f.ShowDialog();
        }
        private void btn_join_Click(object sender, EventArgs e)
        {
            if (dgv_app.SelectedRows.Count == 1)
            {
                bool check = false, checknull = false; ListUserInAppointment listuser = null;
                int APPID = Convert.ToInt32(dgv_app.SelectedRows[0].Cells["APPID"].Value.ToString());
                List<int?> listuserid = ListUserDAL.Instance.GetListUserIDByAPPID(APPID);
                try
                {
                    if (listuserid != null)
                    {
                        foreach (int? i in listuserid)
                        {
                            if (i == null)
                            {
                                checknull = true;
                            }
                            else
                            {
                                if ((int)i == h.PersonID)
                                {
                                    check = true;
                                    break;
                                }
                            }
                        }
                        if (check)
                        {
                            MessageBox.Show("Bạn đã có mặt trong cuộc họp");
                            return;
                        }
                        else
                        {
                            if (checknull)
                            {
                                listuser = ListUserDAL.Instance.GetListUserByNullUserID(APPID);
                                listuser.UserID = h.PersonID;
                                if (ListUserDAL.Instance.UpdateListUser(listuser))
                                {
                                    MessageBox.Show("Tham gia cuộc họp thành công");
                                    ResetDuLieu();
                                    return;
                                }
                            }
                            else
                            {
                                listuser = new ListUserInAppointment()
                                {
                                    AppointmentID = APPID,
                                    HostID = ListUserDAL.Instance.GetListUserAPPByID(APPID).HostID,
                                    UserID = h.PersonID
                                };
                                if (ListUserDAL.Instance.AddListUser(listuser))
                                {
                                    MessageBox.Show("Tham gia cuộc họp thành công");
                                    ResetDuLieu();
                                    return;
                                }
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Tham gia cuộc họp thất bại");
                    ResetButton();
                }
                
            }
        }

        private void dgv_app_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_app.SelectedRows.Count > 0)
            {
                try
                {
                    string TenAPP = AppointmentDAL.Instance.GetAPPByID(Convert.ToInt32(dgv_app.SelectedRows[0].Cells["APPID"].Value.ToString())).AppName;
                    LoadListUserDGV(TenAPP);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void btn_addrmd_Click(object sender, EventArgs e)
        {
            AddReminderForm f = new AddReminderForm();
            f.ShowDialog();
        }
    }
}
