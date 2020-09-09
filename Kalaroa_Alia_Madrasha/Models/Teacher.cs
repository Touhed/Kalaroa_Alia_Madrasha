﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kalaroa_Alia_Madrasha.Models
{
    public class Teacher
    {
        [Key]
        public Int64 Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }
    }
}
