using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserDAL
    {
        public  List<Users> GetAllUsers()
        {
            try
            {
                using(MiriFridiFinalProjectEntities entities=new MiriFridiFinalProjectEntities())
                {
                    return entities.Users.ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Users GetUser(string userEmail, string password)
        {
            try
            {
                using (MiriFridiFinalProjectEntities entities = new MiriFridiFinalProjectEntities())
                {
                    Users user = entities.Users.FirstOrDefault(x => x.Email == userEmail && x.Password == password);
                    return user;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
