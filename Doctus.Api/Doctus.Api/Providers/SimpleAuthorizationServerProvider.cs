using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using Doctus.DM;
using DoctusDT;

namespace Doctus.Api.Providers
{
    public class SimpleAuthorizationServerProvider: OAuthAuthorizationServerProvider
    {

        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {

            context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });
            DMUsuario objUser = new DMUsuario();
            tbl_Usuarios User = new tbl_Usuarios();
            tbl_Usuarios UserAuth = new tbl_Usuarios();
            User.Clave = context.Password;
            User.Usuario = context.UserName;
            UserAuth = objUser.ValidarUsuario(User);

            if (UserAuth == null)
            {
                context.SetError("invalid_grant", "The user name or password is incorrect.");
                return;
            }
            
            var identity = new ClaimsIdentity(context.Options.AuthenticationType);
            identity.AddClaim(new Claim("sub", context.UserName));
            identity.AddClaim(new Claim("role", "user"));

            context.Validated(identity);

        }
    }
}