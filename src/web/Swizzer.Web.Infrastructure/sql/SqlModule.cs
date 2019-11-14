using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using Swizzer.Web.Infrastructure.Extensions;
using Microsoft.Extensions.Configuration;

namespace Swizzer.Web.Infrastructure.sql
{
    public class SqlModule: Autofac.Module
    {
        private readonly IConfiguration _configuration;

        public SqlModule(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void Load(ContainerBuilder builder)
        {
            var settings = _configuration.GetSettings<SqlSettings>();

            builder.RegisterInstance(settings)
                .AsSelf()
                .SingleInstance();
            
            builder.RegisterType<SwizzerContext>()
                .InstancePerLifetimeScope();

            base.Load(builder);
        }

    }
}
