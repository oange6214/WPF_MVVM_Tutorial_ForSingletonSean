﻿using Microsoft.EntityFrameworkCore;

namespace WPF_MVVM_Reserve.DbContexts
{
    public class ReservoomDbContextFactory
    {
        private readonly string _connectionString;
        public ReservoomDbContextFactory(string connectionString)
        {
            _connectionString = connectionString;
        }
        public ReservoomDbContext CreateDbContext()
        {
            DbContextOptions options = new DbContextOptionsBuilder().UseSqlite(_connectionString).Options;

            return new ReservoomDbContext(options);
        }
    }
}
