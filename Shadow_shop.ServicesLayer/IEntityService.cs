using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shadow_shop.ModelsLayer;

namespace Shadow_shop.ServicesLayer
{
    public interface IEntityService<T> where T : BaseEntity
    {
        //اگه ما بخوایم بیایم  و یک حدمتی رو اجبار بکنیم که تمامی مدل های ما داشته باشن، اینجا تعریفش میکنیم.
    }
}
