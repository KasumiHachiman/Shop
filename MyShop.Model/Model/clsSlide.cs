using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Model.Model
{
    [Table("Slides")]
    public class clsSlide
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        public string Name { set; get; }
        
        public string Description { set; get; }

        public string Image { set; get; }

        public string URL { set; get; }

        public int DisplayOrder { set; get; }
        [Required]
        public bool Status { set; get; }
    }
}
