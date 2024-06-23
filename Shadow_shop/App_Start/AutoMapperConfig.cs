using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Shadow_shop.ModelsLayer;
using Shadow_shop.Views.ViewModels;

namespace Shadow_shop.App_Start
{
    public class AutoMapperConfig
    {
        public static IMapper mapper;

        public static void Configuration()
        {
            MapperConfiguration configuration = new MapperConfiguration(t =>
            {
                t.CreateMap<Role, RoleViewModel>().IgnoreAllPropertiesWithAnInaccessibleSetter();
                t.CreateMap<RoleViewModel, Role>().IgnoreAllPropertiesWithAnInaccessibleSetter();
            });
            mapper = configuration.CreateMapper();
        }
    }
}