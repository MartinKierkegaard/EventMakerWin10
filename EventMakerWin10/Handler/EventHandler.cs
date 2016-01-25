using EventMakerWin10.ViewModel;

namespace EventMakerWin10.Handler
{
    public class EventHandler
    {

        private EventViewModel eventViewModel;//= new EventViewModel();

        public EventHandler(EventViewModel eventViewModel)
        {
            //this.eventViewModel = new EventViewModel();
            this.eventViewModel = eventViewModel;
        }


        /// <summary>
        /// tilføjer ny event
        /// </summary>
        public void AddEvent()
        {
            eventViewModel.EventCatalogSingleton.AddEvent(eventViewModel.NewEvent);
        }

    }
}
