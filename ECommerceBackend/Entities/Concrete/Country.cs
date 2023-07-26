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
    [Table("Countries")]
    public class Country:IEntity
    {
        [Key]
        [Column("Id")]
        public ushort Id { get; set; }

        [ForeignKey("Currencies")]
        [Column("CurrencyId")]
        public byte CurrencyId { get; set; }

        [Required]
        [Column("IsoCode",TypeName ="nvarchar(3)")] // ISO 3166
        public string IsoCode { get;set; }

        [Required]
        [Column("Name",TypeName ="nvarchar(128)")]
        public string Name { get; set; }

        [Required]
        [Column("PhoneAreaCode",TypeName ="nvarchar(4)")]
        public string PhoneAreaCode { get; set; }
    }
}
