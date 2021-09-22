using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyI.Week1.DelegatesAndEvent
{
    public class Notification
    {
        // Proprietà

        public string NotificationMessage { get; set; }
        public DateTime NotificationDate { get; set; }

        // Costruttore

        public Notification(DateTime date, string message)
        {
            NotificationDate = date;
            NotificationMessage = message;
        }

    }
}
