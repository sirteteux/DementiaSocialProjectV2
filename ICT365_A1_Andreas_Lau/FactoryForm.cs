// Author: Andreas Lau, 34095187
// Date: 22/02/2022
// Purpose: Load each respective event forms when user selects each respective event icons.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    //DESIGN PATTERN: Factory
    static class FactoryForm
    {
        public static void OpenForm(string eventType, Event eventItem)
        {
            switch (eventType)
            {
                case "tweet":
                    new TweetForm(eventItem as EventTweet).ShowDialog();
                    break;

                case "facebook":
                    new FacebookForm(eventItem as EventFacebook).ShowDialog();
                    break;

                case "image":
                    new ImageForm(eventItem as EventImage).ShowDialog();
                    break;

                case "video":
                    new VideoForm(eventItem as EventVideo).ShowDialog();
                    break;

                case "person":
                    new PersonForm(eventItem as EventPerson).ShowDialog();
                    break;
            }
        }
    }
}
