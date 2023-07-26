using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    [Table("Products")]
    public class Product: IEntity
    {
        [Key]
        [Column("Id", Order = 1)]
        public uint Id { get; set; }

        [ForeignKey("Categories")]
        [Column("CategoryId")]
        public ushort CategoryId { get; set; }

        [ForeignKey("Sellers")]
        [Column("SellerId")]
        public uint SellerId { get; set; }

        [ForeignKey("MeasureUnits")]
        [Column("MeasureUnitId")]
        public ushort MeasureUnitId { get; set; }

        [ForeignKey("Currencies")]
        [Column("CurrencyId")]
        public byte CurrencyId { get; set; }

        [Required]
        [Column("Name",TypeName = "nvarchar(64)")]
        public string Name { get; set; }

        [Column("Description",TypeName ="nvarchar(256)")]
        public string? Description { get; set; }

        [Required]
        [Column("UnitsInStock", TypeName="decimal(12,6)")]
        public  decimal UnitsInStock { get; set; }

        [Required]
        [Column("UnitPrice",TypeName ="money")]
        public decimal UnitPrice { get; set; }
    }
}