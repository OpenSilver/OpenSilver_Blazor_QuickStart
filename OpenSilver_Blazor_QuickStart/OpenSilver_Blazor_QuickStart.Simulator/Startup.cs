using OpenSilver.Simulator;
using System;

namespace OpenSilver_Blazor_QuickStart.Simulator
{
    internal static class Startup
    {
        [STAThread]
        static int Main(string[] args)
        {
            return SimulatorLauncher.Start(typeof(App));
        }
    }
}
