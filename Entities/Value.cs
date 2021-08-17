using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Value
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [ForeignKey("Detail")]
        [Column("detail_id")]
        public int DetailId { get; set; }

        [ForeignKey("Property")]
        [Column("property")]
        public int PropertyId { get; set; }

        [Column("data")]
        public string Data { get; set; }

        public virtual Property Property {get;set;}


    }
}