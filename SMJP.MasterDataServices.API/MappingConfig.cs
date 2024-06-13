using AutoMapper;
using SMJP.MasterDataServices.API.Models;
using SMJP.MasterDataServices.API.Models.Dto;

namespace SMJP.MasterDataServices.API
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<UsersDto, Users>();
                config.CreateMap<Users, UsersDto>();

                config.CreateMap<CompaniesDto, Companies>();
                config.CreateMap<Companies, CompaniesDto>();

                config.CreateMap<RegionsDto, Regions>();
                config.CreateMap<Regions, RegionsDto>();

                config.CreateMap<SitesDto, Sites>();
                config.CreateMap<Sites, SitesDto>();

                config.CreateMap<SchedulesDto, Schedules>();
                config.CreateMap<Schedules, SchedulesDto>();

                config.CreateMap<ShiftsDto, Shifts>();
                config.CreateMap<Shifts, ShiftsDto>();
            });
            return mappingConfig;
        }
    }
}
