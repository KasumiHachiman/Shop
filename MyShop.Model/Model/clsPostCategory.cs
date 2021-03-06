﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Model.Model
{
    [Table("PostCategory")]
    public class clsPostCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        public string Name { set; get; }
        [Required]
        public string Alias { set; get; }

        public string Description { set; get; }

        public string ParentID { set; get; }

        public int DisplayOrder { set; get; }

        public string Image { set; get; }

        public bool HomeFlag { set; get; }
        //out list clspost
        public virtual IEnumerable<clsPost> Posts { set; get; }
    }
}
