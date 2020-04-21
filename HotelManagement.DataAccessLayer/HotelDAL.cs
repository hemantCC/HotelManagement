using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HotelManagement.EntityLayer.BusinessEntity;
using HotelManagement.EntityLayer.DataEntity;

namespace HotelManagement.DataAccessLayer
{
    public class HotelDAL
    {
        public int PostHotel(HotelVM HotelObject)
        {
            using (var context = new DbWebAPIEntities())
            {
                //Create Mapper configuration
                var config = new MapperConfiguration(cfg => {
                    cfg.CreateMap<HotelVM, tblHotel>();
                });

                //Map the objects
                var mapper = new Mapper(config);
                tblHotel record = mapper.Map<HotelVM, tblHotel>(HotelObject);
                context.tblHotels.Add(record);
                context.SaveChanges();

                return record.HotelId;
            }


        }
    }
}
