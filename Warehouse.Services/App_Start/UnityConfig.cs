﻿using Microsoft.Practices.Unity.Configuration;
using Warehouse.Services.Unity;
using System.Web.Http;
using Unity;


namespace Warehouse.Services.App_Start
{
    public class UnityConfig
    {
        private static IUnityContainer _container = new UnityContainer();
        public static void ConfiguredContainer()
        {
            _container.LoadConfiguration();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(_container);
        }
    }
}