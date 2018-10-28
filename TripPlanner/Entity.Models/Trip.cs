﻿using System;

namespace Entity.Models
{
    public class Trip
    {
        public Guid Id { get; set; }

        public string FromLocation { get; set; }

        public string ToLocation { get; set; }

        public string HotelName { get; set; }

        public string AuthorInformation { get; set; }

        public double EstimateCost { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Type { get; set; }

        public int Status { get; set; }
    }
}
