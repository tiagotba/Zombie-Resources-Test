using System.Web.Http;
using Unity;
using Unity.WebApi;
using WebApiZombieResources.Repositories;

namespace WebApiZombieResources
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            container.RegisterType<IRecursosRepository, RecursoRepository>();
            container.RegisterType<IRecursoEntradaRepository, RecursoEntradaRepository>();
            container.RegisterType<IRecursoSaidaRepository, RecursoSaidaRepository>();
            container.RegisterType<ISobreviventeRepository, SobreviventeRepository>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }


    }
}