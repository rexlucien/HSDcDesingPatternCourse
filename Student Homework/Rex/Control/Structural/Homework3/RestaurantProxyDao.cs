using hsdc.dpt.Control.DTO.Structual.Homework3;
using System.Collections.Generic;

namespace hsdc.dpt.Control.Structural.Homework3
{
    internal class RestaurantProxyDao : IRestaurantDao
    {
        private readonly bool _verification;
        private readonly RestaurantDao _restaurantDao;

        public RestaurantProxyDao(bool verification)
        {
            _verification = verification;
            _restaurantDao = new RestaurantDao();
        }

        public List<RestaurantDto> GetList()
        {
            List<RestaurantDto> dtos = _restaurantDao.GetList();

            if (_verification == false) return dtos;

            ExpediaSearchAdaptee adaptee = new ExpediaSearchAdaptee();

            List<RestaurantDto> result = adaptee.Get();

            result.AddRange(dtos);

            return result;
        }
    }
}