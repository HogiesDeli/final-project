using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace final_project
{
    public class Secondary
    {
        public int SecondaryID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Sname { get; set; }
    }
}