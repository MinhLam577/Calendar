using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Calendar
{
    class AppointmentDAL
    {
        CalendarDB db = new CalendarDB();
        DataTable dt = null;
        private static AppointmentDAL instance;
        public static AppointmentDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new AppointmentDAL();
                return instance;
            }
            private set { }
        }
        public DataTable CreateDataTable()
        {
            dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[] {
                new DataColumn{ColumnName = "STT", DataType = typeof(int)},
                new DataColumn{ColumnName = "APPID", DataType = typeof(int)},
                new DataColumn{ColumnName = "APPName", DataType= typeof(string)},
                new DataColumn{ColumnName = "HostID", DataType = typeof(string)},
                new DataColumn{ColumnName = "HostName", DataType = typeof(string)},
                new DataColumn{ColumnName = "Gmail", DataType = typeof (string)},
                new DataColumn{ColumnName = "DateAppointmentStart", DataType = typeof(DateTime)},
                new DataColumn{ColumnName = "DateAppointmentEnd", DataType = typeof(DateTime)},
            });
            return dt;
        }
        public DataTable GetListAllAppointMent()
        {
            dt = CreateDataTable(); int cnt = 1;
            var dbs = (from i in db.Appointments
                       join j in db.ListUserInAppointments on i.AppointmentID equals j.AppointmentID into joined from k in joined.DefaultIfEmpty()
                       join z in db.People on k.HostID equals z.PersonID
                       select new
                       {
                           i.AppointmentID, i.AppName, i.DateAppointmentStart, i.DateAppointmentEnd, 
                           z.PersonID, z.PersonName, z.Gmail
                       }
                       ).ToList().Distinct();
            foreach (var i in dbs)
            {
                dt.Rows.Add(cnt++, i.AppointmentID,
                           i.AppName,
                           i.PersonID,
                           i.PersonName,
                           i.Gmail,
                           i.DateAppointmentStart,
                           i.DateAppointmentEnd);
            }
            return dt;
        }
        public bool CheckDatetime(DateTime datestart, DateTime dateend)
        {
            return datestart < dateend;
        }
        public bool AddAppointment(Appointment appointment)
        {
            db.Appointments.Add(appointment);
            return db.SaveChanges() > 0;
        }
        public bool ReplaceAppointment(Appointment appointment)
        {
            db.Entry(appointment).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges() > 0;
        }
        public bool CheckUserIsInAPP(int userId)
        {
            return (from i in db.Appointments
                    join j in db.ListUserInAppointments on i.AppointmentID equals j.AppointmentID
                    join z in db.People on j.HostID equals z.PersonID
                    select new
                    {
                        j.UserID
                    }).ToList().Distinct().Any(a => (int)a.UserID == userId);
        }
        public bool CheckHostAlready_HasSameDateStart_DateEnd_Diff_NameAPP(int hostID, string APPName, DateTime datestart, DateTime dateend)
        {
            return (from i in db.Appointments
                    join j in db.ListUserInAppointments on i.AppointmentID equals j.AppointmentID
                    join z in db.People on j.HostID equals z.PersonID
                    select new
                    {
                        j.HostID,
                        i.DateAppointmentStart,
                        i.DateAppointmentEnd,
                        i.AppName
                    }).ToList().Distinct().Any(s => (int)s.HostID == hostID && !s.AppName.Equals(APPName) 
                    && (DateTime)s.DateAppointmentStart == datestart && (DateTime)s.DateAppointmentEnd == dateend);
        }
        public bool CheckHostAlreadyHas_SameDateStart_DateEnd_NameAPP(int hostID, string APPName, DateTime datestart, DateTime dateend)
        {
            return (from i in db.Appointments
                    join j in db.ListUserInAppointments on i.AppointmentID equals j.AppointmentID
                    join z in db.People on j.HostID equals z.PersonID
                    select new
                    {
                        j.HostID,
                        i.DateAppointmentStart,
                        i.DateAppointmentEnd,
                        i.AppName
                    }).ToList().Distinct().Any(s => (int)s.HostID == hostID && s.AppName.Equals(APPName)
                    && (DateTime)s.DateAppointmentStart == datestart && (DateTime)s.DateAppointmentEnd == dateend);
        }
        public bool CheckAPPAlreadyHasSameName_DateStart_DateEnd(string APPName, DateTime datestart, DateTime dateend)
        {
            return (from i in db.Appointments
                    join j in db.ListUserInAppointments on i.AppointmentID equals j.AppointmentID
                    join z in db.People on j.HostID equals z.PersonID
                    select new
                    {
                        i.DateAppointmentStart,
                        i.DateAppointmentEnd,
                        i.AppName
                    }).ToList().Distinct().Any(s => s.AppName.Equals(APPName) && (DateTime)s.DateAppointmentStart == datestart && (DateTime)s.DateAppointmentEnd == dateend);
        }
        public bool? CheckUserIsInGroup(int UserID, string APPName, DateTime datestart, DateTime dateend)
        {
            bool? check = null;
            var data = (from i in db.Appointments
                        join j in db.ListUserInAppointments on i.AppointmentID equals j.AppointmentID
                        join z in db.People on j.HostID equals z.PersonID
                        select new
                        {
                            j.UserID,
                            i.AppName,
                            i.DateAppointmentStart,
                            i.DateAppointmentEnd
                        }).Where(s => s.AppName.Equals(APPName) && (DateTime)s.DateAppointmentStart == datestart && (DateTime)s.DateAppointmentEnd == dateend).ToList().Distinct();
            if (data != default)
            {
                foreach(var i in data)
                {
                    if((int)i.UserID == UserID)
                    {
                        check = true;
                        break;
                    }
                }
                if (check == null)
                    check = false;                    
            }
            return check;
        }
        public Appointment GetAPPByID(int IDAPP)
        {
            return db.Appointments.Where(s => s.AppointmentID == IDAPP).FirstOrDefault();
        }
        public Appointment GetAPPByName(string Name)
        {
            return db.Appointments.Where(s=>s.AppName == Name).FirstOrDefault();
        }
        public Appointment GetAppByName_DateStart_DateEnd(string Name, DateTime datestart, DateTime dateend)
        {
            Appointment app = null;
            var data = (from i in db.Appointments
                        join j in db.ListUserInAppointments on i.AppointmentID equals j.AppointmentID
                        join z in db.People on j.HostID equals z.PersonID
                        select new
                        {
                            i.AppointmentID,
                            i.AppName,
                            i.DateAppointmentStart,
                            i.DateAppointmentEnd
                        }).Where(s => s.AppName.Equals(Name) && (DateTime)s.DateAppointmentStart == datestart && (DateTime)s.DateAppointmentEnd == dateend).ToList().Distinct().FirstOrDefault();
            if (data != null)
            {
                app = new Appointment
                {
                    AppointmentID = data.AppointmentID,
                    AppName = data.AppName,
                    DateAppointmentStart = data.DateAppointmentStart,
                    DateAppointmentEnd = data.DateAppointmentEnd,
                };
            }
            return app;
        }
        public Appointment GetAppByHostID_DateStart_DateEnd(int hostID, DateTime datestart, DateTime dateend)
        {
            Appointment app = null;
            var data = (from i in db.Appointments
                        join j in db.ListUserInAppointments on i.AppointmentID equals j.AppointmentID
                        join z in db.People on j.HostID equals z.PersonID
                        select new
                        {
                            i.AppointmentID,
                            j.HostID,
                            i.AppName,
                            i.DateAppointmentStart,
                            i.DateAppointmentEnd
                        }).Where(item => (DateTime)item.DateAppointmentStart == datestart && (DateTime)item.DateAppointmentEnd == dateend && (int)item.HostID == hostID).ToList().Distinct().FirstOrDefault();
            if (data != null)
            {
                app = new Appointment
                {
                    AppointmentID = data.AppointmentID,
                    AppName = data.AppName,
                    DateAppointmentStart = data.DateAppointmentStart,
                    DateAppointmentEnd = data.DateAppointmentEnd,
                };
            }
            return app;
        }

    }
}
        

