using Microsoft.AspNetCore.Mvc;
using Shop3.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop3.ViewModels;

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
        public ViewResult List()
        {
            //ViewBag.Category = "Some New";//автоматически сам по себе передаётся в шаблон
            //var cars = _allCars.Cars;
            ViewBag.Title = "Страница с автомобилями";
            CarsListViewModel obj = new CarsListViewModel();
            obj.allCars = _allCars.Cars;
            obj.currCategory = "Авомобили";
            return View(obj);
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
