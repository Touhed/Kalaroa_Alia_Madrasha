using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kalaroa_Alia_Madrasha.Models
{
    public class Result
    {
        [Key]
        public Int64 SN { get; set; }
        public Int64 StudentId { get; set; }
        public string StudentName { get; set; }
        public string StSession { get; set; }
        public string SDepartment { get; set; }
        public string SClass { get; set; }
        public string ExamType { get; set; }
        public string Subject { get; set; }
        public Int64 Marks { get; set; }
    }
}
