using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Model.Abstract
{
    public interface IAuditable
    {
        /// <summary>
        ///tao interface cho nhung thuoc tinh dung chung
        /// </summary>
        DateTime? CreatedDate { set; get;}
        string CreatedBy { set; get; }
        DateTime? UpdatedDate { set; get; }
        string UpdatedBy { set; get; }
        string MetaKeyword { set; get; }
        string MetaDescription { set; get; }
        bool Status { set; get; }
    }
}
