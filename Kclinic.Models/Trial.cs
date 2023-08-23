﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kclinic.Models
{
    public class Trial
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string Email { get; set; }
        public string Field { get; set; }
        public int Phone { get; set; }
        public string Message { get; set; }
    }
}
