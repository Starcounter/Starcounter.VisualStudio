using System;
using $safeprojectname$.Api;
using Starcounter;

namespace $safeprojectname$
{
    internal class Program
    {
        private static void Main()
        {
            MainHandlers.Register();
            CommitHooks.Register();
            PartialHandlers.Register();
        }
    }
}