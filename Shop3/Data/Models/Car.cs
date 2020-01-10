using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop3.Data.Models
{
    public class Car
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int id { set; get; }

        /// <summary>
        /// Название машины
        /// </summary>
        public string name { set; get; }

        /// <summary>
        /// Короткое описание
        /// </summary>
        public string shortDesc { set; get; }

        /// <summary>
        /// Длинное описание
        /// </summary>
        public string longDesc { set; get; }

        /// <summary>
        /// Путь к Изображению
        /// </summary>
        public string img { set; get; }

        /// <summary>
        /// Стоимсоть
        /// </summary>
        public ushort price { set; get; }

        /// <summary>
        /// Показывать на главной странице
        /// </summary>
        public bool isFavourite { set; get; }

        /// <summary>
        /// Доступна для продажи
        /// </summary>
        public bool available { set; get; }

        /// <summary>
        /// ID категории
        /// </summary>
        public int CategoryID { set; get; }

        /// <summary>
        /// Сатегория
        /// </summary>
        public virtual Category Category { set; get; }
    }
}
