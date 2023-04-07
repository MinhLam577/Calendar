using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    class PersonDAL
    {
        CalendarDB db = new CalendarDB();
        DataTable dt = null;
        private static PersonDAL instance;
        public static PersonDAL Instance
        {
            get
            {
                if(instance == null)
                    instance = new PersonDAL();
                return instance;
            }
            private set { }
        }
        public DataTable CreateTable()
        {
            dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn{ColumnName = "STT", DataType = typeof(int)},
                new DataColumn{ColumnName = "UserID", DataType =typeof(int)},
                new DataColumn{ColumnName = "UserName", DataType = typeof(string)},
                new DataColumn{ColumnName = "Gmail", DataType = typeof(string)}
            });
            return dt;
        }
        public Person GetPersonByGmailAndName(string gmail, string name)
        {
            return db.People.Where(s => s.PersonName.Equals(name) && s.Gmail.Equals(gmail)).FirstOrDefault();
        }
        public DataTable GetListAllPersonInAppointment(string APPName)
        {
            dt = CreateTable(); int cnt = 1;
            var data = (from i in db.Appointments
                        join j in db.ListUserInAppointments on i.AppointmentID equals j.AppointmentID
                        join z in db.People on j.UserID equals z.PersonID
                        where i.AppName == APPName
                        select new
                        {
                            z.PersonID,
                            z.PersonName,
                            z.Gmail
                        }).ToList();
            foreach (var item in data)
            {
                dt.Rows.Add(cnt++, item.PersonID, item.PersonName, item.Gmail);
            }
            return dt;
        }

    }
}
