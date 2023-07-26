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
    [Table("MeasureUnits")]
    public class MeasureUnit:IEntity
    {
        [Key]
        [Column("Id")]
        public ushort Id { get; set; }

        [Column("Symbol",TypeName = "nvarchar(8)")]
        public string? Symbol { get; set; }

        [Required]
        [Column("Description",TypeName ="nvarchar(16)")]
        public string Description{ get; set; }
    }
}
