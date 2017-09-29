using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bapstore.Model.Models
{
    [Table("Error")]
    public class Error
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string Message { get; set; }

        public string StackTrace { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
