﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OngProject.Entities
{
    public class CategorieModel : EntityBase
    {
        [Required]
        public string NameCategorie { get; set; }
        [Required]
        public string DescriptionCategorie { get; set; }
        [Required]
        public string Image { get; set; }
    }
}
