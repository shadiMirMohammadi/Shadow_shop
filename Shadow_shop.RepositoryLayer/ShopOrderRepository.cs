using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shadow_shop.ModelsLayer;
using Shadow_shop.ModelsLayer.Context;

namespace Shadow_shop.RepositoryLayer
{
    public class ShopOrderRepository : GenericRepository<ShopOrder>, IShopOrderRepository
    {
        public ShopOrderRepository(CmsContext context) : base(context)
        {
        }
    }
}
