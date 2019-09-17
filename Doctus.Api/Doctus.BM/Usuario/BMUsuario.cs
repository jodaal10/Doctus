//####################################################################
// Project:         Doctus
// Author:          Jonathan Dávila A.
// DATA:            10/09/2019
//####################################################################
namespace Doctus.BM.Usuario
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Doctus.DM;
    using DoctusDT;
    using Doctus.DM.Repository;
    using Doctus.DM.Usuario;

    public class BMUsuario
    {
        DMUsuario Usuario = new DMUsuario();
        /// <summary>
        /// Validar si el acceso que proporciona el usuario es correcto
        /// </summary>
        /// <param name="objUsuario"></param>
        /// <returns>bool</returns>
        //public tbl_Usuarios ValidarUsuario(tbl_Usuarios objUsuario)
        //{
        //    try
        //    {
        //        return Usuario.ValidarUsuario(objUsuario);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //}
        public tbl_Usuarios ValidarUsuario(tbl_Usuarios objUsuario)
        {
            try
            {
          
                using (Doctus_BDHorasEntities Db = new Doctus_BDHorasEntities())
                {
                    var objUsuarioRepository = new Repository<tbl_Usuarios>(Db);
                    tbl_Usuarios User = new tbl_Usuarios();
                    var Buscar = objUsuarioRepository.GetAllBy(i => i.Usuario == objUsuario.Usuario && i.Clave == objUsuario.Clave).FirstOrDefault();
                    if (Buscar != null)
                    {
                        User.IdUsuario = Buscar.IdUsuario;
                        User.Usuario = Buscar.Usuario;
                        User.Clave = Buscar.Clave;
                        return User;
                    }
                    else
                    {
                        return Buscar;
                    }
                }

               // var obj =  objUsuarioRepository.GetAllBy(i => i.Usuario == objUsuario.Usuario && i.Clave == objUsuario.Clave).FirstOrDefault();
               
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
