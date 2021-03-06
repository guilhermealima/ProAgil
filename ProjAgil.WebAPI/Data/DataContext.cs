using Microsoft.EntityFrameworkCore;
using ProjAgil.WebAPI.Models;

namespace ProjAgil.WebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options){ }

        public DbSet<Evento> Eventos { get; set; }
    }
}