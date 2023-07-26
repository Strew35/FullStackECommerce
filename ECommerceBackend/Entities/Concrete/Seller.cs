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
    [Table("Sellers")]
    public class Seller : IEntity
    {
        [Key]
        [Column("Id", Order = 1)]
        public uint Id { get; set; }

        [ForeignKey("Users")]
        [Column("UserId")]
        public uint UserId { get; set; }

        [Required]
        [Column("Name",TypeName = "nvarchar(32)")]
        public string Name { get; set; }

        [Required]
        [Column("PhoneNumber",TypeName ="nvarchar(15)")]
        public string PhoneNumber { get; set; }

        [Column("Description",TypeName = "nvarchar(256)")]
        public string? Description { get; set; }
    }
}
