using AutoMapper;
using Business.Enties;
using Business.Interop.Data;
using Business.Repositories;
using Business.Repositories.DataRepositories;
using System.Collections.Generic;

namespace Business.Services
{
    public class EstateTypeService : IEstateTypeService
	{
		private readonly IEstateTypeRepository _estateTypeRepository;
		private readonly IMapper _mapper;

		public EstateTypeService(IEstateTypeRepository repository, IMapper mapper)
		{
			_estateTypeRepository = repository;
			_mapper = mapper;
		}
		public EstateTypeDto CreateEstateType(EstateTypeDto estateType)
		{
			 var entity = _mapper.Map<EstateType>(estateType);
			_estateTypeRepository.CreateOrUpdate(entity);
			return _mapper.Map<EstateTypeDto>(entity);
		}

		public IEnumerable<EstateTypeDto> GetEstateTypes()
		{
			var entities = _estateTypeRepository.Query();

			return _mapper.Map<IEnumerable<EstateType>, IEnumerable<EstateTypeDto>>(entities);
		}

		public IEnumerable<EstateTypeDto> GetAll()
		{
			var estateTypes = _estateTypeRepository.Query();

			return _mapper.Map<IEnumerable<EstateType>, IEnumerable<EstateTypeDto>>(estateTypes);
		}


		public EstateTypeDto CreateOrUpdate(EstateTypeDto estateType)
		{
			var entity = _mapper.Map<EstateType>(estateType);
			_estateTypeRepository.CreateOrUpdate(entity);
			return _mapper.Map<EstateTypeDto>(entity);
		}

		public void Delete(int id)
		{
			var entity = _estateTypeRepository.Read(id);
			_estateTypeRepository.Delete(entity);
		}

		public EstateTypeDto GetById(int id)
		{
			var entity = _estateTypeRepository.Read(id);
			return _mapper.Map<EstateTypeDto>(entity);
		}
		public EstateTypeDto Update(EstateTypeDto estateType)
		{
			var entity = _mapper.Map<EstateType>(estateType);
			_estateTypeRepository.Update(entity);
			return _mapper.Map<EstateTypeDto>(entity);
		}
	}
}
