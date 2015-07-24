using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Syncfusion.UI.Xaml.Schedule;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace IntilaQ.Calendar
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        //Ellipse dayellipse, weekellipse, workweekellipse, monthellipse, timelineellipse;
        //TextBlock daytext, weektext, monthtext, workweektext, timelinetext;

        public MainPage()
        {
            InitializeComponent();

            //schedule.Appointments = new ScheduleAppointmentCollection
            //{
            //    new ScheduleAppointment
            //    {
            //        AllDay = false,
            //        AppointmentBackground = new SolidColorBrush(Colors.Teal),
            //        StartTime = DateTime.Now,
            //        EndTime = DateTime.Now.AddHours(2),
            //        Subject = "Meeting with Mohamed"
            //    }
            //};

            //schedule.AppointmentMapping
            //schedule.AllowEditing = false;
            //schedule.WorkStartHour = 8;
            //schedule.WorkEndHour = 21;
            //schedule.ShowNonWorkingHours = false;
            //schedule.TimeInterval = TimeInterval.ThirtyMin;

            schedule.AppointmentEditorOpening += (sender, args) =>
            {
                args.Cancel = true;
            };

            schedule.ContextMenuOpening += (sender, args) =>
            {
                args.Cancel = true;
            };

            //ApplicationLanguages.PrimaryLanguageOverride = "en-US";
            InitializeComponent();

            //stackpanel.Loaded += MainPage_Loaded;
            //Random ran = new Random();
            //DateTime today = DateTime.Now;
            //if (today.Month == 12)
            //{
            //    today = today.AddMonths(-1);
            //}
            //else if (today.Month == 1)
            //{
            //    today = today.AddMonths(1);
            //}
            //DateTime startMonth = new DateTime(today.Year, today.Month - 1, 1, 0, 0, 0);
            //DateTime endMonth = new DateTime(today.Year, today.Month + 1, 30, 0, 0, 0);
            //DateTime dt = new DateTime(today.Year, today.Month, 15, 0, 0, 0);
            //int day = (int)startMonth.DayOfWeek;
            //DateTime CurrentStart = startMonth.AddDays(-day);
            //ObservableCollection<SolidColorBrush> brush = new ObservableCollection<SolidColorBrush>();
            //brush.Add(new SolidColorBrush(Color.FromArgb(0xFF, 0xA2, 0xC1, 0x39)));
            //brush.Add(new SolidColorBrush(Color.FromArgb(0xFF, 0xD8, 0x00, 0x73)));
            //brush.Add(new SolidColorBrush(Color.FromArgb(0xFF, 0x1B, 0xA1, 0xE2)));
            //brush.Add(new SolidColorBrush(Color.FromArgb(0xFF, 0xE6, 0x71, 0xB8)));
            //brush.Add(new SolidColorBrush(Color.FromArgb(0xFF, 0xF0, 0x96, 0x09)));
            //brush.Add(new SolidColorBrush(Color.FromArgb(0xFF, 0x33, 0x99, 0x33)));
            //brush.Add(new SolidColorBrush(Color.FromArgb(0xFF, 0x00, 0xAB, 0xA9)));
            //brush.Add(new SolidColorBrush(Color.FromArgb(0xFF, 0xE6, 0x71, 0xB8)));

            //ScheduleAppointmentCollection AppoitnmentCollection = new ScheduleAppointmentCollection();
            //for (int i = 0; i < 90; i++)
            //{
            //    if (i % 7 == 0 || i % 7 == 6)
            //    {
            //        //add weekend appointments
            //        NonWorkingDays.Add(CurrentStart.AddDays(i));
            //    }
            //    else
            //    {
            //        //Add Workweek appointment
            //        WorkWeekDays.Add(CurrentStart.AddDays(i));
            //    }
            //}


            //for (int i = 0; i < 50; i++)
            //{
            //    DateTime date = WorkWeekDays[ran.Next(0, WorkWeekDays.Count)].AddHours(ran.Next(9, 17));
            //    AppoitnmentCollection.Add(new ScheduleAppointment()
            //    {
            //        StartTime = date,
            //        EndTime = date.AddHours(1),
            //        AppointmentBackground = brush[i % brush.Count],
            //        Subject = WorkWeekSubjects[i % WorkWeekSubjects.Count]
            //    });
            //}
            //int j = 0;
            //int k = 0;
            //int l = 0;

            //while (j < YearlyOccurranceSubjects.Count)
            //{
            //    DateTime date = NonWorkingDays[ran.Next(0, NonWorkingDays.Count)];
            //    AppoitnmentCollection.Add(new ScheduleAppointment()
            //    {
            //        StartTime = date,
            //        EndTime = date.AddHours(1),
            //        AppointmentBackground = brush[1],
            //        Subject = YearlyOccurranceSubjects[j]
            //    });
            //    j++;
            //}
            //while (k < MonthlyOccurranceSubjects.Count)
            //{
            //    DateTime date = NonWorkingDays[ran.Next(0, NonWorkingDays.Count)].AddHours(ran.Next(9, 23));
            //    AppoitnmentCollection.Add(new ScheduleAppointment()
            //    {
            //        StartTime = date,
            //        EndTime = date.AddHours(1),
            //        AppointmentBackground = brush[k],
            //        Subject = MonthlyOccurranceSubjects[k]
            //    });
            //    k++;
            //}
            //while (l < WeekEndOccurranceSubjects.Count)
            //{
            //    DateTime date = NonWorkingDays[ran.Next(0, NonWorkingDays.Count)].AddHours(ran.Next(0, 23));
            //    AppoitnmentCollection.Add(new ScheduleAppointment()
            //    {
            //        StartTime = date,
            //        EndTime = date.AddHours(1),
            //        AppointmentBackground = brush[l],
            //        Subject = WeekEndOccurranceSubjects[l]
            //    });
            //    l++;
            //}

            schedule.AppointmentEditorOpening += schedule_AppointmentEditorOpening;
            schedule.AppointmentEditorClosed += schedule_AppointmentEditorClosed;
            //schedule.Appointments = AppoitnmentCollection;

        }

        //void MainPage_Loaded(object sender, RoutedEventArgs e)
        //{
        //    dayellipse = ((VisualTreeHelper.GetChild(Day, 0) as StackPanel).Children[0] as Grid).Children[0] as Ellipse;
        //    daytext = (VisualTreeHelper.GetChild(Day, 0) as StackPanel).Children[1] as TextBlock;
        //    daytext.Foreground = new SolidColorBrush(Colors.White);
        //    dayellipse.Stroke = new SolidColorBrush(Colors.White);
        //    dayellipse.Fill = new SolidColorBrush(Colors.White);
        //    Day.Foreground = new SolidColorBrush(Color.FromArgb(0xFF, 0x47, 0x4F, 0x52));
        //    weekellipse = ((VisualTreeHelper.GetChild(Week, 0) as StackPanel).Children[0] as Grid).Children[0] as Ellipse;
        //    weekellipse.Stroke = new SolidColorBrush(Colors.White);
        //    weektext = (VisualTreeHelper.GetChild(Week, 0) as StackPanel).Children[1] as TextBlock;
        //    weektext.Foreground = new SolidColorBrush(Colors.White);
        //    workweekellipse = ((VisualTreeHelper.GetChild(WorkWeek, 0) as StackPanel).Children[0] as Grid).Children[0] as Ellipse;
        //    workweekellipse.Stroke = new SolidColorBrush(Colors.White);
        //    workweektext = (VisualTreeHelper.GetChild(WorkWeek, 0) as StackPanel).Children[1] as TextBlock;
        //    workweektext.Foreground = new SolidColorBrush(Colors.White);
        //    monthellipse = ((VisualTreeHelper.GetChild(Month, 0) as StackPanel).Children[0] as Grid).Children[0] as Ellipse;
        //    monthellipse.Stroke = new SolidColorBrush(Colors.White);
        //    monthtext = (VisualTreeHelper.GetChild(Month, 0) as StackPanel).Children[1] as TextBlock;
        //    monthtext.Foreground = new SolidColorBrush(Colors.White);
        //    timelineellipse = ((VisualTreeHelper.GetChild(TimeLine, 0) as StackPanel).Children[0] as Grid).Children[0] as Ellipse;
        //    timelineellipse.Stroke = new SolidColorBrush(Colors.White);
        //    timelinetext = (VisualTreeHelper.GetChild(TimeLine, 0) as StackPanel).Children[1] as TextBlock;
        //    timelinetext.Foreground = new SolidColorBrush(Colors.White);
        //}

        void schedule_AppointmentEditorClosed(object sender, AppointmentEditorClosedEventArgs e)
        {
            stackpanel.Visibility = Visibility.Visible;
        }

        void schedule_AppointmentEditorOpening(object sender, AppointmentEditorOpeningEventArgs e)
        {
            stackpanel.Visibility = Visibility.Collapsed;
        }

        void btn_ScheduleType_Click(object sender, RoutedEventArgs e)
        {
            Day.Foreground = new SolidColorBrush(Colors.White);
            //dayellipse.Fill = new SolidColorBrush(Colors.Transparent);
            Week.Foreground = new SolidColorBrush(Colors.White);
            //weekellipse.Fill = new SolidColorBrush(Colors.Transparent);
            WorkWeek.Foreground = new SolidColorBrush(Colors.White);
            //workweekellipse.Fill = new SolidColorBrush(Colors.Transparent);
            Month.Foreground = new SolidColorBrush(Colors.White);
            //monthellipse.Fill = new SolidColorBrush(Colors.Transparent);
            TimeLine.Foreground = new SolidColorBrush(Colors.White);
            //timelineellipse.Fill = new SolidColorBrush(Colors.Transparent);
            if (sender is AppBarButton)
            {
                (sender as AppBarButton).Foreground = new SolidColorBrush(Color.FromArgb(0xFF, 0x47, 0x4F, 0x52));

                switch ((sender as AppBarButton).Name)
                {
                    case "Day":
                        schedule.ScheduleType = ScheduleType.Day;
                        //dayellipse.Fill = new SolidColorBrush(Colors.White);
                        break;
                    case "Week":
                        schedule.ScheduleType = ScheduleType.Week;
                        //weekellipse.Fill = new SolidColorBrush(Colors.White);
                        break;
                    case "WorkWeek":
                        schedule.ScheduleType = ScheduleType.WorkWeek;
                        //workweekellipse.Fill = new SolidColorBrush(Colors.White);
                        break;
                    case "Month":
                        schedule.ScheduleType = ScheduleType.Month;
                        //monthellipse.Fill = new SolidColorBrush(Colors.White);
                        break;
                    case "TimeLine":
                        schedule.ScheduleType = ScheduleType.TimeLine;
                        //timelineellipse.Fill = new SolidColorBrush(Colors.White);
                        break;
                }
            }
        }
    }
}
