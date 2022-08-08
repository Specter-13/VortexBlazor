using System;
using Vortex.Presentation;

namespace PlcHammer
{
    public class VortexComponentInfoViewModel : RenderableViewModelBase
    {
        public VortexComponentInfoViewModel()
        {
        }
        public VortexComponent Component { get; set; }
        public override object Model { get => this.Component; set { this.Component = value as VortexComponent; } }
    }
}
