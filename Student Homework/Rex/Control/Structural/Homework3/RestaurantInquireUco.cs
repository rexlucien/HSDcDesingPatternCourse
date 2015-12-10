using System.Collections.Generic;
using hsdc.dpt.Control.DTO.Structual.Homework3;

namespace hsdc.dpt.Control.Structural.Homework3
{
    public class RestaurantInquireUco
    {
        private readonly RestaurantDao _dao;

        public RestaurantInquireUco()
        {
            _dao = new RestaurantDao();
        }

        public List<RestaurantDto> GetPresetList()
        {
            return _dao.GetList();
        }
    }
}