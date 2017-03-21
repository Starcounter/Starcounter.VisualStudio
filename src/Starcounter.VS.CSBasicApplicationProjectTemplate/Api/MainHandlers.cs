using $safeprojectname$.ViewModels;
using Starcounter;

namespace $safeprojectname$.Api
{
    internal static class MainHandlers
    {
        public static void Register()
        {
            Application.Current.Use(new HtmlFromJsonProvider());
            Application.Current.Use(new PartialToStandaloneHtmlProvider());

            Handle.GET("/$safeprojectname$", () =>
            {
                var page = new MainPage()
                {
                    Visitors =
                    {
                        Data = Db.SQL<GuestBookEntry>("SELECT g FROM GuestBookEntry g")
                    }
                };

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