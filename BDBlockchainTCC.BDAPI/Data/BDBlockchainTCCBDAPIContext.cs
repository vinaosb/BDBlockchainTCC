using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BDBlockchainTCC.Shared;

namespace BDBlockchainTCC.BDAPI.Models
{
    public class BDBlockchainTCCBDAPIContext : DbContext
    {
        public BDBlockchainTCCBDAPIContext(DbContextOptions<BDBlockchainTCCBDAPIContext> options)
            : base(options)
        {
        }

        public DbSet<BDBlockchainTCC.Shared.WeatherForecast> WeatherForecast { get; set; }
    }
}
