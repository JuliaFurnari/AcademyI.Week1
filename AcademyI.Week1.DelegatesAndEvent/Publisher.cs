using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyI.Week1.DelegatesAndEvent
{
    public class Publisher
    {
        public string PublisherName { get; set; }

        public Publisher(string name)
        {
            PublisherName = name;
        }

        public delegate void Notify(Publisher publisher, Notification notification); // Punta alla funzione di notifica

        public event Notify OnPublish; // evento di tipo Notify -> puntatore a funzione che prender in input
                                       // il publisher(colui che pubblica l'evento)
                                       // la notifica

        public void Publish()
        {
            if(OnPublish != null)
            {
                Notification notification = new Notification(DateTime.Now, "Nuova notifica!!!");
                OnPublish(this, notification);
            }
        }
    }
}
