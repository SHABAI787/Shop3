using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop3.Data.Interfaces;
using Shop3.Data.Models;

namespace Shop3.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category{ categoryName = "Электромобили",desc = "Современный вид транспорта"},
                    new Category{categoryName = "Классические автомобили", desc = "Машины с двигателем внутреннего згорания"}
                };
                
            }
        }
    }
}
