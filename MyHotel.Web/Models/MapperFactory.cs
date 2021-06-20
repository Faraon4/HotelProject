namespace MyHotel.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using AutoMapper;

    /// <summary>
    /// Class for the Mapping.
    /// </summary>
    public class MapperFactory
    {
        /// <summary>
        /// Method to create mapper for instances.
        /// </summary>
        /// <returns>Imapper.</returns>
        public static IMapper CreateMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<MyHotel.Models.Rooms, MyHotel.Web.Models.Rooms>()
                .ForMember(dest => dest.Id, map => map.MapFrom(src => src.Id))
                .ForMember(dest => dest.RoomsType, map => map.MapFrom(src => src.RoomsType))
                .ForMember(dest => dest.RoomsAmount, map => map.MapFrom(src => src.RoomsAmount))
                .ForMember(dest => dest.RoomsAvailable, map => map.MapFrom(src => src.RoomsAvailable))
                .ForMember(dest => dest.RoomsPrice, map => map.MapFrom(src => src.RoomsPrice))
                .ForMember(dest => dest.RoomsView, map => map.MapFrom(src => src.RoomsView))
                .ForMember(dest => dest.Selection, map => map.MapFrom(src => src.Selection));
            });
            return config.CreateMapper();
        }
    }
}
