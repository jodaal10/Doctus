//####################################################################
// Project:         Doctus
// Author:          Jonathan Dávila A.
// DATA:            10/09/2019
//####################################################################
namespace Doctus.Api.Controllers
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using System.Web.Http.Cors;
    using BM.Actividad;
    using DoctusDT;

    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class ActividadController : ApiController
    {
        private IBMActividad ObjActividad;

        public ActividadController(IBMActividad Actividad) {
            ObjActividad = Actividad;
        }

        /// <summary>
        /// listar las actividades correspondientes a un usuario
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <returns>List<tbl_Actividades></returns>
        [HttpGet]
        public List<tbl_Actividades> ListarActividades(int idUsuario)
        {
            try
            {
                return ObjActividad.ListarActividades(idUsuario);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Metodo para crear actividades para un usuario
        /// </summary>
        /// <param name="objActivity"></param>
        public bool CrearActividad(tbl_Actividades objActivity)
        {
            try
            {
                ObjActividad.CrearActividad(objActivity);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Metodo para eliminar una actividad
        /// </summary>
        /// <param name="idActivity"></param>
        [HttpGet]
        public bool EliminarActividad(int idActivity)
        {
            try
            {
                ObjActividad.EliminarActividad(idActivity);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
