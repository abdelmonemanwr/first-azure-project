using Microsoft.EntityFrameworkCore;

namespace azure.Models
{
    public class AzureContext: DbContext
    {
        DbSet<azure> azures { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Azure;Integrated Security=True;Encrypt=False;");
            base.OnConfiguring(optionsBuilder);
        }



    }
}
