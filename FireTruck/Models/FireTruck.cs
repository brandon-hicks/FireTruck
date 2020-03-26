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

        public FireTruck()
        {
            hoseSize = HoseSizes.InchAndThreeQuarter;
            hoseLength = 200;
            nozzle = Nozzle.SmoothBoreHand;
            appliance = false;
            pumpDischargePressure = CalculatePumpDischargePressure();
            tipSize = TipSizes.SevenEights;
            gallonsPerMinute = CalculateGpm();
        }

        public double CalculatePumpDischargePressure()
        {
            return CalculateTotalPressureLoss() + (int)nozzle;
        }

        public double CalculateGpm()
        {
            return 29.7 * Math.Pow(tipSize, 2) * Math.Sqrt((int)nozzle);
        }

        public double CalculateFrictionLoss()
        {
            return (hoseSize * Math.Pow(CalculateGpm() / 100, 2)) * (hoseLength / 100);
        }

        public double CalculateForAppliance()
        {
            
            return !appliance ? 0 : 10;
        }

        public double CalculateTotalPressureLoss()
        {
            return CalculateFrictionLoss() + CalculateForAppliance();
        }
        
    }

    public struct TipSizes
    {
        public const double SevenEights = 0.88;
        public const double InchAndAnEighth = 0.88;
        public const double InchAndAQuarter = 0.8;
        public const double InchAndThreeSixteenths = 0.18;
        public const double OneInch = 1;
        public const double InchAndAHalf = 1.5;
        public const double InchAndThreeQuarter = 1.75;
        public const double TwoInch = 2;
    }

    public struct HoseSizes
    {
        public const double ThreeQuarterInch = 1100;
        public const double OneAndAHalfInch = 24;
        public const double InchAndThreeQuarter = 15.5;
        public const double TwoAndAHalfInch = 2;
        public const double ThreeInch = 0.8;
        public const double FourInch = 0.2;
        public const double FiveInch = 0.08;
    }

    public enum Nozzle
    {
        SmoothBoreHand = 50,
        SmoothBoreMaster = 80,
        Fog = 100
    }
}