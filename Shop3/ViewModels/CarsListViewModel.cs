using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop3.Data.Models;

namespace Shop3.ViewModels
{
    public class CarsListViewModel
    {
        public IEnumerable<Car> allCars { get; set; }

        public string currCategory { get; set; }
    }
}
