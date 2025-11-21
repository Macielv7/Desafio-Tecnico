using Microsoft.EntityFrameworkCore;
using WebApi_Tarefas.Model;


namespace WebApi_Tarefas.Data
{
    public class AppDbContext : DbContext
    {
       public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}
       public DbSet<Tarefa> Tarefas { get; set; }
    }
}