using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class SellBrandProfile: TrackedEntity
    {
        /// <summary>     
        /// Рейтинг.
        /// </summary>
        public int Rating { get; set; }
        /// <summary>
        /// Наименование.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Описание продукта.
        /// </summary>
        public string Description { get; set; }      
        /// <summary>
        /// Удалён.
        /// </summary>
        public bool IsRemoved { get; set; }
        /// <summary>
        /// Радиус доставки.
        /// </summary>
        public double? DeliveryRadius { get; set; }
        /// <summary>
        /// Максимальный радиус доставки, до которого стоимость будет увеличиваться.
        /// </summary>
        public double? MaxDeliveryRadius { get; set; }
        /// <summary>
        /// Радиус доставки от точки широта.
        /// </summary>
        public double? DeliveryRadiusFromLat { get; set; }
        /// <summary>
        /// Радиус доставки от точки долгота.
        /// </summary>
        public double? DeliveryRadiusFromLng { get; set; }
        /// <summary>
        /// Стоимость доставки в рублях на км.
        /// </summary>
        public double? DeliveryPricePerUnit { get; set; }
        /// <summary>
        /// Код владельца.
        /// </summary>
        public Guid UserId { get; set; }
        public User User { get; set; }
        /// <summary>
        /// Если заполнено - содержит ссылку на родителя и является копией в корзине
        /// </summary>
        public Guid? CodeArchiveParent { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
