using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Media;
using Syncfusion.UI.Xaml.Schedule;

namespace IntilaQ.Calendar
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private ScheduleAppointmentCollection _scheduleAppointmentCollection = new ScheduleAppointmentCollection();

        public ScheduleAppointmentCollection ScheduleAppointmentCollection
        {
            get { return _scheduleAppointmentCollection; }
            set
            {
                _scheduleAppointmentCollection = value; 
                OnPropertyChanged();
            }
        }

        //private List<EventItem> _eventItems;

        //public List<EventItem> EventItems
        //{
        //    get { return _eventItems; }
        //    set
        //    {
        //        _eventItems = value; 
        //        OnPropertyChanged();
        //    }
        //}

        public MainViewModel()
        {
            InitializeDataAsync();
        }

        private async Task InitializeDataAsync()
        {
            var dataServices = new DataServices();

            var eventItems = await dataServices.GetEventsAsync();

            ScheduleAppointmentCollection = new EventItemMapper().MapToScheduleAppointmentCollection(eventItems);

            //ScheduleAppointmentCollection = new ScheduleAppointmentCollection
            //{
            //    new ScheduleAppointment
            //    {²
            //        AllDay = false,
            //        AppointmentBackground = new SolidColorBrush(Colors.Teal),
            //        StartTime = DateTime.Now,
            //        EndTime = DateTime.Now.AddHours(2),
            //        Subject = "Meeting with Mohamed"
            //    },
            //     new ScheduleAppointment
            //    {
            //        AllDay = false,
            //        AppointmentBackground = new SolidColorBrush(Colors.Teal),
            //        StartTime = DateTime.Now.AddHours(3),
            //        EndTime = DateTime.Now.AddHours(1),
            //        Subject = "Meeting with Ali"
            //    },
            //};
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
