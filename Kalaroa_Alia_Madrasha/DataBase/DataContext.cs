using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kalaroa_Alia_Madrasha.DataBase
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Kalaroa_Alia_Madrasha.Models.Users> Users { get; set; }
        public DbSet<Kalaroa_Alia_Madrasha.Models.Actor> Actor { get; set; }
        public DbSet<Kalaroa_Alia_Madrasha.Models.Admin> Admin { get; set; }
        public DbSet<Kalaroa_Alia_Madrasha.Models.Result> Result { get; set; }
        public DbSet<Kalaroa_Alia_Madrasha.Models.Teacher> Teacher { get; set; }
        public DbSet<Kalaroa_Alia_Madrasha.Models.Student> Student { get; set; }
        public DbSet<Kalaroa_Alia_Madrasha.Models.TeacherAccount> TeacherAccount { get; set; }
        public DbSet<Kalaroa_Alia_Madrasha.Models.StudentAccount> StudentAccount { get; set; }
        public DbSet<Kalaroa_Alia_Madrasha.Models.Admission> Admission { get; set; }
        public DbSet<Kalaroa_Alia_Madrasha.Models.StudentPayment> StudentPayment { get; set; }
    }
}
