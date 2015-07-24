using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.UI.Xaml.Schedule;

namespace IntilaQ.Calendar
{
    public class EventAppointment : ScheduleAppointment
    {

        public string Title
        { get; set; }

        public string Description
        { get; set; }

        public DateTime StartsAt
        { get; set; }

        public DateTime EndsAt
        { get; set; }

        //public string Location
        //{ get; set; }

        public string Organizer
        { get; set; }

        public int NumberOfAttendees
        { get; set; }

        public string Color
        { get; set; }
    }
}
