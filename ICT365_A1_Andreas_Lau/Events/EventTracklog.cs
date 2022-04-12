// Author: Andreas Lau, 34095187
// Date: 22/02/2022
// Purpose: Users can retrieve and save tracklog contents in XML elements.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Drawing;

namespace Assignment1
{
    public class EventTracklog : Event
    {
        public string Filepath { get; set; }

        public EventTracklog()
        {
            EventName = "Track log";
            // Scale icon - 10% of original size
            Icon = new Bitmap(Properties.Resources.tracklog, new Size(Properties.Resources.tracklog.Width / 10, Properties.Resources.tracklog.Height / 10));
        }

        public override void LoadXElement(XNamespace ns, XElement element)
        {
            base.LoadXElement(ns, element);
            Filepath = element.Descendants(ns + "filepath").First().Value;
        }

        public override XElement ToXML()
        {
            var element = base.ToXML();
            element.Add(new XElement("filepath", Filepath));

            return element;
        }
    }
}
