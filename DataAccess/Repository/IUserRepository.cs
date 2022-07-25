using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IUserRepository
    {
        public User GetUserById(int id);
        void InsertUser(User user);
        void UpdateUser(User user);
    }
}
