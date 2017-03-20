using System;
using Starcounter;

namespace $safeprojectname$
{
    [Database]
    public class GuestBook
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Visited { get; set; }
    }
}
