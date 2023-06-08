using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magpul.Persistence.DbContexts;

namespace Web_app.Pages
{
    public class StartUp
    {

        public void ConfigurationServices(IServiceCollection services)
        {
            services.AddDbContext<MagpulDbContext>(opt)
        }
    }
}
