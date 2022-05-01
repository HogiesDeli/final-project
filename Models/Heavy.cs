using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace final_project
{
    public class Heavy
    {
        public int HeavyID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Hname { get; set; }
    }
}