using Kalaroa_Alia_Madrasha.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kalaroa_Alia_Madrasha.Models
{
    public class StudentAccount
    {
        [Key]
        public Int64 StudentId { get; set; }
        public string StudentName { get; set; }
        public Int64 PaymentStatus { get; set; }
    }    
}

