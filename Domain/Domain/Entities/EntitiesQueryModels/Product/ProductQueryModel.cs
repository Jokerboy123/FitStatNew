using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.EntitiesQueryModels.Product
{
    public class ProductQueryModel: Domain.Entities.Product
    { 
        /// <summary>
        /// Наименование бренда
        /// </summary>
        public string SellBrandProfileName { get; set; }
    }
}
