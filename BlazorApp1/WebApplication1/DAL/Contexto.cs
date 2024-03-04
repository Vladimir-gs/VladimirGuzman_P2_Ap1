using Microsoft.EntityFrameworkCore;

namespace WebApplication1.DAL
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto> options): base(options) { }
    }
}
