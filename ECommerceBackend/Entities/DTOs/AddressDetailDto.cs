using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class AddressDetailDto: IDto
    {
        public uint AddressId { get; set; }
        public string CountryName { get; set; }
        public string CityName { get; set; }
        public string PostalCode { get; set; }
        public string AddressDescription { get; set; }
    }
}
