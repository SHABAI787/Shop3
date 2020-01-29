using Microsoft.AspNetCore.Mvc;
using Shop3.Data.Interfaces;
using Shop3.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop3.Controllers
{
    public class HomeController: Controller
    {
        private IAllCars _carRep;
      
        public HomeController(IAllCars carRep)
        {
            _carRep = carRep;
        }

        public ViewResult Index()
        {
            var homeCars = new HomeViewModal
            {
                favCars = _carRep.getFavCars
            };
            return View(homeCars);
        }
    }
}
