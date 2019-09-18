namespace Doctus.Api.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using System.Web.Http.Cors;
    using Doctus.BM;
    using DoctusDT;

    //[EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class TiempoController : ApiController
    {
        private IBMTiempo ObjTiempo;

        public TiempoController(IBMTiempo Tiempo)
        {
            ObjTiempo = Tiempo;
        }

        /// <summary>
        /// Metodo para registrar los tiempos de una actividad
        /// </summary>
        /// <param name="objTiempo"></param>
        [HttpPost]
        [Authorize]
        public int CrearTiempo(tbl_Tiempos objTiempo)
        {
            try
            {
                return ObjTiempo.CrearTiempo(objTiempo);
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
        [Authorize]
        public List<tbl_Tiempos> ListarTempos(int idActivity)
        {
            try
            {
                return ObjTiempo.ListarTempos(idActivity);
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
        [Authorize]
        public bool EliminarTiempo(int idTiempo)
        {
            try
            {
                ObjTiempo.EliminarTiempo(idTiempo);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
