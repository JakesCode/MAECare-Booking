using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Google.Apis.Auth.OAuth2;
using System.Threading;
using Google.Apis.Util.Store;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Diagnostics;
using System.Web;
using System.Web.Script.Serialization;

namespace MAECareBooking
{
    public partial class UI_SUBMIT : Form
    {
        public UI_SUBMIT()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedDate = UI_DATE.Value;
            if(!(selectedDate.DayOfWeek.ToString() == "Wednesday"))
            {
                MessageBox.Show("Jake is only in on Wednesdays. You have selected a date that is not a Wednesday.", "Not selected a Wednesday", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                var selectedPerson = UI_PERSON.SelectedItem.ToString();
                var description = UI_DESCRIPTION.Text;
                if(!(selectedPerson == "" | description == ""))
                {
                    var startTime = UI_START.Value;
                    var endTime = UI_END.Value;
                    if (endTime < startTime)
                    {
                        MessageBox.Show("This appointment ends before it starts. Please make sure the end time is after the start time.");
                    }
                    else
                    {
                        sendData();
                    }
                } else
                {
                    MessageBox.Show("You have filled out one or more of the boxes incorrectly.", "Boxes not filled in correctly", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void sendData()
        {
            string clientId = "198509857428-suuj745m2kqq2mphpicouma3c9tobj05.apps.googleusercontent.com";//From Google Developer console https://console.developers.google.com
            string clientSecret = "PO9kzVDu36AYxvMBJPgOemGm";//From Google Developer console https://console.developers.google.com
            string userName = "Jake Stringer";//  A string used to identify a user.
            string[] scopes = new string[] {
                CalendarService.Scope.Calendar, // Manage your calendars
                CalendarService.Scope.CalendarReadonly // View your Calendars
            };

            // here is where we Request the user to give us access, or use the Refresh Token that was previously stored in %AppData%
            UserCredential credential = GoogleWebAuthorizationBroker.AuthorizeAsync(new ClientSecrets
            {
                ClientId = clientId,
                ClientSecret = clientSecret
            }, scopes, userName, CancellationToken.None, new FileDataStore("Daimto.GoogleCalendar.Auth.Store")).Result;

            // Create the service.
            CalendarService service = new CalendarService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "MAECare Booking",
            });

            Event.RemindersData reminder = new Event.RemindersData();
            reminder.Overrides = new List<EventReminder>();
            reminder.Overrides.Add(null);

            Event myEvent = new Event
            {
                Summary = UI_PERSON.Text,
                Location = "Moor Allerton Elderly Care",
                Start = new EventDateTime()
                {
                    DateTime = new DateTime(UI_DATE.Value.Year, UI_DATE.Value.Month, UI_DATE.Value.Day, UI_START.Value.Hour, UI_START.Value.Minute, 0),
                    TimeZone = "Europe/London"
                },
                End = new EventDateTime()
                {
                    DateTime = new DateTime(UI_DATE.Value.Year, UI_DATE.Value.Month, UI_DATE.Value.Day, UI_END.Value.Hour, UI_END.Value.Minute, 0),
                    TimeZone = "Europe/London"
                },
                Description = UI_DESCRIPTION.Text,
                Reminders = reminder,
            };

            Event recurringEvent = service.Events.Insert(myEvent, "bb3so5ghutlqldfmqiuecphbe0@group.calendar.google.com").Execute();
            webBrowser1.Refresh(); 
        }

        private void UI_SUBMIT_Load(object sender, EventArgs e)
        {
            label2.Text = this.ProductName + " v." + this.ProductVersion;
        }

        private void UI_PERSON_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var person = UI_PERSON.Text;
            if(person == "")
            {
                MessageBox.Show("Please select a person.", "Nothing Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                Form2 individualNotesWindow = new Form2(person);
                individualNotesWindow.ShowDialog();
            } 
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var defaultDictionary = new Dictionary<string, string>();
            defaultDictionary.Add("Bert", "");
            defaultDictionary.Add("Louise", "");
            defaultDictionary.Add("Jean", "");
            File.WriteAllText(@"data.dat", new JavaScriptSerializer().Serialize(defaultDictionary));
        }
    }
}
