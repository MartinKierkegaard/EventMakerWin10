using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using EventMakerWin10.Common;
using EventMakerWin10.Model;
using EventHandler = EventMakerWin10.Handler.EventHandler;

namespace EventMakerWin10.ViewModel
{
   public class EventViewModel
    {
       public EventCatalogSingleton EventCatalogSingleton { get; private set; }
       public EventHandler EventHandler { get; private set; }
       public Event NewEvent { get; set; }

       //public DateTimeOffset DateTime { get; set; }
       //public TimeSpan TimeSpan { get; set; }

       public ICommand AddEventCommand { get; set; }
        //public ICommand TestCommand { get; set; }
        //public ICommand TestCommand1 { get; set; }


        public EventViewModel()
       {
            EventHandler = new Handler.EventHandler(this);
            EventCatalogSingleton = EventCatalogSingleton.Instance;
           
            NewEvent = new Event();
            AddEventCommand = new RelayCommand(EventHandler.AddEvent);

            //Action<Event> testAction = TestAddEvent;

            //TestCommand = new RelayArgCommand<Event>(testAction);
            //TestCommand1 = new RelayArgCommand<Event>(delegate(Event ev) {TestAddEvent(ev);} );
           

        }


       // private void TestAddEvent(Event nyEvent)
       //{
           
       //}


    }
}
