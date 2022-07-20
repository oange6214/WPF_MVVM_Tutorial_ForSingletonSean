using Microsoft.EntityFrameworkCore;
using WPF_MVVM_Reserve.DTOs;

namespace WPF_MVVM_Reserve.DbContexts
{
    public class ReservoomDbContext : DbContext
    {
        public ReservoomDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<ReservationDTO> Reservations { get; set; }
    }
}
