using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CategoriesDTO:IDTOTables
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public Nullable<int> AvgScore { get; set; }
    }
}
