using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyI.Week1.DelegatesAndEvent
{
    public class Subscriber
    {
        public string SubscriberName { get; set; }
        public Subscriber(string name)
        {
            SubscriberName = name;
        }

        public void Subscribe(Publisher publisher)
        {
            publisher.OnPublish += OnNotificationReceived;
        }

        public void Unsubscribe(Publisher publisher)
        {
            publisher.OnPublish -= OnNotificationReceived;
        }

        public void OnNotificationReceived(Publisher publisher, Notification notification)
        {
            Console.WriteLine($"Ciao {SubscriberName}, il publisher {publisher.PublisherName} ha pubblicato un evento in data {notification.NotificationDate}");
        }
    }
}
