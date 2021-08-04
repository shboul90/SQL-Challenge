using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLChallenges.Challenge3
{
    public class Listing
    {
        public Guid ListingId { get; set; }
        public DateTime DateListed { get; set; }
        public bool IsRental { get; set; }

        //Foreign Key
        //public Guid HouseId { get; set; }
        public House House { get; set; }
    }
}
