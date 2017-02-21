using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Model.Model
{
    [Table("Tags")]
    public class clsTag
    {
        [Key]
        public string ID { set; get; }
        [Required]
        public string Name { set; get; }
        [Required]
        public string Type { set; get; }

        public virtual IEnumerable<clsPostTag> PostTags { set; get; }

        public virtual IEnumerable<clsProductTag> ProductTags { set; get; }
    }
}
