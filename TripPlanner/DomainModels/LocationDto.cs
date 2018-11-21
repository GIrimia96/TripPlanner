using System;

namespace DomainModels
{
    public class LocationDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Country { get; set; }

        //public List<TripDto> Trips { get; set; }
    }
}
