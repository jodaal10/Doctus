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

    public interface IBMActividad
    {
        List<tbl_Actividades> ListarActividades(int idUsuario);
        bool CrearActividad(tbl_Actividades objActivity);
        bool EliminarActividad(int idActivity);
    }


    public class BMActividad : IBMActividad
    {
        private IActividadRepository ObjActividadRepository;
        public BMActividad(IActividadRepository actividadRepository)
        {
            ObjActividadRepository = actividadRepository;
        }

        /// <summary>
        /// listar las actividades correspondientes a un usuario
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <returns>List<tbl_Actividades></returns>
        public List<tbl_Actividades> ListarActividades(int idUsuario)
        {
            try
            {
                List<tbl_Actividades> Actividades = new List<tbl_Actividades>();
                var Buscar = ObjActividadRepository.GetAllBy(i => i.IdUsuario == idUsuario).ToList();
                if (Buscar != null)
                {

                    Actividades = (from Activity in Buscar.AsEnumerable()
                                   select new tbl_Actividades
                                   {
                                       IdActividad = Activity.IdActividad,
                                       Descripcion = Activity.Descripcion,
                                       IdUsuario = idUsuario

                                   }).ToList();

                    return Actividades;
                }
                else
                {
                    return Actividades;
                }

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
                ObjActividadRepository.Create(objActivity);
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
                //var tiempo = ObjActividadRepository.FindById(idActivity);
                //foreach (var m in tiempo.tbl_Tiempos)
                //{
                //    ObjActividadRepository.Delete(m);
                //}

                tbl_Actividades eli = ObjActividadRepository.FindById(idActivity);
                ObjActividadRepository.Delete(eli);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
