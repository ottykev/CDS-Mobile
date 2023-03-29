using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDS_Mobile.Models
{
    internal class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Province>Provinces { get; set; }
    }
}
