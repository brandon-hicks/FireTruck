namespace FireTruck.Models
{
    public class CalculationResponse
    {
        public double FrictionLoss { get; set; }
        public double PumpDischargePressure { get; set; }

        public CalculationResponse()
        {
            FrictionLoss = 0;
            PumpDischargePressure = 0;
        }
    }
}