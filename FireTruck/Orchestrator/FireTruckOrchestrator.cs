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

             response.GallonsPerMinute = _fireTruck.GallonsPerMinute();
             response.FrictionLoss = _fireTruck.CalculateFrictionLoss();
             response.PumpDischargePressure = _fireTruck.CalculatePumpDischargePressure();
             response.HoseLength = _fireTruck.hoseLength;
             response.HoseSize = _fireTruck.hoseSize;
             response.TipSize = _fireTruck.tipSize;
             response.NozzleType = _fireTruck.nozzle;
             
             
             return response;
         }

         public CalculationResponse UpdateCalculation(UpdateCalculationRequest request)
         {
             if (request.HoseLength != 0)
             {
                 _fireTruck.hoseLength = request.HoseLength;
             }

             if (request.HoseSize != 0)
             {
                 _fireTruck.hoseSize = request.HoseSize;
             }

             if (request.TipSize != 0)
             {
                 _fireTruck.tipSize = request.TipSize;
             }

             if (request.NozzleType != 0)
             {
                 _fireTruck.nozzle = request.NozzleType;
             }

             
             var response = new CalculationResponse();

             response.GallonsPerMinute = _fireTruck.GallonsPerMinute();
             response.FrictionLoss = _fireTruck.CalculateFrictionLoss();
             response.PumpDischargePressure = _fireTruck.CalculatePumpDischargePressure();
             response.HoseLength = _fireTruck.hoseLength;
             response.HoseSize = _fireTruck.hoseSize;
             response.TipSize = _fireTruck.tipSize;
             response.NozzleType = _fireTruck.nozzle;

             return response;
         }
     }
 }