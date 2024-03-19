using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public static class SeedData
    {
        public static void SeedStudent(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new[] {

                    new Student()
                    {
                        Id = 1,
                        FirstName="Igor",
                        LastName="Gapich",
                        Age =27
                    },
                    new Student()
                    {
                        Id = 2,
                        FirstName="Yarik",
                        LastName="Yevchuk",
                        Age =34
                    },
                    new Student()
                    {
                        Id = 3,
                        FirstName="Vasia",
                        LastName="Rudyka",
                        Age =35
                    }
                }
            );
        }
    }
}
