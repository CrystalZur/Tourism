using Microsoft.AspNetCore.Mvc;
using Tourism_2._0.Domain;
using Tourism_2._0.Domain.Entities;
using Tourism_2._0.Infractructure;
using Tourism_2._0.Models;

namespace Tourism_2._0.Controllers
{
    public class ServicesController : Controller
    {
        private readonly DataManager _dataManager;

        public ServicesController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Service> list = await _dataManager.Services.GetServicesAsync();

            IEnumerable<ServiceDTO> listDTO = HelperDTO.TransformServices(list);

            return View(listDTO);
        }

        public async Task<IActionResult> Show(int id)
        {
            Service? entity = await _dataManager.Services.GetServiceByIdAsync(id);

            if (entity == null) 
                return NotFound();

            ServiceDTO entityDTO = HelperDTO.TransformService(entity);

            return View(entityDTO);
        }
    }
}
