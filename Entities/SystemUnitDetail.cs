using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class SystemUnitDetail
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [ForeignKey("Detail")]
        [Column("detail_id")]
        public int DetailId { get; set; }

        [ForeignKey("SystemUnit")]
        [Column("system_unit_id")]
        public int SystemUnitId { get; set; }

        public virtual Detail Detail { get; set; }

    }
}