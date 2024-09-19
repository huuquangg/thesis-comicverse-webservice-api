﻿using Microsoft.EntityFrameworkCore;
using thesis_comicverse_webservice_api.Models;

namespace thesis_comicverse_webservice_api.Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product>? Products { get; set; }

        protected readonly IConfiguration _configuration;

        public AppDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
            options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }
    }
}
