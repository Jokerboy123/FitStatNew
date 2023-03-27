using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.EntitiesQueryModels.Product
{
    public class ProductSearchQueryModel : EntityImageQueryModel
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
        /// Стоимость.
        /// </summary>
        public double ProductPrice { get; set; }
    }
}
