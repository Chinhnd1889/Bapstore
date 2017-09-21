﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bapstore.Model.Models
{
    [Table("Slices")]
    public class Slice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(256)]
        public string Name { get; set; }
        
        [MaxLength(256)]
        public string Description { get; set; }
        
        [MaxLength(256)]
        public string Image { get; set; }
        
        [MaxLength(256)]
        public string Url { get; set; }

        public int? DisplayOrder { get; set; }

        public bool Status { get; set; }
    }
}
