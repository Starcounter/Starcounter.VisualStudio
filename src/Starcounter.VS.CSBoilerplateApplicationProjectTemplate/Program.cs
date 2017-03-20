using System;
using $safeprojectname$.Api;
using $safeprojectname$.Helpers;
using Starcounter;

namespace $safeprojectname$
{
    internal class Program
    {
        private static void Main()
        {
            IHandler[] handlers = {
                new MainHandlers(),
                new CommitHooks(),
                new PartialHandlers(),
                new OntologyHooks()
            };

            foreach (var handler in handlers)
            {
                handler.Register();
            }
        }
    }
}