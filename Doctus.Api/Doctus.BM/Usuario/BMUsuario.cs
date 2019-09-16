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

    public class BMUsuario
    {
        DMUsuario Usuario = new DMUsuario();

        /// <summary>
        /// Validar si el acceso que proporciona el usuario es correcto
        /// </summary>
        /// <param name="objUsuario"></param>
        /// <returns>bool</returns>
        public tbl_Usuarios ValidarUsuario(tbl_Usuarios objUsuario)
        {
            try
            {
                return Usuario.ValidarUsuario(objUsuario);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
