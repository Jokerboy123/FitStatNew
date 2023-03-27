using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.EntitiesQueryModels.SellBrandProfile
{
    public class SellBrandProfileSearchQueryModel: EntityImageQueryModel
    {
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
