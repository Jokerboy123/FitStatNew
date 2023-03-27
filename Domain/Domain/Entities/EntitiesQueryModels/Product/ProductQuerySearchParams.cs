using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.EntitiesQueryModels.Product
{
    public class ProductQuerySearchParams
    {
       public int Page { get; set; } = 1;
       public Guid? BrandId { get; set; }
       public Guid? WorkingUserId { get; set; }
       public string SearchName { get; set; }
       public int Take { get; set; } = 25;
    }
}
