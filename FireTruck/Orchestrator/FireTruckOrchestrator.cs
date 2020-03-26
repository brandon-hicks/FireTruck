using System.Collections.Generic;
using System.Threading.Tasks;
using FireTruck.Models;


namespace FireTruck.Orchestrator
 {
     public class FireTruckOrchestrator : IFireTruckOrchestrator
     {
         private Models.FireTruck _fireTruck = new Models.FireTruck();

         public Models.CalculationResponse GetCalculationResponse()
         {
             var response = new CalculationResponse();

             response.FrictionLoss = _fireTruck.CalculateFrictionLoss();
             response.PumpDischargePressure = _fireTruck.CalculatePumpDischargePressure();
             
             
             return response;
         }
     }
 }