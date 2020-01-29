using Microsoft.AspNetCore.Mvc;
using Shop3.Data.Interfaces;
using Shop3.Data.Models;
using Shop3.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shop3.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat)
        {
            _allCars = iAllCars;
            _allCategories = iCarsCat;
        }

        /// <summary>
        /// Возвращает HTML страницу
        /// </summary>
        /// До того как будет выведена страничка мы добавляем все машины на неё
        /// <returns></returns>
        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Car> cars = null;
            string carrCategory = "";

            if (string.IsNullOrEmpty(category))
            {
                cars = _allCars.Cars.OrderBy(i => i.id);
            }
            else
            {
                if (string.Equals("electro", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Электромобили")).OrderBy(i => i.id);
                    carrCategory = "Электромобили";
                }
                else if (string.Equals("fuel", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Классические автомобили")).OrderBy(i => i.id);
                    carrCategory = "Классические автомобили";
                }

            }

            var carObj = new CarsListViewModel
            {
                allCars = cars,
                currCategory = carrCategory
            };
           
            ViewBag.Title = "Страница с автомобилями";
            
            return View(carObj);
        }








        /// <summary>
        /// Моя тестова проверка
        /// </summary>
        /// До того как будет выведена страничка мы добавляем все машины на неё
        /// <returns></returns>
        public ViewResult List2()
        {
            var cars = _allCars.Cars;
            return View(cars);
        }
    }
}
