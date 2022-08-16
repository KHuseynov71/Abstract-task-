using System;
using System.Collections.Generic;
using System.Text;

namespace Abstrack_Interface_task.Models
{
    class Plane:Wehicle, IEngine, IWhell, ITransmission
    {
        public double WingLength { get; set; }
        public double Horsepover { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double TankSize { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double CurrentOil { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double FuelType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double WheelThickness { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string TransmissionKind { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public double RemainOilAmount()
        {
            throw new NotImplementedException();
        }
    }
}
