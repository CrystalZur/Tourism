using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tourism_2._0.Domain.Entities;
using Tourism_2._0.Models;

namespace Tourism_2._0.Infractructure
{
    public static class HelperDTO
    {
        public static ServiceDTO TransformService(Service entity)
        {
            ServiceDTO entityDTO = new ServiceDTO();
            entityDTO.Id = entity.Id;
            entityDTO.CategoryName = entity.ServiceCategory?.Title;
            entityDTO.Title = entity.Title;
            entityDTO.ShortDesc = entity.ShortDesc;
            entityDTO.Desc = entity.Desc;
            entityDTO.PhotoFileName = entity.Photo;
            entityDTO.Type = entity.Type.ToString();

            return entityDTO;
        }

        public static IEnumerable<ServiceDTO> TransformServices(IEnumerable<Service> services)
        {
            List<ServiceDTO> entitiesDTO = new List<ServiceDTO>();

            foreach (Service entity in services)
                entitiesDTO.Add(TransformService(entity));
            return entitiesDTO;
        }
    }
}
