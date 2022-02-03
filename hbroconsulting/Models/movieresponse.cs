﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace hbroconsulting.Models
{
    public class movieresponse
    {
        [Key]
        [Required]
        public int MovieId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        [MaxLength(25)]
        public string Rating{ get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        public string Notes { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
