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
                        img="https://moscowteslaclub.ru/upload/iblock/213/2134afc74cb179108eec91c0174ab591.JPG",
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
                        img="https://moscowteslaclub.ru/upload/iblock/213/2134afc74cb179108eec91c0174ab591.JPG",
                        price = 55000,
                        isFavourite = true,
                        available=true,
                        Category = _categoryCars.AllCategories.First()
                    },

                    new Car
                    {
                        name = "ВАЗ 2107",
                        shortDesc="shortDesc ВАЗ 2107",
                        longDesc = "longDesc ВАЗ 2107",
                        img="https://i.quto.ru/c533x400/4c6bc6cd43705.jpeg",
                        price = 15000,
                        isFavourite = true,
                        available=true,
                        Category = _categoryCars.AllCategories.Last()
                    }

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
