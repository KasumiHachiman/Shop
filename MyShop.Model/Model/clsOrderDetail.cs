using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Model.Model
{
    [Table("OrderDetail")]
    public class clsOrderDetail
    {
        [Key]
        public int OrderID { set; get; }
        [Key]
        public int ProductID { set; get; }
        public int Quantity { set; get; }

        [ForeignKey("OrderID")]
        public virtual clsOrder Order { set; get; }
        [ForeignKey("ProductID")]
        public virtual clsProduct Product { set; get; }
    }
}
