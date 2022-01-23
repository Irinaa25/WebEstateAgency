using AutoMapper;

using Business.Enties;
using Business.Interop.Data;

namespace Business.Services
{
	public class ServiceMappingProfile : Profile
	{
		public ServiceMappingProfile()
		{
			// from entity to dto
			CreateMap<Estate, EstateDto>();
			CreateMap<Client, ClientDto>();
			CreateMap<Realtor, RealtorDto>();
			CreateMap<Deal, DealDto>();
			CreateMap<EstateType, EstateTypeDto>();
			CreateMap<Street, StreetDto>();
			CreateMap<Town, TownDto>();
			CreateMap<District, DistrictDto>();

			// from dto to entity
			CreateMap<EstateDto, Estate>();
			CreateMap<ClientDto, Client>();
			CreateMap<RealtorDto, Realtor>();
			CreateMap<DealDto, Deal>();
			CreateMap<EstateTypeDto, EstateType>();
			CreateMap<StreetDto, Street>();
			CreateMap<TownDto, Town>();
			CreateMap<DistrictDto, District>();
		}
	}
}
