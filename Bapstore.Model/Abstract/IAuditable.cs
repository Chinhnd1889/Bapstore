using System;

namespace Bapstore.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreateAt { get; set; }
        string CreateBy { get; set; }
        DateTime? UpdateAt { get; set; }
        string UpdateBy { get; set; }

        string MetaKeyword { get; set; }
        string MetaDescription { get; set; }

        bool Status { get; set; }
    }
}
