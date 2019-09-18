using System.Web.Http;
using Unity;
using Unity.WebApi;
using Doctus.BM;
using Doctus.DM;
using Doctus.DM.Usuario;
using System.Data.Entity;
using DoctusDT;
using Doctus.BM.Usuario;

namespace Doctus.Api
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            //Configuracion inyeccion usuario
            container.RegisterType<IUsuarioRepository,UsuarioRepository>();
            container.RegisterType<IBMUsuario, BMUsuario>();
            //Configuracion inyeccion actividades
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}