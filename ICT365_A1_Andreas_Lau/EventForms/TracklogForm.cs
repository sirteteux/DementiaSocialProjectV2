// Author: Andreas Lau, 34095187
// Date: 22/02/2022
// Purpose: Users can add tracklog event into the map.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class TracklogForm : Form
    {
        private string eventID;
        private Coord location;
        private string fileName;
        private bool edit;

        public TracklogForm()
        {
            InitializeComponent();

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy hh:mm";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd/MM/yyyy hh:mm";
            dateTimePicker2.ShowUpDown = true;
            fileName = null;
            edit = false;
        }

        public TracklogForm(EventTracklog ev) : this()
        {
            dateTimePicker1.Value = ev.StartTime;
            dateTimePicker2.Value = ev.EndTime;
            edit = true;
            eventID = ev.EventID;
            location = ev.Location;
        }

        public TracklogForm(Coord loc) : this()
        {
            location = loc;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (fileName != null)
            {
                var eventObj = new EventTracklog();
                eventObj.Type = eventTypes.tracklog.GetString();
                eventObj.Location = location;
                eventObj.StartTime = dateTimePicker1.Value;
                eventObj.EndTime = dateTimePicker2.Value;
                eventObj.Filepath = fileName;
                var routeList = MapController.GPXtoPointList(eventObj.Filepath);
                if (edit)
                {
                    EventDB.SetEvent(eventObj, eventID);
                }
                else
                {
                    EventDB.AddEvent(eventObj);
                    MapController.AddRoute(routeList);
                    MapController.AddMarker(location.X, location.Y, eventObj.Icon);
                }

                this.Close();
            }
        }

        private void browseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Tracklog Files(*.gpx;)|*.gpx;";
            dialog.Multiselect = false;                                 // Allow or deny user to upload more than one file
            if (dialog.ShowDialog() == DialogResult.OK)                 // If loading file is successfull
            {
                String path = dialog.FileName;                          // Set tracklog file to file name of opened file
                using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open), new UTF8Encoding()))
                {
                    txtFile.Text = "tracklogs/" + dialog.SafeFileName;
                    fileName = "tracklogs/" + dialog.SafeFileName;
                }
            }
        }
    }
}
