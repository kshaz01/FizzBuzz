using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using FizzBuzz.Domain.Abstract;
using FizzBuzz.Domain.Entities;
using FizzBuzz.Domain.Concrete;

namespace FizzBuzz
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = BuildUnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            container.RegisterType<IItemRepository, ItemRepository>();
            container.RegisterType<IAppItem, AppItem>();
            container.RegisterType<IInteraction, Interaction>();
   
            return container;

        }
    }
}