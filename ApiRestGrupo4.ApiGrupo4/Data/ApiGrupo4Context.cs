using ApiRestGrupo4.ApiGrupo4.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiRestGrupo4.ApiGrupo4.Data
{
    public class ApiGrupo4Context : DbContext
    {
        public ApiGrupo4Context(DbContextOptions<ApiGrupo4Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Materia> Materias { get; set; }
    }
}
