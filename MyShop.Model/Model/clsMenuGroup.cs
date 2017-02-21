using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyShop.Model.Model
{
    [Table("MenuGroup")]
    public class clsMenuGroup
    {
        [Key]// thuoc tinh la khoa chinh
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]// create int autoindentity
        public int ID { set; get; }

        [Required] // thuoc tinh ko dc null
        [MaxLength(50)]
        public string Name { set; get; }

        public virtual IEnumerable<clsMenu> Menus { set; get; }//tao list o bang cha de tro den bang con
    }
}