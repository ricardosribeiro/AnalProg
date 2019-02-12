using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Infra.Repositories
{
    public class SalesOrderRepository : RepositoryBase<SalesOrder>, ISalesOrderRepository
    {
        public IEnumerable<SalesOrder> GetAllWithUser()
        {
            return db.SalesOrders.Include("User").ToList();
        }
    }
}
