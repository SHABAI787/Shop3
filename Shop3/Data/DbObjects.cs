using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop3.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop3.Data
{
    public class DbObjects
    {
        public static void Initial(AppDBContent content)
        {
           
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(content => content.Value));

            if (!content.Car.Any())
            {
                content.AddRange(
                    new Car
                    {
                        name = "Тесла 1",
                        shortDesc = "shortDesc Тесла 1",
                        longDesc = "longDesc Тесла 1",
                        img = "/img/1.jfif",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Электромобили"]
                    },
                    new Car
                    {
                        name = "Тесла 2",
                        shortDesc = "shortDesc Тесла 2",
                        longDesc = "longDesc Тесла 2",
                        img = "/img/1.jfif",
                        price = 55000,
                        isFavourite = true,
                        available = false,
                        Category = Categories["Электромобили"]
                    },
                    new Car
                    {
                        name = "ВАЗ 2107",
                        shortDesc = "shortDesc ВАЗ 2107",
                        longDesc = "longDesc ВАЗ 2107",
                        img = "/img/2.jpeg",
                        price = 15000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car
                    {
                        name = "Тесла 3",
                        shortDesc = "shortDesc Тесла 3",
                        longDesc = "longDesc Тесла 3",
                        img = "/img/1.jfif",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Электромобили"]
                    },
                    new Car
                    {
                        name = "ВАЗ 2107 2",
                        shortDesc = "shortDesc ВАЗ 2107 2",
                        longDesc = "longDesc ВАЗ 2107 2",
                        img = "/img/2.jpeg",
                        price = 15000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car
                    {
                        name = "Тесла 4",
                        shortDesc = "shortDesc Тесла 4",
                        longDesc = "longDesc Тесла 4",
                        img = "/img/1.jfif",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Электромобили"]
                    }
                );
            }
            content.SaveChanges();
        }

        private static Dictionary<string, Category> categoriy;
        public static Dictionary<string,Category> Categories
        {
            get
            {
                if(categoriy == null)
                {
                    var list = new Category[]
                    {
                       new Category{ categoryName = "Электромобили",desc = "Современный вид транспорта"},
                       new Category{categoryName = "Классические автомобили", desc = "Машины с двигателем внутреннего згорания"}
                    };
                    categoriy = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        categoriy.Add(el.categoryName, el);
                }
                return categoriy;
            }
        }
    }
}
