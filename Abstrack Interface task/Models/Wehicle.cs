using System;
using System.Collections.Generic;
using System.Text;

namespace Abstrack_Interface_task.Models
{
    abstract class Wehicle
    {
      public double DriveTime;
      public double DrivePath;
      public double AverageSpeed(double DriveTime,double DrivePath)
        {
            double AverageSpeed = DrivePath / DriveTime;
            return AverageSpeed;
        }

    }
    interface IEngine
    {
        public double Horsepover { get; set; }
        double TankSize { get; set; }
        double CurrentOil { get; set; }
        double FuelType { get; set; }
        public double RemainOilAmount();
    }
    interface IWhell
    {
        public double WheelThickness { get; set; }

    }
    interface ITransmission
    {
        double TransmissionKind { get; set; }
    }
    
}
