using Autofac;
using Autofac.Integration.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace ZXBlog.WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        private void InAutofac()
        {
            var configuration = GlobalConfiguration.Configuration;
            var builder = new ContainerBuilder();
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterWebApiFilterProvider(configuration);


            Assembly[] services =
        {
            Assembly.Load("ZXBlog.IDAL"),
            Assembly.Load("ZXBlog.DAL"),
            Assembly.Load("ZXBlog.IBLL"),
            Assembly.Load("ZXBlog.BLL")
        };

            builder.RegisterAssemblyTypes(services).Where(r => !r.IsAbstract).AsImplementedInterfaces().SingleInstance()
                .PropertiesAutowired();


            var container = builder.Build();

            var resolver = new AutofacWebApiDependencyResolver(container);
            configuration.DependencyResolver = resolver;
        }


        protected void Application_Start()
        {
            InAutofac();

            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}