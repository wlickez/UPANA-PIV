
using DapperModels;
using Microsoft.EntityFrameworkCore;

public class EntityContext : DbContext
{
    private string _connectionString;
    public EntityContext(string connectionString)
    {
        _connectionString = connectionString;
    }
    public DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(_connectionString);


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.ToTable("USUARIO");
            entity.HasKey(e => e.Codigo);
            entity.Property(e => e.Codigo).IsRequired();
            entity.Property(e => e.Nombre);
            entity.Property(e => e.NombreCompleto);
            entity.Property(e => e.CodigoEstado);
        });
    }
    

}