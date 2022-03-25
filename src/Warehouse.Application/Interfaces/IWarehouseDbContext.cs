using Warehouse.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Warehouse.Application.Interfaces
{
    public interface IWarehouseDbContext
    {
        DbSet<ContactEntity> Comminucations  { get; set;}
    }
}
