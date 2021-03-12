﻿using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using SimpleInjector.Lifestyles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using BankAPI.Models.BankAccountServices.Interfaces;
using BankAPI.Models.BankAccountServices;
using BankAPI.Models.CustomerServices.Interfaces;
using BankAPI.Models.CustomerServices;

namespace BankAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
        public static void RegisterSimpleInjector(HttpConfiguration config)
        {
            // Create the container as usual.
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();
            // Register your types, for instance using the scoped lifestyle:
            container.Register<IBankAccountService, BankAccountService>(Lifestyle.Scoped);
            container.Register<ICustomerService, CustomerService>(Lifestyle.Scoped);
            // This is an extension method from the integration package.
            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);

            container.Verify();
            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
        }
    }
}
