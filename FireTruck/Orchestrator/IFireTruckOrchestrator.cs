using System.Collections.Generic;
using System.Threading.Tasks;
using FireTruck.Models;

namespace FireTruck.Orchestrator
{
    public interface IFireTruckOrchestrator
    {
        public CalculationResponse GetCalculationResponse();
        public CalculationResponse UpdateCalculation(UpdateCalculationRequest request);
    }
}