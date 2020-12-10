using System.Collections.Generic;
using APISecurity.Models;

namespace APISecurity.UserRepository
{
    public class Repository : IUserRepository
    {

        static List<User> userlist = new List<User>();
        public void Add(User user)
        {
            userlist.Add(user);
        }

        public bool CheckValidUserKey(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            return userlist;
        }

        public void Remove(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(User user)
        {
            throw new System.NotImplementedException();
        }
    }
}