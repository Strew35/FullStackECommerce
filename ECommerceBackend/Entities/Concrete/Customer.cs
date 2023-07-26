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
    [Table("Customers")]
    public class Customer : IEntity
    {
        [Key]
        [Column("Id")]
        public uint Id { get; set; }

        [ForeignKey("Users")]
        [Column("UserId")]
        public uint UserId { get; set; }

        [Required]
        [Column("Name",TypeName ="nvarchar(64)")]
        public string Name { get; set; }

        [Required]
        [Column("PhoneNumber",TypeName = "nvarchar(15)")]
        public string PhoneNumber { get; set; }
    }
}