using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTO
{
   public class UserDTO:IDTOTables
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Tz { get; set; }
        public string PhoneNumber { get; set; }
        public string CityAdress { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Nullable<int> PointsNum { get; set; }
    }
}
