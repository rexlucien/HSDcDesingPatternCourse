using System.Collections.Generic;
using hsdc.dpt.Control.DTO.Structual.Homework3;
using hsdc.dpt.Control.DTO.Structual.Homework3.Expedia;
using Newtonsoft.Json;

namespace hsdc.dpt.Control.Structural.Homework3
{
    public class EztravelSearchAdaptee : IExternalSearchAdapter
    {
        public List<RestaurantDto> Get()
        {
            string json = ExpediaSite.Instance.Responsed;

            //var query = JsonConvert.DeserializeObject<ExpediaRootDto>(json);

            //var result = JsonConvert.DeserializeObject<EztravelRootDto>(json);

            return new List<RestaurantDto>();
        }
    }
}