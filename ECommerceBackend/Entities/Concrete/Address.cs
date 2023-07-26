using Core.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Concrete
{
    [Table("Addresses")]
    public class Address:IEntity
    {
        [Key]
        [Column("Id",Order =1)]
        public uint Id { get; set; }

        [ForeignKey("Users")]
        [Column("UserId")]
        public uint UserId { get; set; }

        [ForeignKey("Cities")]
        [Column("CityId")]
        public uint CityId { get; set; }

        [Required]
        [Column("Name", TypeName = "nvarchar(16)")]
        public string Name { get; set; }

        [Required]
        [Column("Description", TypeName = "nvarchar(256)")]
        public string Description { get; set; }

        [Required]
        [Column("PostalCode", TypeName = "nvarchar(16)")]
        public string PostalCode { get; set; }
    }
}
