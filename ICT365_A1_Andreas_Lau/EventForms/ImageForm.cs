// Author: Andreas Lau, 34095187
// Date: 22/02/2022
// Purpose: Users can add pictures into the map.

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
    public partial class ImageForm : Form
    {
        private string eventID;
        private Coord location;
        private string fileName;
        private bool edit;

        public ImageForm()
        {
            InitializeComponent();

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy hh:mm";
            dateTimePicker1.ShowUpDown = true;
            fileName = null;
            imageShowcase.Image = Properties.Resources.imageDefault;
            edit = false;
        }

        public ImageForm(EventImage ev) : this()
        {
            imageShowcase.Image = new Bitmap(ev.Filepath);
            dateTimePicker1.Value = ev.StartTime;
            edit = true;
            eventID = ev.EventID;
            location = ev.Location;
        }

        public ImageForm(Coord loc) : this()
        {
            location = loc;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (fileName != null)
            {
                var eventObj = new EventImage();
                eventObj.Type = eventTypes.image.GetString();
                eventObj.Location = location;
                eventObj.StartTime = dateTimePicker1.Value;
                eventObj.EndTime = dateTimePicker1.Value;
                eventObj.Filepath = fileName;

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

        private void imageShowcase_Click(object sender, EventArgs e)
        {
            // Source code: https://www.c-sharpcorner.com/UploadFile/mirfan00/uploaddisplay-image-in-picture-box-using-C-Sharp/
            OpenFileDialog open = new OpenFileDialog();             // Open file explorer to select a file
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.png)|*.jpg; *.jpeg; *.gif; *.png;";
            if (open.ShowDialog() == DialogResult.OK)               // If loading file is successfull
            {
                imageShowcase.Image = new Bitmap(open.FileName);    // Set video player url to file name of opened file
                fileName = open.FileName;
            }
        }
    }
}
