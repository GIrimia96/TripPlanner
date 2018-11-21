using System;
using Cqrs.Service.CommandContracts;
using Cqrs.Service.QueryContracts;
using Cqrs.Service.Command;
using Microsoft.AspNetCore.Mvc;
using DomainModels;

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
        public IActionResult AddLocation([FromBody] LocationDto locationDto)
        {
            var command = new AddLocationCommand(locationDto);

            //CommandDispatcher.Execute(command);
            return NoContent();
        }



    }
}