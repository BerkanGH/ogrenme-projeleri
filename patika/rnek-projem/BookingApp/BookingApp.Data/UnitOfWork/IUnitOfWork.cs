using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.Data.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        Task<int> SaveChangesAsync();
        // kaç kayda etki ettiğini gösterdiği için int

        Task BeginTransaction();

        Task CommitTransaction();

        Task RollBackTransaction();


    }
}
