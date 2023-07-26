using Core.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Concrete
{
    [Table("Currencies")]
    public class Currency:IEntity
    {
        [Key]
        [Column("Id",Order =1)]
        public byte Id { get; set; }

        [Required]
        [Column("Code",TypeName ="nvarchar(3)")] // ISO 4217
        public string Code { get; set; }

        [Column("Symbol",TypeName ="nvarchar(3)")]
        public string? Symbol { get; set; }
    }
}
