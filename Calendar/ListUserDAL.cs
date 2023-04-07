using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    class ListUserDAL
    {
        CalendarDB db = new CalendarDB();
        private static ListUserDAL instance;
        public static ListUserDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new ListUserDAL();
                return instance;
            }
            private set { }
        }
        public bool AddListUser(ListUserInAppointment listapp)
        {
            db.ListUserInAppointments.Add(listapp);
            return db.SaveChanges() > 0;
        }
        public bool UpdateListUser(ListUserInAppointment listapp)
        {
            db.Entry(listapp).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges() > 0;
        }

        public ListUserInAppointment GetListUserByNullUserID(int APPID)
        {
            var data = (from i in db.Appointments
                        join j in db.ListUserInAppointments on i.AppointmentID equals j.AppointmentID
                        join z in db.People on j.HostID equals z.PersonID
                        select new
                        {
                            j.UserID,
                            j.ListID,
                            i.AppointmentID
                        }).Where(s => s.UserID == null && s.AppointmentID == APPID).FirstOrDefault().ListID;
            return db.ListUserInAppointments.Where(s => s.ListID == data).FirstOrDefault();
        }
        public List<int?> GetListUserIDByAPPID(int APPID){
            return db.ListUserInAppointments.Where(a => (int)a.AppointmentID == APPID).Select(a => a.UserID).ToList();
        }
        public ListUserInAppointment GetListUserAPPByID(int ListID)
        {
            return db.ListUserInAppointments.Where(a => (int)a.AppointmentID == ListID).FirstOrDefault();
        }
    }
}
