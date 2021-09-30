using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BL
{
    public class ExistingServicesBL
    {
        public void AddService(ExistingServicesDTO serviceDTO)
        {
            ExistingServices service = Converters.Converter.ConvertToEntity<ExistingServicesDTO, ExistingServices>(serviceDTO);
            new ExistingServicesDAL().AddService(service);
        }
    }
}
