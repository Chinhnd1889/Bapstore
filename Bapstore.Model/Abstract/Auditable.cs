using System;
using System.ComponentModel.DataAnnotations;

namespace Bapstore.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        public DateTime? CreatedAt { get; set; }

        [MaxLength(256)]
        public string CreatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }

        [MaxLength(256)]
        public string UpdatedBy { get; set; }

        [MaxLength(256)]
        public string MetaKeyword { get; set; }

        [MaxLength(256)]
        public string MetaDescription { get; set; }

        public bool Status { get; set; }
    }
}
