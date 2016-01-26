using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMakerWin10.Model
{
    public class EventCatalogSingleton
    {
        private static EventCatalogSingleton _instance;//= new EventCatalogSingleton();
       public ObservableCollection<Event> Events { get;  set; }

       public static EventCatalogSingleton Instance
        {
            get { return _instance ?? (_instance = new EventCatalogSingleton()); }
            //get { return _instance; }
        }

        /// <summary>
        /// tilføjer et nyt event til ObservableCollection'en event 
        /// </summary>
        /// <param name="nytEvent"></param>
        public void AddEvent(Event nytEvent)
        {
            Events.Add(nytEvent);
        }

        private EventCatalogSingleton()
        {
            Events = new ObservableCollection<Event>();

            addEventData();

        }

        private void addEventData()
        {
            Events.Add(new Event
            {
                Id = 1,
                Description = "Pitching 2end semester Projects",
                Place = "Auditorium 202",
                DateTime = new DateTime(2016, 12, 24, 9, 0, 0),
                Name = "De studerende fremlægger deres eksamensprojekt"
            });

            Events.Add(new Event
            {
                Id = 2,
                Description = "Eksamen",
                Place = "Auditorium 202",
                DateTime = new DateTime(2016, 12, 24, 9, 0, 0),
                Name = "De studerende fremlægger deres eksamensprojekt"
            });
        }
    }
}
