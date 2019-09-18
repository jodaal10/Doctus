using System.Web.Http;
using Unity;
using Unity.WebApi;
using Doctus.BM;
using Doctus.DM;
using Doctus.DM.Usuario;
using System.Data.Entity;
using DoctusDT;
using Doctus.BM.Usuario;
using Doctus.BM.Actividad;
using Doctus.DM.Actividad;
using Doctus.DM.Tiempo;

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
            container.RegisterType<IActividadRepository, ActividadRepository>();
            container.RegisterType<IBMActividad, BMActividad>();
            //Configuracion inyeccion tiempo
            container.RegisterType<ITiempoRepository, TiempoRepository>();
            container.RegisterType<IBMTiempo, BMTiempo>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}