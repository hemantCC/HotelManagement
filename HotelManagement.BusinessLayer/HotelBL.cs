using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.DataAccessLayer;
using HotelManagement.EntityLayer.BusinessEntity;

namespace HotelManagement.BusinessLayer
{
    public class HotelBL : IHotelBL
    {
        private HotelDAL HotelDAL = new HotelDAL();
        public int PostHotel(HotelVM HotelObject)
        {
           int id = HotelDAL.PostHotel(HotelObject);
           return id;
        }
      
    }
}
