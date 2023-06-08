using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Magpul.Persistence.DbContexts;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Web_app.ClientApp.Services
{
    public class UserService
    {
        private readonly _magpulDbContext;
        private readonly _configuration;
        private readonly _mapper;


        public UsersService(MagpulDbContext magpulDbContext, IConfiguration configuration, IMapper mapper)
        {
            _magpulDbContext = magpulDbContext;
            _cofiguration = configuration;
            _mapper = mapper;

        }

        public IEnumerable<User> GetAll()
        {
            var users = _magpulDb
        }



    }
}
