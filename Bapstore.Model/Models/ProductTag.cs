﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bapstore.Model.Models
{
    [Table("ProductTag")]
    public class ProductTag
    {
        [Key]
        public int ProductID { get; set; }

        [Key]
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string TagID { get; set; }

        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }

        [ForeignKey("TagID")]
        public virtual Tag Tag { get; set; }
    }
}
