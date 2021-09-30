using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoriesDAL
    {
        public IEnumerable<Categories> GetCategories()
        {
            try
            {
                using (MiriFridiFinalProjectEntities entities=new MiriFridiFinalProjectEntities())
                {
                    return entities.Categories.ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
