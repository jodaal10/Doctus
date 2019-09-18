//####################################################################
// Project:         Doctus
// Author:          Jonathan Dávila A.
// DATA:            17/09/2019
//####################################################################
namespace Doctus.BM
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Doctus.DM.Tiempo;
    using DoctusDT;

    public interface IBMTiempo
    {
        int CrearTiempo(tbl_Tiempos objTiempo);
        List<tbl_Tiempos> ListarTempos(int idActivity);
        bool EliminarTiempo(int idTiempo);

    }

    public class BMTiempo : IBMTiempo
    {

        private ITiempoRepository ObjTiempoRepository;
        public BMTiempo(ITiempoRepository tiempoRepository)
        {
            ObjTiempoRepository = tiempoRepository;
        }

        /// <summary>
        /// Metodo para registrar los tiempos de una actividad
        /// </summary>
        /// <param name="objTiempo"></param>
        public int CrearTiempo(tbl_Tiempos objTiempo)
        {
            try
            {
                ObjTiempoRepository.Create(objTiempo);
                return 1;

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
        public List<tbl_Tiempos> ListarTempos(int idActivity)
        {
            try
            {
                List<tbl_Tiempos> Tiempos = new List<tbl_Tiempos>();
                var Buscar = ObjTiempoRepository.GetAllBy(i => i.IdActividad == idActivity).ToList();
                if (Buscar != null)
                {
                    Tiempos = (from Time in Buscar.AsEnumerable()
                               select new tbl_Tiempos
                               {
                                   IdActividad = Time.IdActividad,
                                   IdTiempo = Time.IdTiempo,
                                   Fecha = Time.Fecha,
                                   Tiempo = Time.Tiempo
                               }).ToList();

                    return Tiempos;
                }
                else
                {
                    return Tiempos;
                }
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
        public bool EliminarTiempo(int idTiempo)
        {
            try
            {
                tbl_Tiempos eli = ObjTiempoRepository.FindById(idTiempo);
                ObjTiempoRepository.Delete(eli);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
