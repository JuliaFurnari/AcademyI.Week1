using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyI.Week1.DelegatesAndEvent
{
    public class Example
    {
        public static void EsempioEventi()
        {
            Publisher publisher1 = new Publisher("Publisher 1");
            Publisher publisher2 = new Publisher("Publisher 2");

            Subscriber subscriber1 = new Subscriber("Subscriber 1");
            Subscriber subscriber2 = new Subscriber("Subscriber 2");
            Subscriber subscriber3 = new Subscriber("Subscriber 3");

            subscriber1.Subscribe(publisher1);
            subscriber2.Subscribe(publisher1);
            subscriber3.Subscribe(publisher1);

            subscriber1.Subscribe(publisher2);

            publisher1.Publish();

            publisher2.Publish();
        }
    }
}
