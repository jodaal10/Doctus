//####################################################################
// Project:         Doctus
// Author:          Jonathan Dávila A.
// DATA:            10/09/2019
//####################################################################
namespace Doctus.DM
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using DoctusDT;


    public class DMUsuario
    {
        /// <summary>
        /// Validar si el acceso que proporciona el usuario es correcto
        /// </summary>
        /// <param name="objUsuario"></param>
        /// <returns>tbl_Usuarios</returns>
        public tbl_Usuarios ValidarUsuario(tbl_Usuarios objUsuario) {
            using (Doctus_BDHorasEntities Db = new Doctus_BDHorasEntities()) {
                tbl_Usuarios User = new tbl_Usuarios();
                var Buscar = Db.tbl_Usuarios.Where(i => i.Usuario == objUsuario.Usuario && i.Clave == objUsuario.Clave).FirstOrDefault();
                if (Buscar != null)
                {
                    User.IdUsuario = Buscar.IdUsuario;
                    User.Usuario = Buscar.Usuario;
                    User.Clave = Buscar.Clave;
                    return User;
                }
                else {
                    return Buscar;
                }
            }
        }
    }
}
