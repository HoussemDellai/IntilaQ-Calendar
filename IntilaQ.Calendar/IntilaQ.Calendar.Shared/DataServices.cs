using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Windows.Web.Http;
using Newtonsoft.Json;

namespace IntilaQ.Calendar
{
    public class DataServices
    {

        public async Task<List<EventItem>> GetEventsAsync()
        {
            
            var httpClient = new HttpClient();

            var eventItemsJson = await httpClient.GetStringAsync(new Uri("https://intilaqcalendar.azurewebsites.net/api/Events"));

            var eventItems = JsonConvert.DeserializeObject<List<EventItem>>(eventItemsJson);

            return eventItems;
        } 
    }
}
