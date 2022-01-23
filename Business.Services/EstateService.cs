using AutoMapper;

using Business.Enties;
using Business.Repositories;
using Business.Repositories.DataRepositories;
using Business.Interop.Data;
using System.Collections.Generic;
using System.Linq;

namespace Business.Services
{
	public class EstateService : IEstateService
	{
		private readonly IEstateRepository _estateRepository;
		private readonly IMapper _mapper;

		public EstateService(IEstateRepository repository, IMapper mapper)
		{
			_estateRepository = repository;
			_mapper = mapper;
		}

		public EstateDto CreateEstate(EstateDto estate)
		{
			var entity = _mapper.Map<Estate>(estate);
			_estateRepository.CreateOrUpdate(entity);
			return _mapper.Map<EstateDto>(entity);
		}

		public IEnumerable<EstateDto> GetAll()
		{

			var estates = _estateRepository.Query();
			return _mapper.Map<IEnumerable<Estate>, IEnumerable<EstateDto>>(estates);
		}
		
		public IEnumerable<EstateDto> FindByName(string name)
		{
			var estates = _estateRepository.Query()
				.Where(i => i.Name.Contains(name, System.StringComparison.InvariantCultureIgnoreCase));

			return _mapper.Map<IEnumerable<Estate>, IEnumerable<EstateDto>>(estates);
		}

		public EstateDto CreateOrUpdate(EstateDto estate)
		{
			var entity = _mapper.Map<Estate>(estate);
			_estateRepository.CreateOrUpdate(entity);
			return _mapper.Map<EstateDto>(entity);
		}

		public void Delete(int id)
		{
			var entity = _estateRepository.Read(id);
			_estateRepository.Delete(entity);
		}

		public EstateDto GetById(int id)
		{
			var entity = _estateRepository.Read(id);
			return _mapper.Map<EstateDto>(entity);
		}
		public EstateDto Update(EstateDto estate)
		{
			var entity = _mapper.Map<Estate>(estate);
			_estateRepository.Update(entity);
			return _mapper.Map<EstateDto>(entity);
		}
	}
}
