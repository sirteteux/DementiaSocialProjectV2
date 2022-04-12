// Author: Andreas Lau 34095187
// Date: 27/02/2022
// Purpose: Test Adding Event - Twitter example

using Assignment1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Xml.Linq;

namespace UnitTestA1
{
    [TestClass]
    public class TestAddEvents
    {
        [TestMethod]
        public void TestingAddEvents()
        {
            XElement tempElement = new XElement("Event", new XElement("eventid", 10),
                                                    new XElement("text", "hi"),
                                                    new XElement("type", "tweet"),
                                                    new XElement("Location", new XElement("lat", 0),
                                                                            new XElement("long", 0)),
                                                    new XElement("Start-time", DateTime.Now.ToString()),
                                                    new XElement("End-time", DateTime.Now.ToString()));

            EventTweet tEvent = new EventTweet(tempElement);

            if (!tEvent.Text.Equals("test"))
            {
                // Test passed
                Assert.IsNotNull(tEvent);
            }
            else
            {
                // Test failed
                Assert.Fail();
            }
        }
    }
}
