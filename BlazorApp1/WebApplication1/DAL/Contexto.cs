using Microsoft.EntityFrameworkCore;
using Libreria.Models;

namespace WebApplication1.DAL
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto> options): base(options) { }

        DbSet<Vehiculos> Vehiculos { get; set;}
        DbSet<VehiculosDetalle> VehiculosDetalle { get; set;}
        DbSet<Accesorios> Accesorios { get; set;}
    }
}
