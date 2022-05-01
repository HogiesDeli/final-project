using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace final_project
{
    public class Primary
    {
        public int PrimaryID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Pname { get; set; }
    }
}