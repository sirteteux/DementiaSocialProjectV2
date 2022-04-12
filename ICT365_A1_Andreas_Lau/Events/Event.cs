// Author: Andreas Lau, 34095187
// Date: 22/02/2022
// Purpose: Users can retrieve and save XML elements.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Drawing;

namespace Assignment1
{
    public abstract class Event
    {
        // Properties
        public string EventID { get; set; }
        public Coord Location { get; set; }
        public string EventName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Bitmap Icon { get; set; }
        public bool AddMarker { get; set; }
        public bool AddRoute { get; set; }

        protected int MarkerSize;

        public string Type { get; set; }

        // Methods
        public Event()
        {
            // Scale icon - 10% of original size
            Icon = new Bitmap(Properties.Resources.unknown, new Size(Properties.Resources.unknown.Width / 10, Properties.Resources.unknown.Height / 10));
            Location = new Coord(0.0, 0.0);
            AddMarker = true;
            AddRoute = false;
            MarkerSize = 15;
        }

        // Load elements in XML file
        public virtual void LoadXElement(XNamespace ns, XElement element)
        {
            double x = Convert.ToDouble(element.Descendants(ns + "location").FirstOrDefault().Descendants(ns + "long").FirstOrDefault().Value);
            double y = Convert.ToDouble(element.Descendants(ns + "location").FirstOrDefault().Descendants(ns + "lat").FirstOrDefault().Value);
            Location = new Coord(x, y);

            StartTime = DateTime.Parse(element.Descendants(ns + "start-time").FirstOrDefault().Descendants(ns + "datetimestamp").FirstOrDefault().Value);
            EndTime = DateTime.Parse(element.Descendants(ns + "end-time").FirstOrDefault().Descendants(ns + "datetimestamp").FirstOrDefault().Value);

            EventID = element.Descendants(ns + "eventid").FirstOrDefault().Value;
        }

        // Save event to XML file based on elements
        public virtual XElement ToXML()
        {
            XElement element = new XElement("Event", new XAttribute("type", Type),
                new XElement("eventid", EventID), 
                new XElement("location",
                    new XElement("long", Location.X),
                    new XElement("lat", Location.Y)
                ),
                new XElement("start-time",
                    new XElement("datetimestamp", StartTime.ToString("o"))
                ),
                new XElement("end-time",
                    new XElement("datetimestamp", EndTime.ToString("o"))
                )
            );

            return element;
        }
    }
}
