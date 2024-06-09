using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shadow_shop.ModelsLayer;
using Shadow_shop.ModelsLayer.Context;

namespace Shadow_shop.ServicesLayer
{
    public class ProductCategoryService : EntityService<ProductCategory>, IProductCategoryService
    {
        public ProductCategoryService(CmsContext context) : base(context)
        {
        }
    }
}
