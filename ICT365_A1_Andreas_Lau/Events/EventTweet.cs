// Author: Andreas Lau, 34095187
// Date: 22/02/2022
// Purpose: Users can retrieve and save twitter contents in XML elements.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Drawing;

namespace Assignment1
{
    public class EventTweet : Event
    {
        public string Text { get; set; }

        public EventTweet()
        {
            EventName = "Tweet";
            // Scale icon - 10% of original size
            Icon = new Bitmap(Properties.Resources.twitter, new Size(Properties.Resources.twitter.Width / 10, Properties.Resources.twitter.Height / 10));
        }

        public EventTweet(XElement eventT)
        {
            var text = eventT.Element("text").Value;
            var startTime = DateTime.Parse(eventT.Element("Start-time").Value);
            var endTime = DateTime.Parse(eventT.Element("End-time").Value);

            StartTime = startTime;
            EndTime = endTime;
            Type = "tweet";
            this.Text = text;
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
