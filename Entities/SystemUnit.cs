using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    public class SystemUnit
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("name")]
        public string Name { get; set; }
        
        [Column("price")]
        public double Price { get; set; }

        public virtual ICollection<SystemUnitDetail> SystemUnitDetails { get; set; } = new List<SystemUnitDetail>();
    }
}
