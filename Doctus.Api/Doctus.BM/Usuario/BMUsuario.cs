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

    public interface IBMUsuario
    {
        tbl_Usuarios ValidarUsuario(tbl_Usuarios objUsuario);
    }


    public class BMUsuario : IBMUsuario
    {
        private IUsuarioRepository ObjUsuarioRepository;

        public BMUsuario(IUsuarioRepository InitialUserRepository)
        {
            ObjUsuarioRepository = InitialUserRepository;
        }

        /// <summary>
        /// Validar si el acceso que proporciona el usuario es correcto
        /// </summary>
        /// <param name="objUsuario"></param>
        /// <returns>tbl_Usuarios</returns>
        public tbl_Usuarios ValidarUsuario(tbl_Usuarios objUsuario)
        {
            try
            {
                tbl_Usuarios User = new tbl_Usuarios();
                var Buscar = ObjUsuarioRepository.GetAllBy(i => i.Usuario == objUsuario.Usuario && i.Clave == objUsuario.Clave).FirstOrDefault();
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
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
