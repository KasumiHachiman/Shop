using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Model.Model
{
    [Table("ProductTags")]
    public class clsProductTag
    {
        [Key]
        public int ProductID { set; get; }
        [Key]
        public string TagID { set; get; }
        [ForeignKey("ProductID")]
        public virtual clsProduct Product { set; get; }
        [ForeignKey("TagID")]
        public virtual clsTag Tag { set; get; }

    }
}
