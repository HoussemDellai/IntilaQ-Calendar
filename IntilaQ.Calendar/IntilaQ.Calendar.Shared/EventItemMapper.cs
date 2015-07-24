using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.UI.Xaml.Schedule;

namespace IntilaQ.Calendar
{
    public class EventItemMapper
    {

        public ScheduleAppointment MapTo(EventItem eventItem)
        {
            if (eventItem == null)
            {
                return null;
            }

            var scheduleAppointment = new ScheduleAppointment
            {
                Subject = eventItem.Title,
                StartTime = eventItem.StartsAt,
                EndTime = eventItem.EndsAt,
                Notes = eventItem.Description,
                Location = eventItem.Location,
            };

            return scheduleAppointment;
        }

        public List<ScheduleAppointment> MapToListScheduleAppointment(List<EventItem> eventItems)
        {
            if (eventItems == null || eventItems.Count == 0)
            {
                return null;
            }

            var scheduleAppointments = new List<ScheduleAppointment>();

            foreach (var eventItem in eventItems)
            {
                scheduleAppointments.Add(MapTo(eventItem));
            }

            return scheduleAppointments;
        }

        public ScheduleAppointmentCollection MapToScheduleAppointmentCollection(List<EventItem> eventItems)
        {
            if (eventItems == null || eventItems.Count == 0)
            {
                return null;
            }

            var scheduleAppointmentCollection = new ScheduleAppointmentCollection();

            foreach (var eventItem in eventItems)
            {
                scheduleAppointmentCollection.Add(MapTo(eventItem));
            }

            return scheduleAppointmentCollection;
        }
    }
}
