using System;
using Cqrs.Service.CommandContracts;
using Cqrs.Service.QueryContracts;
using Cqrs.Service.Command;
using Cqrs.Service.Queries;
using Cqrs.Service.QueryResults;
using Microsoft.AspNetCore.Mvc;
using DomainModels;
using EnsureThat;
using Entity.Models;

namespace TripPlanner.Api.Controllers
{
    [Route("api/location")]
    public class LocationController : BaseController
    {
        public LocationController(ICommandDispatcher commandDispatcher, IQueryDispatcher queryDispatcher)
            : base(commandDispatcher, queryDispatcher)
        {
        }

        [HttpGet("{id}")]
        public IActionResult Index(Guid id)
        {
            EnsureArg.IsNotEmpty(id);
            var query = new GetLocationByIdQuery(id);
            var queryResult = QueryDispatcher.Execute<GetLocationByIdQuery, GetLocationByIdQueryResult>(query);

            return Ok(queryResult.Location);
        }

        [HttpPost]
        public IActionResult AddLocation([FromBody] LocationDto locationDto)
        {
            EnsureArg.IsNotNull(locationDto);

            var command = new AddLocationCommand(locationDto);

            CommandDispatcher.Execute(command);
            return NoContent();
        }

        [HttpPut]
        public IActionResult UpdateLocation([FromBody] LocationDto locationDto)
        {
            EnsureArg.IsNotNull(locationDto);
            var command = new UpdateLocationCommand(locationDto);
            CommandDispatcher.Execute(command);

            return NoContent();
        }

    }
}