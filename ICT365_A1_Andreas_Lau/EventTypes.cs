// Author: Andreas Lau, 34095187
// Date: 22/02/2022
// Purpose: Event type

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public enum eventTypes
    {
        tweet,
        facebook,
        image,
        video,
        tracklog,
        person
    }

    static class EventTypes
    {
        public static string GetString(this eventTypes eventType)
        {
            switch (eventType)
            {
                case eventTypes.tweet:
                    return "tweet";

                case eventTypes.facebook:
                    return "facebook";

                case eventTypes.image:
                    return "image";

                case eventTypes.video:
                    return "video";

                case eventTypes.tracklog:
                    return "tracklog";

                case eventTypes.person:
                    return "person";

                default:
                    return null;
            }
        }
    }
}
