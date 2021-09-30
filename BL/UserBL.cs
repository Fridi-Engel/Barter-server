using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BL
{
    public class UserBL
    {
        public  IEnumerable<UserDTO> GetAllUsers()
        {
            var UserList =new UserDAL().GetAllUsers();
            foreach (var item in UserList)
            {
                yield return Converters.Converter.ConvertToDTO<Users,UserDTO>(item);
            }
        }

        public UserDTO GetUser(string userEmail, string password)
        {
            Users user = new UserDAL().GetUser(userEmail, password);
            if (user == null)
                return null;
            return Converters.Converter.ConvertToDTO<Users, UserDTO>(user);
        }
    }
}
