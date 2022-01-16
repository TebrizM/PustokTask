﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PustokTask.Models
{
    public class Genre:BaseEntity
    {
        [Required]
        [StringLength(maximumLength: 50)]
        public string Name { get; set; }

    }
}
