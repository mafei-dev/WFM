using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WFM.Database
{
    public interface IUnitOfWork
    {
        Guid Id { get; }
        IDbConnection Connection { get; }
        IDbTransaction Transaction { get; }
        void Begin();
        void Commit();
        void Rollback();
    }
}
