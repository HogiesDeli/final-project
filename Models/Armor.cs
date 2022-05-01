using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace final_project
{
    public class Armor
    {
        public int ArmorID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Aname { get; set; }
    }
}