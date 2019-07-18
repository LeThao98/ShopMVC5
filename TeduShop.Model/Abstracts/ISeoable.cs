using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Abstracts
{
    internal interface ISeoable
    {
        string MetaKeyword { get; set; }
        string MetaDescription { get; set; }
    }
}