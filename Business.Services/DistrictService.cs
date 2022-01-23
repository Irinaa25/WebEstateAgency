using AutoMapper;
using Business.Enties;
using Business.Interop.Data;
using Business.Repositories;
using Business.Repositories.DataRepositories;
using System.Collections.Generic;

namespace Business.Services
{
    public class DistrictService : IDistrictService
	{
		private readonly IDistrictRepository _districtRepository;
		private readonly IMapper _mapper;

		public DistrictService(IDistrictRepository repository, IMapper mapper)
		{
			_districtRepository = repository;
			_mapper = mapper;
		}
		public DistrictDto CreateDistrict(DistrictDto district)
		{
			var entity = _mapper.Map<District>(district);
			_districtRepository.CreateOrUpdate(entity);
			return _mapper.Map<DistrictDto>(entity);
		}

		public IEnumerable<DistrictDto> GetDistricts()
		{
			var entities = _districtRepository.Query();

			return _mapper.Map<IEnumerable<District>, IEnumerable<DistrictDto>>(entities);
		}
		public IEnumerable<DistrictDto> GetAll()
		{
			var districts = _districtRepository.Query();

			return _mapper.Map<IEnumerable<District>, IEnumerable<DistrictDto>>(districts);
		}


		public DistrictDto CreateOrUpdate(DistrictDto district)
		{
			var entity = _mapper.Map<District>(district);
			_districtRepository.CreateOrUpdate(entity);
			return _mapper.Map<DistrictDto>(entity);
		}

		public void Delete(int id)
		{
			var entity = _districtRepository.Read(id);
			_districtRepository.Delete(entity);
		}

		public DistrictDto GetById(int id)
		{
			var entity = _districtRepository.Read(id);
			return _mapper.Map<DistrictDto>(entity);
		}
		public DistrictDto Update(DistrictDto district)
		{
			var entity = _mapper.Map<District>(district);
			_districtRepository.Update(entity);
			return _mapper.Map<DistrictDto>(entity);
		}
	}
}
