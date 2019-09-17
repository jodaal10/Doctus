//####################################################################
// Project:         Doctus
// Author:          Jonathan Dávila A.
// DATA:            16/09/2019
//####################################################################
namespace Doctus.DM.Actividad
{
    using Doctus.DM.Repository;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using DoctusDT;


    public interface IActividadRepository : IRepository<tbl_Actividades>
    {

    }

    public class ActividadRepository : Repository<tbl_Actividades>, IActividadRepository
    {
        public ActividadRepository(Doctus_BDHorasEntities Db) : base(Db)
        {

        }
    }
}
