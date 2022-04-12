// Author: Andreas Lau 34095187
// Date: 27/02/2022
// Purpose: Test Event Types

using Assignment1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestA1
{
    [TestClass]
    public class TestEvents
    {
        [TestMethod]
        public void FacebookEventType()
        {
            // Arrange
            var eventTypes = new eventTypes();

            // Act
            eventTypes = eventTypes.facebook;
            var result = eventTypes;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TwitterEventType()
        {
            // Arrange
            var eventTypes = new eventTypes();

            // Act
            eventTypes = eventTypes.tweet;
            var result = eventTypes;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ImageEventType()
        {
            // Arrange
            var eventTypes = new eventTypes();

            // Act
            eventTypes = eventTypes.image;
            var result = eventTypes;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void VideoEventType()
        {
            // Arrange
            var eventTypes = new eventTypes();

            // Act
            eventTypes = eventTypes.video;
            var result = eventTypes;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TracklogEventType()
        {
            // Arrange
            var eventTypes = new eventTypes();

            // Act
            eventTypes = eventTypes.tracklog;
            var result = eventTypes;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void PersonEventType()
        {
            // Arrange
            var eventTypes = new eventTypes();

            // Act
            eventTypes = eventTypes.person;
            var result = eventTypes;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
