using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BDBlockchainTCC.Shared;

namespace BDBlockchainTCC.Server.Models
{
    public class BDBlockchainTCCServerContext : DbContext
    {
        public BDBlockchainTCCServerContext (DbContextOptions<BDBlockchainTCCServerContext> options)
            : base(options)
        {
        }

        public DbSet<BDBlockchainTCC.Shared.WeatherForecast> WeatherForecast { get; set; }
    }
}
