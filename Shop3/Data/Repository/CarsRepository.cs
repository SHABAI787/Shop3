using Microsoft.EntityFrameworkCore;
using Shop3.Data.Interfaces;
using Shop3.Data.Models;
using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Shop3.Data.Repository
{
    public class CarsRepository : IAllCars
    {
        private readonly AppDBContent appDBContent;

        public CarsRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Car> Cars => appDBContent.Car.Include(c => c.Category);

        public IEnumerable<Car> getFavCars => appDBContent.Car.Where(p => p.isFavourite).Include(c => c.Category);

        public Car getObjectCar(int carId) => appDBContent.Car.FirstOrDefault(p => p.id == carId);
       
    }
}
