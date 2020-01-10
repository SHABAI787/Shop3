using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop3.Data.Models;

namespace Shop3.Data.Interfaces
{
    public interface ICarsCategory
    {
        /// <summary>
        /// Возвращает все категории
        /// </summary>
        IEnumerable<Category> AllCategories { get; }
    }
}
