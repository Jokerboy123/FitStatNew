using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Category: TrackedEntity
    {  /// <summary>
       /// Наименование категории.
       /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// По умолчанию.
        /// </summary>
        public bool IsDefault { get; set; }
        /// <summary>
        /// Утверждена.
        /// </summary>
        public bool IsApproved { get; set; }
        /// <summary>
        /// Удалена.
        /// </summary>
        public bool IsRemoved { get; set; }
        /// <summary>
        /// Дата создания категории.
        /// </summary>
        public DateTime DateCreated { get; set; }
        /// <summary>
        /// Дата изменения категории.
        /// </summary>
        public DateTime? DateChanged { get; set; }
        /// <summary>
        /// Код пользователя.
        /// </summary>
        public Guid? UserId { get; set; }
        /// <summary>
        /// Если заполнено - содержит ссылку на родителя и является копией в корзине
        /// </summary>
        public Guid? CodeArchiveParent { get; set; }

        public User User { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();

    }
}
