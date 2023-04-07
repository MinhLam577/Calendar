using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class AddOrEditForm : Form
    {
        public string APPID { get; set; }
        public Appointment app { get; set; }
        public Person host { get;set; }
        public event EventHandler ThayDoiThanhCong;
        public event EventHandler XemThongTinCuocHop;
        public AddOrEditForm()
        {
            InitializeComponent();
        }
        public AddOrEditForm(string APPID)
        {
            InitializeComponent();
            this.APPID = APPID;
        }
        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(APPID))
            {
                string tenps = txb_tenps.Text;
                string gmail = txb_gm.Text;
                string TenAPP = txb_nameapp.Text;
                int IDAPP = -1;
                DateTime Datestart = dtp_datestart.Value;
                DateTime DateEnd = dtp_dateend.Value;
                ListUserInAppointment listuser = null;
                Appointment app; Person h = null;
                if (string.IsNullOrEmpty(TenAPP) || string.IsNullOrEmpty(tenps) || string.IsNullOrEmpty(gmail))
                {
                    MessageBox.Show("Mời nhập vào thông tin còn trống");
                    return;
                }
                if (!AppointmentDAL.Instance.CheckDatetime(Datestart, DateEnd))
                {
                    MessageBox.Show("Ngày họp không hợp lệ");
                    return;
                }
                if (PersonDAL.Instance.GetPersonByGmailAndName(gmail, tenps) != default)
                    h = PersonDAL.Instance.GetPersonByGmailAndName(gmail, tenps);
                else
                {
                    MessageBox.Show("Có vẻ như Gmail không phải của bạn hoặc ko tồn tại trong hệ thống. Xin kiểm tra lại");
                    return;
                }
                app = new Appointment()
                {
                    AppName = TenAPP,
                    DateAppointmentStart = Datestart,
                    DateAppointmentEnd = DateEnd
                };
                try
                {
                    if (AppointmentDAL.Instance.CheckHostAlreadyHas_SameDateStart_DateEnd_NameAPP(h.PersonID, TenAPP, Datestart, DateEnd))
                    {
                        app.AppointmentID = AppointmentDAL.Instance.GetAppByHostID_DateStart_DateEnd(h.PersonID, Datestart, DateEnd).AppointmentID;
                        switch (MessageBox.Show("Cuộc họp của bạn vừa thêm đã được bạn tạo trước đó. Bạn có muốn xem thông tin đó không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                        {
                            case DialogResult.OK:
                                this.host = h;
                                this.app = app;
                                XemThongTinCuocHop(this, new EventArgs());
                                return;
                            case DialogResult.Cancel:
                                return;
                        }
                    }
                    if (AppointmentDAL.Instance.CheckHostAlready_HasSameDateStart_DateEnd_Diff_NameAPP(h.PersonID, TenAPP, Datestart, DateEnd))
                    {
                        IDAPP = AppointmentDAL.Instance.GetAppByHostID_DateStart_DateEnd(h.PersonID, Datestart, DateEnd).AppointmentID;
                        app = AppointmentDAL.Instance.GetAPPByID(IDAPP);
                        app.AppName = TenAPP;
                        app.DateAppointmentStart = Datestart;
                        app.DateAppointmentEnd = DateEnd;
                        switch (MessageBox.Show("Cuộc họp vừa thêm đã trùng khoảng thời gian với cuộc họp bạn đã tạo trước đó. Bạn có muốn thay thế cuộc họp trước đó không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                        {
                            case DialogResult.OK:
                                if (AppointmentDAL.Instance.ReplaceAppointment(app))
                                {
                                    switch (MessageBox.Show("Thay thế cuộc họp thành công"))
                                    {
                                        case DialogResult.OK:
                                            ThayDoiThanhCong(this, new EventArgs());
                                            break;
                                    }
                                }
                                return;
                            case DialogResult.Cancel:
                                MessageBox.Show("Bạn hãy chọn lịch khác phù hợp hơn");
                                return;
                        }
                    }
                    if (AppointmentDAL.Instance.CheckAPPAlreadyHasSameName_DateStart_DateEnd(TenAPP, Datestart, DateEnd))
                    {
                        if (AppointmentDAL.Instance.CheckUserIsInGroup(h.PersonID, TenAPP, Datestart, DateEnd) != null)
                        {
                            if (!(bool)AppointmentDAL.Instance.CheckUserIsInGroup(h.PersonID, TenAPP, Datestart, DateEnd))
                            {
                                app.AppointmentID = AppointmentDAL.Instance.GetAppByName_DateStart_DateEnd(TenAPP, Datestart, DateEnd).AppointmentID;
                                switch (MessageBox.Show("Cuộc họp của bạn vừa thêm đã được người khác tạo trước đó và bạn chưa có mặt trong cuộc họp. Bạn có muốn xem thông tin cuộc họp đó không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                                {
                                    case DialogResult.OK:
                                        this.host = h;
                                        this.app = app;
                                        XemThongTinCuocHop(this, new EventArgs());
                                        return;
                                    case DialogResult.Cancel:
                                        return;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Cuộc họp của bạn vừa thêm đã được người khác tạo trước đó và bạn đã có mặt trong cuộc họp");
                                return;
                            }
                        }
                    }
                    if (AppointmentDAL.Instance.AddAppointment(app))
                    {
                        IDAPP = AppointmentDAL.Instance.GetAPPByName(app.AppName).AppointmentID;
                        listuser = new ListUserInAppointment()
                        {
                            AppointmentID = IDAPP,
                            HostID = h.PersonID
                        };
                        if (ListUserDAL.Instance.AddListUser(listuser))
                        {
                            if (MessageBox.Show("Thêm cuộc họp thành công") == DialogResult.OK)
                            {
                                ThayDoiThanhCong(this, new EventArgs());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thêm cuộc họp thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
