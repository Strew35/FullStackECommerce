using Core.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Concrete
{
    [Table("Categories")]
    public class Category:IEntity
    {
        [Key]
        [Column("Id", Order = 1)]
        public ushort Id { get; set; }

        [Required]
        [Column("Name",TypeName ="nvarchar(64)")]
        public string Name { get; set; }
    }
}