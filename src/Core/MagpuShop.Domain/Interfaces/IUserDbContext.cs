using MagpulShop.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagpulShop.Domain.Interfaces
{
    public interface IUserDbContext
    {
        IEnumerable<User> GetBaskets();
        User GetUserById(int id);
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);
        Task<int> SaveChangesAsync();
    }
}
