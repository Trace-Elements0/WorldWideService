using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    
    public class ApplicationDbContext : DbContext
    {
        //default if scaffolding
        public ApplicationDbContext() { }
        //intentionally empty
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=localhost;Initial Catalog=AdventureWorks2019;Trusted_Connection=True");
        }
    }
    /*
     * from pmc with this project selected run: 
     * Scaffold-DbContext 'Data Source=localhost;Initial Catalog=AdventureWorks2019;Trusted_Connection=True' Microsoft.EntityFrameworkCore.SqlServer -ContextDir Data -OutputDir Models -DataAnnotations
        place the context in a folder named 'Data' and the classes in a folder named 'Models' and use DataAnnotations on the classes instead of the Fluent API
     */
}