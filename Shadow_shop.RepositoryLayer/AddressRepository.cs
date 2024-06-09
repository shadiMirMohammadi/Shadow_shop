using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shadow_shop.ModelsLayer;
using Shadow_shop.ModelsLayer.Context;

namespace Shadow_shop.RepositoryLayer
{
    public class AddressRepository : GenericRepository<Address>, IAddressRepository
    {
        public AddressRepository(CmsContext context) : base(context)
        {
        }
    }
}
