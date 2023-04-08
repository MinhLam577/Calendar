using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class AddReminderForm : Form
    {
        public AddReminderForm()
        {
            InitializeComponent();
        }
        private void btn_ok_Click(object sender, EventArgs e)
        {
            string tenps = txb_tenps.Text;
            string gmail = txb_gm.Text;
            string content = txb_nd.Text;
            DateTime duration = dtp_ktg.Value;
            Person h = null;
            Reminder rm = null;
            if (string.IsNullOrEmpty(tenps) || string.IsNullOrEmpty(gmail))
            {
                MessageBox.Show("Mời nhập vào thông tin còn trống");
                return;
            }
            if (PersonDAL.Instance.GetPersonByGmailAndName(gmail, tenps) != default)
                h = PersonDAL.Instance.GetPersonByGmailAndName(gmail, tenps);
            else
            {
                MessageBox.Show("Có vẻ như Gmail không phải của bạn hoặc ko tồn tại trong hệ thống. Xin kiểm tra lại");
                return;
            }
            rm = new Reminder()
            {
                PersonID = h.PersonID, Description = content, RMDTime = duration
            };
            try
            {
                if (ReminderDAL.Instance.AddReminder(rm))
                {
                    if(MessageBox.Show("Thêm reminder thành công") == DialogResult.OK)
                        this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thêm reminder thất bại");
            }
        }
    }
}
