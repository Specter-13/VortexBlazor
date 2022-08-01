using PlcHammer;
using PlcHammerConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VortexBlazor.Wpf
{
    public class MainWindowViewModel
    {
        public MainWindowViewModel()
        {
            PLC = Entry.PlcHammer;

        }
        public PlcHammerTwinController PLC { get; }
    }
}
