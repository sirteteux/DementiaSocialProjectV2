// Author: Andreas Lau, 34095187
// Date: 22/02/2022
// Purpose: Main form where users can browse the events that are occuring on the map. User can choose to add person and tracklog at the bottom right of the form.
// User can add other events by left-clicking on the map and select 'Add Event'.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;

namespace Assignment1
{
    public struct Coord
    {
        public Coord(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; }
        public double Y { get; }
    }

    public partial class FormMain : Form
    {
        public Coord clickLocation;
        public EventDB eventDatabase;
        public PersonDB personDatabase;
        public MapController mapControl;
        private Coord location;

        public FormMain()
        {
            InitializeComponent();

            addPersonButton.TabStop = false;
            addPersonButton.FlatAppearance.BorderSize = 0;   

            clickLocation = new Coord(0, 0);

            // Load person xml data
            personDatabase = PersonDB.Instance;
            personDatabase.LoadXml(@"data/person.xml");

            // Load events xml data
            eventDatabase = EventDB.Instance;
            eventDatabase.LoadXml(@"data/lifelog-events.xml");

            mainMap.MapProvider = GMapProviders.GoogleMap;
            // Map position at Kaplan Singapore
            mainMap.Position = new PointLatLng(1.3022, 103.8496);
            mainMap.ShowCenter = false;
            mainMap.Zoom = 12;

            // Mainmap event handlers
            mainMap.OnMarkerClick += new MarkerClick(mainMap_OnMarkerClick);
            mainMap.MouseClick += new MouseEventHandler(mainMap_Click);
            mainMap.MouseMove += new MouseEventHandler(mainMap_MouseMove);

            mapControl = new MapController(mainMap);
            CreateMapOverlayItems();
        }

        public FormMain(Coord loc)
        {
            InitializeComponent();
            location = loc;
        }

        private void CreateMapOverlayItems()
        {
            foreach (Event eventItem in EventDB.eventDictionary.Values)
            {
                if (eventItem.AddMarker)
                {
                    MapController.AddMarker(eventItem.Location.X, eventItem.Location.Y, eventItem.Icon);
                }

                if (eventItem.AddRoute)
                {
                    var trackLogItem = eventItem as EventTracklog;
                    var routeList = MapController.GPXtoPointList(trackLogItem.Filepath);
                    MapController.AddRoute(routeList);
                    MapController.AddMarker(eventItem.Location.X, eventItem.Location.Y, eventItem.Icon);
                }
            }
        }

        private void mainMap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            double x = item.Position.Lng;
            double y = item.Position.Lat;
            var eventItem = eventDatabase.GetEventFromPoint(x, y);

            if (eventItem != null)
            {
                FactoryForm.OpenForm(eventItem.Type, eventItem);
            }
        }

        private void formPopup_Click(object sender, ToolStripItemClickedEventArgs e)
        {
            FormEvent events = new FormEvent(clickLocation);
            events.ShowDialog();
        }

        private void mainMap_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var formPopup = new ContextMenuStrip();
                formPopup.Items.Add("Add Event");
                formPopup.Show(this, new Point(e.X, e.Y));
                formPopup.ItemClicked += new ToolStripItemClickedEventHandler(this.formPopup_Click);
                clickLocation = new Coord(mainMap.FromLocalToLatLng(e.X, e.Y).Lng, mainMap.FromLocalToLatLng(e.X, e.Y).Lat);
            }
        }

        private void mainMap_MouseMove(object sender, MouseEventArgs e)
        {
            CoordLabel.Text = $"{Math.Round(mainMap.FromLocalToLatLng(e.X, e.Y).Lat, 2)}, {Math.Round(mainMap.FromLocalToLatLng(e.X, e.Y).Lng, 2)}";
        }

        private void addPersonButton_Click(object sender, EventArgs e)
        {
            addPersonForm personForm = new addPersonForm();
            personForm.ShowDialog();
        }
        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            personDatabase.SaveXml(@"data/person.xml");
            eventDatabase.SaveXml(@"data/lifelog-events.xml");
        }
        private void tracklogPicturebox_Click_1(object sender, EventArgs e)
        {
            TracklogForm ev = new TracklogForm(location);
            ev.ShowDialog();
        }
    }
}