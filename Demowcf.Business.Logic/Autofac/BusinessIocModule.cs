using Autofac;
using Demowcf.DataAcces.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demowcf.Business.Logic.Autofac
{
    public class BusinessIocModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(StudentRepository<>))
            .As(typeof(IStudentRepository<>));

            //builder.RegisterModule(new DataAccesIocModule());

            base.Load(builder);
        }
    }
}
