using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class OrderDetailDto:IDto
    {
        public uint OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string? OrderDescription { get; set; }

        public uint SellerId { get; set; }
        public string SellerName { get; set; }

        public uint CustomerId { get; set; }
        public string CustomerName { get; set; }

        public uint ProductId { get; set; }
        public string ProductName { get; set; }
        public string? ProductDescription { get; set; }

        public decimal ProductAmount { get; set; }
        public string? MeasureSymbol { get; set; }
        public string MeasureDescription { get; set; }

        public decimal OrderUnitPrice { get; set; }
        public string CurrencyCode { get; set; }
        public string? CurrencySymbol { get; set; }

        public string ShipmentCountryName { get; set; }
        public string ShipmentCityName { get; set; }
        public string ShipmentAddressDescription { get; set; }
        public string ShipmentPostalCode { get; set; }
    }
}
