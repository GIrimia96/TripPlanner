using System;

namespace Entity.Models
{
    public class Account : BaseEntity
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public Employee Employee { get; set; }
        public Guid AccountForeignKey { get; set; }
    }
}
