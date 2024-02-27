using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Data
{
    public class MyAppContext:DbContext 
    {
        public DbSet<App> Apps { get; set; }
    }
}
