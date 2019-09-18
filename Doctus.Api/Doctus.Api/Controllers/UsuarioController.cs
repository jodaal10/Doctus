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
    using BM.Usuario;
    using DoctusDT;
    
    
    public class UsuarioController : ApiController
    {
        protected IBMUsuario ObjBM;
       
        public UsuarioController(IBMUsuario Usuario) {
            ObjBM = Usuario;
        }
        /// <summary>
        /// Validar si el acceso que proporciona el usuario es correcto
        /// </summary>
        /// <param name="objUsuario"></param>
        /// <returns>bool</returns>
        [AllowAnonymous]
        [HttpPost]
        public tbl_Usuarios ValidarUsuario(tbl_Usuarios objusuario)
        {
            try
            {
                return ObjBM.ValidarUsuario(objusuario);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
