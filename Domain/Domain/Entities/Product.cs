using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Product: TrackedEntity
    { 
        /// <summary>      
        /// Наименование товара.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Описание товара.
        /// </summary>
        public string Description { get; set; }      
        /// <summary>
        /// Индекс продукта.
        /// </summary>
        public int ProductIndex { get; set; }
        /// <summary>
        /// Рейтинг продукта.
        /// </summary>
        public int ProductRating { get; set; }
        /// <summary>
        /// масса.
        /// </summary>
        public double ProductWeight { get; set; }
        /// <summary>
        /// Стоимость.
        /// </summary>
        public double ProductPrice { get; set; }
        /// <summary>
        /// Удален.
        /// </summary>
        public bool IsRemoved { get; set; }
        /// <summary>
        /// Товар в наличии
        /// </summary>
        public bool IsPresent { get; set; }
        /// <summary>
        /// максимально продаваемое кол-во данного товара в сутки
        /// </summary>
        public int? AmountPerDay { get; set; }
        /// <summary>
        /// Скидка на товар
        /// </summary>
        public double? Sale { get; set; }     
        /// <summary>
        /// время доставки, если товар доставят сегодня
        /// </summary>
        public DateTime TimeDeliveryToday { get; set; }
        /// <summary>
        /// время доставки, если товар доставят через х дней
        /// </summary>
        public DateTime TimeDeliveryInXDays { get; set; }
        /// <summary>
        /// сколько дней ждать доставку
        /// </summary>
        public int AwaitingDeliveryInDays { get; set; }
        /// <summary>
        /// Код категории.
        /// </summary>
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        /// <summary>
        /// Код бренда.
        /// </summary>
        public Guid SellBrandProfileId { get; set; }
        public SellBrandProfile SellBrandProfile { get; set; }
        /// <summary>
        /// Если заполнено - содержит ссылку на родителя и является копией в корзине
        /// </summary>
        public Guid? CodeArchiveParent { get; set; }
        /// <summary>
        /// Код пользователя.
        /// </summary>
        public Guid? UserId { get; set; }
        public User User { get; set; }
    }
}
