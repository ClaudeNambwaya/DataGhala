using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataGhala.Models
{
    public class Company
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Publication { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string PublicationNumber { get; set; }
        public string Source { get; set; }
    }
}
