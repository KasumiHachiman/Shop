using MyShop.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Model.Model
{
    [Table("ProductCategories")]
    public class clsProductCategory : clsAuditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]// create int autoindentity
        public int ID { set; get; }
        [Required]
        [MaxLength(256)]
        public string Name { set; get; }
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(256)]
        public string Alias { set; get; }
        [MaxLength(500)]
        public string Description { set; get; }
        public int? ParentID { set; get; }
        public int? DisplayOrder { set; get; }
        public string Image { set; get; }
        public bool HomeFlag { set; get; }
        public virtual IEnumerable<clsProduct> Products { set; get; }
    }
}
