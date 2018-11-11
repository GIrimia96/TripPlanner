using System;

namespace Entity.Models
{
    public class EmployeeTrip
    {
        public Guid EmployeeId { get; set; }
        public Guid TripId { get; set; }

        public Employee Employee { get; set; }
        public Trip Trip { get; set; }
    }
}
