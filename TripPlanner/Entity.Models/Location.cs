using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Models
{
    public class Location : BaseEntity
    {       
        public string Name { get; set; }

        public string Country { get; set; }

        //public List<object> Trips { get; set; }
    }
}
