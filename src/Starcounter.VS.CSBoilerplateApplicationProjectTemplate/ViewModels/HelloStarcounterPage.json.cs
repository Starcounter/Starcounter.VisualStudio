using System;
using Starcounter;

namespace $safeprojectname$.ViewModels
{
    partial class HelloStarcounterPage : Json
    {
        void Handle(Input.AddVisitorTrigger trigger)
        {
            if (string.IsNullOrEmpty(this.NewFirstName))
                return;

            Db.Transact(() =>
            {
                new GuestBook
                {
                    FirstName = this.NewFirstName,
                    LastName = this.NewLastName,
                    Visited = DateTime.Now.ToString("yyyy-MM-dd HH:mm")
                };
            });

            this.Visitors = Db.SQL<GuestBook>("SELECT g FROM GuestBook g");
        }
    }
}
