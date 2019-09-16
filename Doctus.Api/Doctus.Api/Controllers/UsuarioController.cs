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
    

    [EnableCors(origins:"http://localhost:4200",headers:"*",methods:"*")]
    public class UsuarioController : ApiController
    {
        BMUsuario Usuario = new BMUsuario();
        /// <summary>
        /// Validar si el acceso que proporciona el usuario es correcto
        /// </summary>
        /// <param name="objUsuario"></param>
        /// <returns>bool</returns>
        public tbl_Usuarios ValidarUsuario(tbl_Usuarios objusuario) {
            try
            {
                return Usuario.ValidarUsuario(objusuario);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
