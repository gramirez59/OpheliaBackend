using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Ophelia.Authorization.Roles;
using Ophelia.Authorization.Users;
using Ophelia.MultiTenancy;
using Ophelia.Entidades;

namespace Ophelia.EntityFrameworkCore
{
    public class OpheliaDbContext : AbpZeroDbContext<Tenant, Role, User, OpheliaDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public OpheliaDbContext(DbContextOptions<OpheliaDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Venta> Venta { get; set; }
        public virtual DbSet<ArticuloVenta> ArticuloVenta { get; set; }

        public virtual DbSet<ProductosVendidos> ProductosVendidos { get; set; }
    }
}
