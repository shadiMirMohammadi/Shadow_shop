using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shadow_shop.ModelsLayer;
using Shadow_shop.ModelsLayer.Context;

namespace Shadow_shop.ServicesLayer
{
    public class SupportSiteService : EntityService<SupportSite>, ISupportSiteService
    {
        public SupportSiteService(CmsContext context) : base(context)
        {
        }
    }
}
