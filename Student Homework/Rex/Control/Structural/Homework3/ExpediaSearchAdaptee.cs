using System.Collections.Generic;
using System.Linq;
using hsdc.dpt.Control.DTO.Structual.Homework3;
using hsdc.dpt.Control.DTO.Structual.Homework3.Expedia;
using Newtonsoft.Json;

namespace hsdc.dpt.Control.Structural.Homework3
{
    public class ExpediaSearchAdaptee : IExternalSearchAdapter
    {
        public List<RestaurantDto> Get()
        {
            string json = ExpediaSite.Instance.Responsed;

            var query = JsonConvert.DeserializeObject<ExpediaRootDto>(json);

            List<RestaurantDto> result = query.results.Select(x => new RestaurantDto
            {
                Name = x.retailHotelInfoModel.localizedHotelName,
                Descript = x.retailHotelInfoModel.hotelDescription,
                Price = (int)x.retailHotelPricingModel.price  ,
                ThumbnailUrl = x.retailHotelInfoModel.largeThumbnailURL
            }).ToList();

            return result;
        }
    }
}