using Shop3.Data.Interfaces;
using Shop3.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shop3.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();


        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car
                    {
                        name = "Тесла 1",
                        shortDesc="shortDesc Тесла 1",
                        longDesc = "longDesc Тесла 1",
                        img="/img/1.jfif",
                        price = 45000,
                        isFavourite = true,
                        available=true,
                        Category = _categoryCars.AllCategories.First()
                    },

                    new Car
                    {
                        name = "Тесла 2",
                        shortDesc="shortDesc Тесла 2",
                        longDesc = "longDesc Тесла 2",
                        img="/img/1.jfif",
                        price = 55000,
                        isFavourite = true,
                        available=false,
                        Category = _categoryCars.AllCategories.First()
                    },

                    new Car
                    {
                        name = "ВАЗ 2107",
                        shortDesc="shortDesc ВАЗ 2107",
                        longDesc = "longDesc ВАЗ 2107",
                        img="/img/2.jpeg",
                        price = 15000,
                        isFavourite = true,
                        available=true,
                        Category = _categoryCars.AllCategories.Last()
                    },

                    new Car
                    {
                        name = "Тесла 3",
                        shortDesc="shortDesc Тесла 3",
                        longDesc = "longDesc Тесла 3",
                        img="/img/1.jfif",
                        price = 45000,
                        isFavourite = true,
                        available=true,
                        Category = _categoryCars.AllCategories.First()
                    },

                    new Car
                    {
                        name = "ВАЗ 2107 2",
                        shortDesc="shortDesc ВАЗ 2107 2",
                        longDesc = "longDesc ВАЗ 2107 2",
                        img="/img/2.jpeg",
                        price = 15000,
                        isFavourite = true,
                        available=true,
                        Category = _categoryCars.AllCategories.Last()
                    },

                    new Car
                    {
                        name = "Тесла 4",
                        shortDesc="shortDesc Тесла 4",
                        longDesc = "longDesc Тесла 4",
                        img="/img/1.jfif",
                        price = 45000,
                        isFavourite = true,
                        available=true,
                        Category = _categoryCars.AllCategories.First()
                    },

                };

            }
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
