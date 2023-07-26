using Core.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Concrete
{
    [Table("Cities")]
    public class City:IEntity
    {
        [Key]
        [Column("Id", Order = 2)]
        public uint Id { get; set; }

        [ForeignKey("Countries")]
        [Column("CountryId", Order = 1)]
        public ushort CountryId { get; set; }

        [Required]
        [Column("Name",TypeName ="nvarchar(64)")]
        public string Name { get; set; }
    }
}
