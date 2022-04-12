// Author: Andreas Lau, 34095187
// Date: 22/02/2022
// Purpose: Users can add their tweets into the map.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class TweetForm : Form
    {
        private Coord location;
        private bool edit;
        private string eventID;

        public TweetForm()
        {
            InitializeComponent();

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy hh:mm";
            dateTimePicker1.ShowUpDown = true;
            messageBox.SelectionFont = new Font("Verdana", 12, FontStyle.Regular);
            edit = false;
        }

        public TweetForm(EventTweet ev) : this()
        {
            messageBox.Text = ev.Text;
            dateTimePicker1.Value = ev.StartTime;
            edit = true;
            eventID = ev.EventID;
            location = ev.Location;
        }

        public TweetForm(Coord loc) : this()
        {
            location = loc;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var eventObj = new EventTweet();
            eventObj.Type = eventTypes.tweet.GetString();
            eventObj.Text = messageBox.Text;
            eventObj.Location = location;
            eventObj.StartTime = dateTimePicker1.Value;
            eventObj.EndTime = dateTimePicker1.Value;

            if (edit)
            {
                EventDB.SetEvent(eventObj, eventID);
            }
            else
            {
                EventDB.AddEvent(eventObj);
                MapController.AddMarker(location.X, location.Y, eventObj.Icon);
            }

            this.Close();
        }
    }
}
