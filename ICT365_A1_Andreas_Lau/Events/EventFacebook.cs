// Author: Andreas Lau, 34095187
// Date: 22/02/2022
// Purpose: Users can retrieve and save faceboook contents in XML elements.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Drawing;

namespace Assignment1
{
    public class EventFacebook : Event
    {
        public string Text { get; set; }

        public EventFacebook()
        {
            EventName = "Facebook";
            // Scale icon - 10% of original size
            Icon = new Bitmap(Properties.Resources.facebook, new Size(Properties.Resources.facebook.Width / 10, Properties.Resources.facebook.Height / 10));
        }        

        public override void LoadXElement(XNamespace ns, XElement element)
        {
            base.LoadXElement(ns, element);
            Text = element.Descendants(ns + "text").First().Value;
        }

        public override XElement ToXML()
        {
            var element = base.ToXML();
            element.Add(new XElement("text", Text));

            return element;
        }
    }
}