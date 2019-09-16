//####################################################################
// Project:         Doctus
// Author:          Jonathan Dávila A.
// DATA:            10/09/2019
//####################################################################
namespace Doctus.DM.Actividad
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using DoctusDT;

    public class DMActividad
    {
        /// <summary>
        /// listar las actividades correspondientes a un usuario
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <returns>List<tbl_Actividades></returns>
        public List<tbl_Actividades> ListarActividades(int idUsuario)
        {
            using (Doctus_BDHorasEntities Db = new Doctus_BDHorasEntities())
            {
                List<tbl_Actividades> Actividades = new List<tbl_Actividades>();
                var Buscar = Db.tbl_Actividades.Where(i => i.IdUsuario == idUsuario).ToList();
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
        }

        /// <summary>
        /// Metodo para crear actividades para un usuario
        /// </summary>
        /// <param name="objActivity"></param>
        public void CrearActividad(tbl_Actividades objActivity)
        {
            using (Doctus_BDHorasEntities Db = new Doctus_BDHorasEntities())
            {
                Db.tbl_Actividades.Add(objActivity);
                Db.SaveChanges();
            }
        }

        /// <summary>
        /// Metodo para registrar los tiempos de una actividad
        /// </summary>
        /// <param name="objTiempo"></param>
        public void CrearTiempo(tbl_Tiempos objTiempo)
        {
            using (Doctus_BDHorasEntities Db = new Doctus_BDHorasEntities())
            {
                Db.tbl_Tiempos.Add(objTiempo);
                Db.SaveChanges();
            }
        }

        /// <summary>
        /// listar los tiempos correspondientes a una actividad
        /// </summary>
        /// <param name="idActivity"></param>
        /// <returns>List<tbl_Tiempos></returns>
        public List<tbl_Tiempos> ListarTempos (int idActivity)
        {
            using (Doctus_BDHorasEntities Db = new Doctus_BDHorasEntities())
            {
                List<tbl_Tiempos> Tiempos = new List<tbl_Tiempos>();
                var Buscar = Db.tbl_Tiempos.Where(i => i.IdActividad == idActivity).ToList();
                if (Buscar != null)
                {

                    Tiempos = (from Time in Buscar.AsEnumerable()
                                   select new tbl_Tiempos
                                   {
                                       IdActividad = Time.IdActividad,
                                       IdTiempo= Time.IdTiempo,
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
        }

        /// <summary>
        /// Metodo para eliminar un tiempo
        /// </summary>
        /// <param name="idTiempo"></param>
        public void EliminarTiempo(int idTiempo)
        {
            using (Doctus_BDHorasEntities Db = new Doctus_BDHorasEntities())
            {
                tbl_Tiempos eli = Db.tbl_Tiempos.Find(idTiempo);
                Db.tbl_Tiempos.Remove(eli);
                Db.SaveChanges();
            }
        }

        /// <summary>
        /// Metodo para eliminar una actividad
        /// </summary>
        /// <param name="idActivity"></param>
        public void EliminarActividad(int idActivity)
        {
            using (Doctus_BDHorasEntities Db = new Doctus_BDHorasEntities())
            {
                foreach (var m in Db.tbl_Tiempos.Where(f => f.IdActividad == idActivity))
                {
                    Db.tbl_Tiempos.Remove(m);
                }

                tbl_Actividades eli = Db.tbl_Actividades.Find(idActivity);
                Db.tbl_Actividades.Remove(eli);
                Db.SaveChanges();
            }

        }

    }
}
