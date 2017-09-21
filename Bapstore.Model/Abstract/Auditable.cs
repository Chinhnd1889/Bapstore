using System;
using System.ComponentModel.DataAnnotations;

namespace Bapstore.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        public DateTime? CreateAt { get; set; }

        [MaxLength(256)]
        public string CreateBy { get; set; }

        public DateTime? UpdateAt { get; set; }

        [MaxLength(256)]
        public string UpdateBy { get; set; }

        [MaxLength(256)]
        public string MetaKeyword { get; set; }

        [MaxLength(256)]
        public string MetaDescription { get; set; }

        public bool Status { get; set; }
    }
}
