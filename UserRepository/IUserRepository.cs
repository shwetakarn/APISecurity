using System.Collections.Generic;
using APISecurity.Models;

namespace APISecurity.UserRepository
{
    public interface IUserRepository
    {
         void Add(User user);
         void Remove(int id);
         void Update(User user);
         IEnumerable<User> GetAll();

         bool CheckValidUserKey(int id);
    }
}