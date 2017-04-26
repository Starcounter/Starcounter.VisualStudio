using System;
using Starcounter;

namespace $safeprojectname$.ViewModels
{
    partial class MainPage : Json
    {
        void Handle(Input.AddVisitorTrigger action)
        {
            if (string.IsNullOrEmpty(this.NewName))
                return;

            Db.Transact(() =>
            {
                new GuestBookEntry
                {
                    VisitorName = this.NewName,
                    DateVisited = DateTime.Now.ToString("yyyy-MM-dd HH:mm")
                };
            });

            this.Visitors.Add(new VisitorsElementJson
            {
                VisitorName = this.NewName,
                DateVisited = DateTime.Now.ToString("yyyy-MM-dd HH:mm")
            });

            this.NewName = "";
        }
    }
}
