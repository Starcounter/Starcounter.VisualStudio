using System;
using Starcounter;

namespace $safeprojectname$
{
    [Database]
    public class GuestBookEntry
    {
        public string VisitorName { get; set; }
        public string DateVisited { get; set; }
    }
}
