using Microsoft.EntityFrameworkCore;
using SMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMS.Database
{
    public class SMSContext : DbContext
    {
        public SMSContext(DbContextOptions<SMSContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
            
        //    modelBuilder.Entity<Student>().HasData(
        //        new Student
        //        {
        //            Id = 1,
        //            Name = "Tahiya Hasan Arisha",
        //            CellNo = "+88 0167891780",
        //            FathersName = "Mahedee Hasan",
        //            MothersName = "Khaleda Islam"
        //        },
        //        new Student
        //        {
        //            Id = 2,
        //            Name = "Humaira Hasan",
        //            CellNo = "+88 0177891780",
        //            FathersName = "Mahedee Hasan",
        //            MothersName = "Khaleda Islam"
        //        },
        //        new Student
        //        {
        //            Id = 3,
        //            Name = "Mahedee Hasan",
        //            CellNo = "+88 0187891780",
        //            FathersName = "Easin Bhuiyan",
        //            MothersName = "Moriam Begum"
        //        }

        //     );

            //base.OnModelCreating(modelBuilder);
        //}
    }
}
