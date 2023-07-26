using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class ProductSellerDetailDto: IDto
    {
        public uint ProductId { get; set; }
        public string ProductName { get; set; }
        public string? ProductDescription { get; set; }

        public uint SellerId { get; set; }
        public string SellerName { get; set; }
        public string? SellerDescription { get; set; }

        public List<AddressDetailDto>? SellerAddressDetails { get; set; }
    }
}
