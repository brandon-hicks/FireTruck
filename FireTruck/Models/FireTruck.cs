using System;

namespace FireTruck.Models
{
    public class FireTruck
    {
        
        public double hoseSize { get; set; }
        public double hoseLength { get; set; }
        public Nozzle nozzle { get; set; }
        public bool appliance { get; set; }
        public double pumpDischargePressure { get; set; }
        public double gallonsPerMinute { get; set; }
        public double tipSize { get; set; }
        
        public double gallonsPerMinuteValue { get; set; }

        public FireTruck()
        {
            hoseSize = 1.5;
            hoseLength = 200;
            nozzle = Nozzle.SmoothBoreHand;
            appliance = false;
            pumpDischargePressure = CalculatePumpDischargePressure();
            tipSize = 0.88;
            gallonsPerMinute = CalculateGpm();
            gallonsPerMinuteValue = GallonsPerMinute();
        }

        public double CalculatePumpDischargePressure()
        {
            return CalculateTotalPressureLoss() + (int)nozzle;
        }

        public double CalculateGpm()
        {
            return (29.7 * Math.Pow(CoefficientDerivedFromTipSize(tipSize), 2) * Math.Sqrt((int) nozzle) / 100);
        }

        public double GallonsPerMinute()
        {
            return (29.7 * Math.Pow(CoefficientDerivedFromTipSize(tipSize), 2) * Math.Sqrt((int) nozzle));
        }

        public double CalculateFrictionLoss()
        {
            return CoefficientDerivedFromHoseSize(hoseSize) * Math.Pow(CalculateGpm(), 2) * (hoseLength / 100);
        }

        public double CalculateForAppliance()
        {
            
            return !appliance ? 0 : 10;
        }

        public double CalculateTotalPressureLoss()
        {
            return CalculateFrictionLoss() + CalculateForAppliance();
        }

        private double CoefficientDerivedFromHoseSize(double hoseSize)
        {
            switch (hoseSize)
            {
                case 0.75:
                    return 1100.0;
                case 1.5:
                    return 24.0;
                case 1.75:
                    return 15.5;
                case 2.5:
                    return 2.0;
                case 3.0:
                    return 0.8;
                case 4.0:
                    return 0.2;
                case 5.0:
                    return 0.08;
                default:
                    return 15.5;
            }
        }

        private double CoefficientDerivedFromTipSize(double tipSize)
        {
            switch (tipSize)
            {
                case 0.88:
                    return 0.88;
                case 1.13:
                    return 1.13;
                case 1.25:
                    return 1.25;
                case 1.18:
                    return 1.18;
                case 1.0:
                    return 1.0;
                case 1.5:
                    return 1.5;
                case 1.75:
                    return 1.75;
                case 2.0:
                    return 2.0;
                default:
                    return 0.88;
            }
        }

    }

    public enum Nozzle
    {
        SmoothBoreHand = 50,
        SmoothBoreMaster = 80,
        Fog = 100
    }
    
}