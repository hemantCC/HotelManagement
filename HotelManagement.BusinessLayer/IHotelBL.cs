using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.EntityLayer.BusinessEntity;

namespace HotelManagement.BusinessLayer
{
    public interface IHotelBL
    {
        int PostHotel(HotelVM HotelObject);

    }
}
