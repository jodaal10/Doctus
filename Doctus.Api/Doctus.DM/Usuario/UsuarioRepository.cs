//####################################################################
// Project:         Doctus
// Author:          Jonathan Dávila A.
// DATA:            10/09/2019
//####################################################################
namespace Doctus.DM.Usuario
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using DoctusDT;
    using Doctus.DM.Repository;

    public interface IUsuarioRepository : IRepository<tbl_Usuarios>
    {

    }

    public class UsuarioRepository : Repository<tbl_Usuarios>, IUsuarioRepository
    {
        public UsuarioRepository(Doctus_BDHorasEntities Db) : base(Db)
        {

        }
    }
}
