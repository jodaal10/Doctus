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
        BMActividad ObjActividad = new BMActividad();
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
        /// Metodo para registrar los tiempos de una actividad
        /// </summary>
        /// <param name="objTiempo"></param>
        public int CrearTiempo(tbl_Tiempos objTiempo)
        {
            try
            {
                return ObjActividad.CrearTiempo(objTiempo);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// listar los tiempos correspondientes a una actividad
        /// </summary>
        /// <param name="idActivity"></param>
        /// <returns>List<tbl_Tiempos></returns>
        [HttpGet]
        public List<tbl_Tiempos> ListarTempos(int idActivity)
        {
            try
            {
                return ObjActividad.ListarTempos(idActivity);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Metodo para eliminar un tiempo
        /// </summary>
        /// <param name="idTiempo"></param>
        [HttpGet]
        public bool EliminarTiempo(int idTiempo)
        {
            try
            {
                ObjActividad.EliminarTiempo(idTiempo);
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
