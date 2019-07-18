using System;

namespace TeduShop.Model.Abstracts
{
    public interface IAuditable
    {
        DateTime? CreatedTime { get; set; }
        string CreatedBy { get; set; }
        DateTime? UpdatedTime { get; set; }
        string UpdatedBy { get; set; }
    }
}