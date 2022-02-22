using catering.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace catering.Infrastructure
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<category>().HasData(new category[]
            {
                //new category()
                //{
                //    Id=1,
                //    name="人气top"
                //},
                //new category()
                //{
                //    Id=2,
                //    name="经典主食"
                //},
                //new category()
                //{
                //    Id=3,
                //    name="欢乐下午茶"
                //},
                //new category()
                //{
                //    Id=4,
                //    name="甜品坚果"
                //},
                //new category()
                //{
                //    Id=5,
                //    name="烘培轻食"
                //}
            });
        }
    }
}
