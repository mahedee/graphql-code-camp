using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMS.Database
{
    public class SeedDataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SMSContext(
                serviceProvider.GetRequiredService<DbContextOptions<SMSContext>>()))
            {
                // Check any employee exists 
                if (context.Students.Any())
                {
                    return; // Data already exists no need to generate
                }

                context.Students.AddRange(
                    new Student
                    {
                        Id = 1,
                        Name = "Tahiya Hasan Arisha",
                        CellNo = "+88 0167891780",
                        FathersName = "Mahedee Hasan",
                        MothersName = "Khaleda Islam"
                    },
                    new Student
                    {
                        Id = 2,
                        Name = "Humaira Hasan",
                        CellNo = "+88 0177891780",
                        FathersName = "Mahedee Hasan",
                        MothersName = "Khaleda Islam"
                    },
                    new Student
                    {
                        Id = 3,
                        Name = "Mahedee Hasan",
                        CellNo = "+88 0187891780",
                        FathersName = "Easin Bhuiyan",
                        MothersName = "Moriam Begum"
                    }
                );
                context.SaveChanges();

            }
        }

    }
}
