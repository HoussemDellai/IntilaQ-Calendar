using System;
using System.Collections.Generic;
using System.Text;
//using Syncfusion.DocIO.DLS;

namespace IntilaQ.Calendar
{
    public class EventItem
    {

        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime StartsAt { get; set; }

        public DateTime EndsAt { get; set; }

        public string Location { get; set; }

        public string Organizer { get; set; }

        public int NumberOfAttendees { get; set; }

        public string Color { get; set; }
    }
}
