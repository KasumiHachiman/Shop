using MyShop.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyShop.Model.Model
{
    [Table("Products")]
    public class clsProduct : clsAuditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]// create int autoindentity
        public int ID { set; get; }
        [Required]
        public string Name { set; get; }
        [Required]
        public string Alias { set; get; }

        public int CategoryID { set; get; }

        public string Image { set; get; }

        public XElement MoreImages { set; get; }
        
        public decimal Price { set; get; }

        public decimal? PromotionPrice { set; get; }//? allow null

        public int? Warranty { set; get; }

        public string Description { set; get; }

        public string Content { set; get; }

        public bool? HomeFlag { set; get; }

        public bool? HotFlag { set; get;}

        public int? ViewCount { set; get; }

        [ForeignKey("CategoryID")]// chi ra tham chieu den product category bang categorid
        public virtual clsProductCategory ProductCategory { set; get; }
        
        public virtual IEnumerable<clsProductTag> ProductTags { set; get; }

    }
}
