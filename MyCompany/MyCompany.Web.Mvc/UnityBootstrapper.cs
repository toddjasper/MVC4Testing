﻿using System.Web.Mvc;
using Couchbase;
using Microsoft.Practices.Unity;
using MyCompany.Web.Mvc.REST.Downloaders;
using Unity.Mvc3;

namespace MyCompany.Web.Mvc
{
    public static class UnityBootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer()
                //.RegisterType<ITestService, TestService>()
                .RegisterType<IDownloader, HttpDownloader>()
                .RegisterInstance<ICouchbaseClient>(new CouchbaseClient());
            
            return container;
        }
    }
}
