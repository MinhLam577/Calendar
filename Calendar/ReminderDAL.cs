using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    class ReminderDAL
    {
        CalendarDB db = new CalendarDB();
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
