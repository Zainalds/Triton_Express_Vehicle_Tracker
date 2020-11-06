using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Triton_Express_Vehicle_Tracker.Models;

namespace Triton_Express_Vehicle_Tracker.Models
{
    public class TritonExpressContext : DbContext
    {

        public TritonExpressContext(DbContextOptions<TritonExpressContext> options) : base(options)
        {

        }

        public DbSet<Vehicle> Vehicles { get; set; }

        public DbSet<Triton_Express_Vehicle_Tracker.Models.Waybill> Waybill { get; set; }
    }
}
