//####################################################################
// Project:         Doctus
// Author:          Jonathan Dávila A.
// DATA:            10/09/2019
//####################################################################
namespace Doctus.BM.Actividad
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Doctus.DM.Actividad;
    using DoctusDT;

    public class BMActividad
    {
        DMActividad Actividad = new DMActividad();

        /// <summary>
        /// listar las actividades correspondientes a un usuario
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <returns>List<tbl_Actividades></returns>
        public List<tbl_Actividades> ListarActividades(int idUsuario)
        {
            try
            {
                return Actividad.ListarActividades(idUsuario);
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
                Actividad.CrearActividad(objActivity);
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
                //validar maximo 8 horas
                var Sumar = Actividad.ListarTempos(objTiempo.IdActividad);
                int sum = Sumar.AsEnumerable().Sum(x => x.Tiempo);

                if ((sum + objTiempo.Tiempo) > 8)
                {
                    return 0; //Error maximo horas
                }
                else {
                    Actividad.CrearTiempo(objTiempo);
                    return 1;
                }
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
                return Actividad.ListarTempos(idActivity);
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
                Actividad.EliminarTiempo(idTiempo);
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
        public bool EliminarActividad(int idActivity)
        {
            try
            {
                Actividad.EliminarActividad(idActivity);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
