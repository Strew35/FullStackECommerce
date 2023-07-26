using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    [Table("Users")]
    public class User : IEntity
    {
        [Key]
        [Column("Id",Order=1)]
        public uint Id { get; set; }

        [Required]
        [Column("CreateTime", TypeName = "DateTime")]
        public DateTime CreateTime { get; set; }

        [Required]
        [Column("UserEmail", TypeName = "nvarchar(32)")]
        public string Email { get; set; }
    }
}
