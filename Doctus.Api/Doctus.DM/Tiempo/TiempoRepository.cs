//####################################################################
// Project:         Doctus
// Author:          Jonathan Dávila A.
// DATA:            17/09/2019
//####################################################################
namespace Doctus.DM.Tiempo
{
    using Doctus.DM.Repository;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using DoctusDT;



    public interface ITiempoRepository : IRepository<tbl_Tiempos>
    {

    }
    public class TiempoRepository : Repository<tbl_Tiempos>, ITiempoRepository
    {
        public TiempoRepository(Doctus_BDHorasEntities Db) : base(Db)
        {

        }
    }
}
