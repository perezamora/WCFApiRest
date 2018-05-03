using Autofac;
using Demowcf.Business.Logic;
using Demowcf.Business.Logic.Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace Demowcf.Business.Facade.WebService
{
    public class WebApiIocModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<Students>();

            builder.RegisterType<DemowcfBLService>()
                .As<IDemowcfBLService>();

            builder.RegisterModule(new BusinessIocModule());

            base.Load(builder);
        }

    }
}