using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ExistingServicesDAL
    {
        public void AddService(ExistingServices service)
        {
            try
            {
                using (MiriFridiFinalProjectEntities entities=new MiriFridiFinalProjectEntities())
                {
                    entities.ExistingServices.Add(service);
                    entities.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
