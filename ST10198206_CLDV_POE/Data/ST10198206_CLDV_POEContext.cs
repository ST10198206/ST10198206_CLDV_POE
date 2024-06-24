using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ST10198206_CLDV_POE.Models;

namespace ST10198206_CLDV_POE.Data
{
    public class ST10198206_CLDV_POEContext : DbContext
    {
        public ST10198206_CLDV_POEContext (DbContextOptions<ST10198206_CLDV_POEContext> options)
            : base(options)
        {
        }

        public DbSet<ST10198206_CLDV_POE.Models.Item> Item { get; set; }
    }
}
