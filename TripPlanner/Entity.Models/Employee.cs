using System;
using System.Collections.Generic;

namespace Entity.Models
{
    public class Employee
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Title { get; set; }

        public string Role { get; set; }

        public Account Account { get; set; }

        public List<EmployeeTrip> EmployeeTrips { get; set; }
    }
}
