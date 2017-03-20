using $safeprojectname$.Helpers;
using $safeprojectname$.ViewModels;
using Starcounter;

namespace $safeprojectname$.Api
{
    internal class MainHandlers : IHandler
    {
        public void Register()
        {
            Application.Current.Use(new HtmlFromJsonProvider());
            Application.Current.Use(new PartialToStandaloneHtmlProvider());

            Handle.GET("/$safeprojectname$", () =>
            {
                var page = new HelloStarcounterPage();

                page.Visitors.Data = Db.SQL<GuestBook>("SELECT g FROM GuestBook g");

                if (Session.Current == null)
                {
                    Session.Current = new Session(SessionOptions.PatchVersioning);
                }

                page.Session = Session.Current;

                return page;
            });
        }
    }
}