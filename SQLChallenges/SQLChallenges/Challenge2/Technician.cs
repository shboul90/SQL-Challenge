using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLChallenges.Challenge2
{
    public class Technician
    {
        public Guid TechnicianId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float CustomerRating { get; set; }

        //Foreign Key
        //public Guid VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
