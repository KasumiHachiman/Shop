using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyShop.Model.Model
{
    [Table("Footers")]//chi ra class rent ten bang
    public class clsFooter
    {
        [Key]//thuoc tinh khoa
        [MaxLength(50)]
        public string ID { set; get; }

        [Required]//ko rong
        public string Content { set; get; }
    }
}