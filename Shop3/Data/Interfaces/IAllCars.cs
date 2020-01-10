using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop3.Data.Models;

namespace Shop3.Data.Interfaces
{
    
    interface IAllCars
    {
        /// <summary>
        /// Возвращает или задаёт машины
        /// </summary>
        IEnumerable<Car> Cars { get; }

        /// <summary>
        /// Возращает только те машины где available==true
        /// </summary>
        IEnumerable<Car> getFavCars { get; set; }

        /// <summary>
        /// Возвращает машину по ID
        /// </summary>
        /// <param name="carId">ID машины</param>
        /// <returns></returns>
        Car getObjectCar(int carId);
    }
}
