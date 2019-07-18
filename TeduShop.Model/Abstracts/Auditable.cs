using System;
using System.ComponentModel.DataAnnotations;

namespace TeduShop.Model.Abstracts
{
    public abstract class Auditable : IAuditable, ISeoable, ISwitchable
    {
        public DateTime? CreatedTime { get; set; }

        [MaxLength(256)]
        public string CreatedBy { get; set; }

        public DateTime? UpdatedTime { get; set; }

        [MaxLength(256)]
        public string UpdatedBy { get; set; }

        [MaxLength(256)]
        public string MetaKeyword { get; set; }

        [MaxLength(256)]
        public string MetaDescription { get; set; }

        public bool Status { get; set; }
    }
}