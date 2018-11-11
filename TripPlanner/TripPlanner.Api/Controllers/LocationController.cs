using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cqrs.Service.CommandContracts;
using Cqrs.Service.QueryContracts;
using Microsoft.AspNetCore.Mvc;

namespace TripPlanner.Api.Controllers
{
    [Route("api/location")]
    public class LocationController : BaseController
    {
        public LocationController(ICommandDispatcher commandDispatcher,IQueryDispatcher queryDispatcher)
            : base(commandDispatcher, queryDispatcher)
        {
        }

        [HttpPost]
        public IActionResult AddLocation(Guid locationId)
        {
            var command = AddLocationCommand(locationId);

            CommandDispatcher.Execute(command);
            return NoContent();
        }



    }
}