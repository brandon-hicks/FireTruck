namespace FireTruck.Models
{
    public class CalculationResponse
    {
        public double FrictionLoss { get; set; }
        public double PumpDischargePressure { get; set; }
        public double TipSize { get; set; }
        public double HoseLength { get; set; }
        public double HoseSize { get; set; }

        public CalculationResponse()
        {
            FrictionLoss = 0;
            PumpDischargePressure = 0;
            TipSize = 0;
            HoseLength = 0;
            HoseSize = 0;
        }
    }
}