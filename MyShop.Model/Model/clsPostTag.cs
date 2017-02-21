using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Model.Model
{
    [Table("PostTags")]
    public class clsPostTag
    {
        [Key]
        public int PostID { set; get;}
        [Key]
        public string TagID { set; get; }
        [ForeignKey("PostID")]
        public virtual clsPost Post { set; get; }
        [ForeignKey("TagID")]
        public virtual clsTag Tag { set; get; }
        
    }
}
