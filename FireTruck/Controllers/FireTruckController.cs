using System;
using FireTruck.Models;
using FireTruck.Orchestrator;
using Microsoft.AspNetCore.Mvc;

namespace FireTruckController
{
    [Route("api/")]
    public class FireTruckController : Controller
    {
        private readonly IFireTruckOrchestrator _orchestrator;

        public FireTruckController(IFireTruckOrchestrator orchestrator)
        {
            _orchestrator = orchestrator;
        }

        //Get/api/GetCalculationResponse
        [HttpGet("GetCalculationResponse")]
        public ActionResult<CalculationResponse> GetCalculationResponse()
        {
            var response = _orchestrator.GetCalculationResponse();

            if (response == null)
            {
                return NotFound();
            }

            return response;
        }
        
        //Patch/api/UpdateCalculationRequest
        [HttpPatch("UpdateCalculationRequest")]
        public ActionResult<CalculationResponse> Patch([FromBody] UpdateCalculationRequest request)
        {
            var result =  _orchestrator.UpdateCalculation(request);;

            return result;

        }
    }
}