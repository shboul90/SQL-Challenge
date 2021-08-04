using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLChallenges.Challenge3
{
    public class House
    {
        public Guid HouseId { get; set; }
        public float NumberOfBedrooms { get; set; }
        public float NumberOfBaths { get; set; }
        public decimal EstimatedValue { get; set; }
    }
}
