using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagementAPI.Model;

namespace UserManagementAPI.UserData
{
    public interface IUserData
    {
        public List<Model.Users> GetUser();
        public Users AddUser(Users users);
       
        public List<Model.Users> GetRandomUser();
        

    }
}
