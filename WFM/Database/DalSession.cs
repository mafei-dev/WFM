using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WFM.Database
{
    public sealed class DalSession : IDisposable
    {
        IDbConnection _connection;
        UnitOfWork _unitOfWork;
        public DalSession()
        {
            _connection = new SqlConnection(Helper.ConnectionString());
            _connection.Open();
            _unitOfWork = new UnitOfWork(_connection);
        }

        public UnitOfWork UnitOfWork()
        {
            return _unitOfWork;
        }
        public void Dispose()
        {
            _unitOfWork.Dispose();
            _connection.Dispose();
        }
    }
}
