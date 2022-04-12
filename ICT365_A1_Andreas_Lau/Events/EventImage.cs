// Author: Andreas Lau, 34095187
// Date: 22/02/2022
// Purpose: Users can retrieve and save image contents in XML elements.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Drawing;

namespace Assignment1
{
    public class EventImage : Event
    {
        public string Text { get; set; }
        public string Filepath { get; set; }

        public EventImage()
        {
            EventName = "Image";
            // Scale icon - 10% of original size
            Icon = new Bitmap(Properties.Resources.image, new Size(Properties.Resources.image.Width / 10, Properties.Resources.image.Height / 10));
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
