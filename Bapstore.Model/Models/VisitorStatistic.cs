using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bapstore.Model.Models
{
    [Table("VisitorStatistic")]
    public class VisitorStatistic
    {
        [Key]
        public Guid ID { get; set; }

        [Required]
        public DateTime VisitedAt { get; set; }

        [MaxLength(50)]
        public string IPAdress { get; set; }
    }
}
