using _1066_Giurgiteanu_Mihai_Andrei.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1066_Giurgiteanu_Mihai_Andrei
{
    [Serializable]
    internal class ContractContext : DbContext
    {
        public ContractContext()
        {
            try
            {
                Database.Migrate();
            }
            catch (Exception)
            {
                Console.WriteLine("Database already exists." +
                " No additional migration have to be applied.");
            }
        }
        public DbSet<Contract> Contracts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=contracts.db");
        }
    }
}
