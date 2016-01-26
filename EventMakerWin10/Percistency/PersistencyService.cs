using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventMakerWin10.Model;

namespace EventMakerWin10.Percistency
{
    public class PersistencyService
    {

        public static async void SaveEventsAsJsonAsync(ObservableCollection<Event>  events )
        {
            
        }

        public static async Task<List<Event>> LoadEventsFromJsonAsync()
        {
            
            return null;
        }

        public static async void SerializeEventsFileAsync(string eventsString, string fileName)
        {
            
        }


        public static async Task<string> DeSerializeEventsFileAsync(String fileName)
        {

            return "";
        }

    }
}
