using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    [Table("Orders")]
    public class Order:IEntity
    {
        [Key]
        [Column("Id",Order =1)]
        public uint Id { get; set; }

        [ForeignKey("Sellers")]
        [Column("SellerId")]
        public uint SellerId { get; set; }

        [ForeignKey("Customers")]
        [Column("CustomerId")]
        public uint CustomerId { get; set; }

        [ForeignKey("Cities")]
        [Column("CityId")]
        public uint CityId { get; set; }

        [ForeignKey("Products")]
        [Column("ProductId")]
        public uint ProductId { get; set; }

        [ForeignKey("MesuteUnits")]
        [Column("MesureUnitId")]
        public ushort MesureUnitId { get; set; }

        [ForeignKey("Currencies")]
        [Column("CurrencyId")]
        public byte CurrencyId { get; set; }

        [Required]
        [Column("Date",TypeName = "DateTime")]
        public DateTime Date { get; set; }

        [Column("Description", TypeName = "nvarchar(256)")]
        public string? Description { get; set; }

        [Required]
        [Column("Amount", TypeName = "decimal(12,6)")]
        public decimal Amount { get; set; }

        [Required]
        [Column("UnitPrice",TypeName ="money")]
        public decimal UnitPrice { get; set; }

        [Required]
        [Column("AddressDescription", TypeName = "nvarchar(256)")]
        public string AddressDescription { get; set; }

        [Required]
        [Column("ShipPostalCode", TypeName = "nvarchar(16)")]
        public string ShipPostalCode { get; set; }
    }
}
