using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    class ReminderDAL
    {
        CalendarDB db = new CalendarDB();
        DataTable dt = null;
        private static ReminderDAL instance;
        public static ReminderDAL Instance
        {
            get
            {
                if(instance == null)
                    instance = new ReminderDAL();
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
                new DataColumn{ColumnName = "Duration", DataType = typeof(DateTime)},
                new DataColumn{ColumnName = "Description", DataType = typeof(string)}
            });
            return dt;
        }
        public DataTable GetListAllReminderByIDUser(int IDUser)
        {
            dt = CreateTable(); int cnt = 1;
            var data = db.Reminders.Where(p => (int)p.PersonID == IDUser).Select(p => new
            {
                p.Description, p.RMDTime
            }).ToList();
            foreach(var i in data)
            {
                dt.Rows.Add(cnt++, (DateTime)i.RMDTime, i.Description);
            }
            return dt;
        }
        public bool AddReminder(Reminder reminder)
        {
            db.Reminders.Add(reminder);
            return db.SaveChanges() > 0;
        }
        public bool UpdateReminder(Reminder reminder)
        {
            db.Entry(reminder).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges() > 0;
        }
    }
}
