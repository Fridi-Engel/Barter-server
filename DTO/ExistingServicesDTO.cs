using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ExistingServicesDTO : IDTOTables
    {
        public int ServiceId { get; set; }
        public Nullable<int> IdOfferUser { get; set; }
        public string Description { get; set; }
        public Nullable<int> CostInPoint { get; set; }
        public Nullable<int> IdCategory { get; set; }
    }
}
