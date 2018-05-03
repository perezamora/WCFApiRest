using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demowcf.Business.Facade.WebService
{
    public class IocConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule(new WebApiIocModule());

            var container = builder.Build();

            return container;
        }
    }
}