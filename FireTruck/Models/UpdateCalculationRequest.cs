namespace FireTruck.Models
{
    public class UpdateCalculationRequest
    {
        public double HoseLength { get; set; }
        public double TipSize { get; set; }
        public double HoseSize { get; set; }

        public UpdateCalculationRequest()
        {
            HoseLength = 0;
            TipSize = 0;
            HoseSize = 0;
        }
    }
}