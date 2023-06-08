using Magpul.Persistence.DbContexts;
using MagpulShop.Domain.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace Magpul.Persistence
{
    public class General
    {
        public General() {}

        public static void  StartUp()
        {
            var builder = new ConfigurationBuilder();

            builder.SetBasePath(Directory.GetCurrentDirectory());

            builder.AddJsonFile("appsettings.json");

            var config = builder.Build();

            var connectionSting = config.GetConnectionString("Database");

            var optionsBuilder = new DbContextOptionsBuilder<MagpulDbContext>();

            var options = optionsBuilder.UseSqlite(connectionSting).Options;

            using (var db = new MagpulDbContext(options))
            {

            }

        }

    }
}
