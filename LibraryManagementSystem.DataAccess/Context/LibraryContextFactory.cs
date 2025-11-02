using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace LibraryManagementSystem.DataAccess.Context
{
    public class LibraryContextFactory : IDesignTimeDbContextFactory<LibraryContext>
    {
        public LibraryContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<LibraryContext>();
            optionsBuilder.UseSqlServer("Server=LAPTOP-CRTGF64J\\SQLEXPRESS;Database=LibraryDB;Trusted_Connection=True;TrustServerCertificate=True;");

            return new LibraryContext(optionsBuilder.Options);
        }
    }
}
