using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTOs.City
{
    public class CityCreateDto
    {
        public string Name { get; set; }
        public int CountryId { get; set; }
    }
}
