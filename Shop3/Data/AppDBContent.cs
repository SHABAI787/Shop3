using Microsoft.EntityFrameworkCore;
using Shop3.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop3.Data
{
    /// <summary>
    /// Используется для получения данных из базы данных
    /// </summary>
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {

        }

        //Функция которая устанавливает все данные
        public DbSet<Car> Car { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
