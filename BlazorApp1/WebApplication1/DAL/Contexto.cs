using Microsoft.EntityFrameworkCore;
using Libreria.Models;

namespace WebApplication1.DAL
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto> options): base(options) { }

        public DbSet<Vehiculos> Vehiculos { get; set;}
        public DbSet<VehiculosDetalle> VehiculosDetalle { get; set;}
        public DbSet<Accesorios> Accesorios { get; set;}
    }
}
