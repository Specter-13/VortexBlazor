using PlcHammerConnector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace VortexBlazor.Wpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App() : base()
        {
            Entry.PlcHammer.Connector.ReadWriteCycleDelay = 50;
            Entry.PlcHammer.Connector.BuildAndStart();
        }
    }
}
