﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetManagement.Model
{
    [Table("Unit")]
    public class Unit
    {
        public Unit()
        {
            Products = new HashSet<Product>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_Unit { get; set; }
        [ForeignKey("ID_Unit")]

        public virtual ICollection<Product> Products { get; set; }
        [Required]
        [Index(IsUnique = true)]
        [StringLength(100)]
        public string NameUnit { get; set; }
    }
}
