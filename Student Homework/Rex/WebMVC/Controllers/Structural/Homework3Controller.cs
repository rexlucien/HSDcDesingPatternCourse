using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using hsdc.dpt.Control.DTO.Structual.Homework3;
using hsdc.dpt.Control.Structural.Homework3;
using WebMVC.ViewModels.Homework3;

namespace WebMVC.Controllers.Structural
{
    public class Homework3Controller : Controller
    {
        // GET: Homework3
        public ActionResult Index()
        {
            RestaurantInquireUco uco = new RestaurantInquireUco();

            List<RestaurantDto> dtos = uco.GetPresetList();

            List<RestaurantViewModel> vms = ConvertToViewModel(dtos);

            return View("Index", vms);
        }

        /// <summary>
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        private static List<RestaurantViewModel> ConvertToViewModel(IEnumerable<RestaurantDto> dtos)
        {
            return dtos.Select(x => new RestaurantViewModel
            {
                Name = x.Name,
                Descript = x.Descript,
                Price = x.Price
            }).ToList();
        }
    }
}