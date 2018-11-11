﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Models
{
    public class Location
    {
        public Guid Id { get; set; }
        
        public string Name { get; set; }

        public string Country { get; set; }

        public List<Trip> Trips { get; set; }
    }
}
