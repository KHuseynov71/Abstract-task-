using System;
using System.Collections.Generic;
using System.Text;

namespace Abstrack_Interface_task.Models
{
    class Bicycle:Wehicle, IWhell, ITransmission
    {
        public double PedalKind { get; set; }
        public double WheelThickness { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double TransmissionKind { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
