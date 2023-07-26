using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class ProductDetailDto:IDto
    {
        public uint ProductId { get; set; }
        public string ProductName { get; set; }
        public string? ProductDescription { get; set; }

        public string CategoryName { get; set; }

        public decimal UnitPrice { get; set; }
        public string? CurrencySymbol { get; set; }
        public string CurrencyCode { get; set; }

        public decimal UnitsInStock { get; set; }
        public string? MeasureUnitSymbol { get; set; }
        public string MeasureUnitDescription { get; set; }
    }
}
