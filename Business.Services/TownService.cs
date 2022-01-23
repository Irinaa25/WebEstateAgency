using AutoMapper;
using Business.Enties;
using Business.Interop.Data;
using Business.Repositories;
using Business.Repositories.DataRepositories;
using System.Collections.Generic;

namespace Business.Services
{
    public class TownService : ITownService
	{
		private readonly ITownRepository _townRepository;
		private readonly IMapper _mapper;

		public TownService(ITownRepository repository, IMapper mapper)
		{
			_townRepository = repository;
			_mapper = mapper;
		}
		public TownDto CreateTown(TownDto town)
		{
			var entity = _mapper.Map<Town>(town);
			_townRepository.CreateOrUpdate(entity);
			return _mapper.Map<TownDto>(entity);
		}

		public IEnumerable<TownDto> GetTowns()
		{
			var entities = _townRepository.Query();

			return _mapper.Map<IEnumerable<Town>, IEnumerable<TownDto>>(entities);
		}

		public IEnumerable<TownDto> GetAll()
		{
			var towns = _townRepository.Query();

			return _mapper.Map<IEnumerable<Town>, IEnumerable<TownDto>>(towns);
		}


		public TownDto CreateOrUpdate(TownDto town)
		{
			var entity = _mapper.Map<Town>(town);
			_townRepository.CreateOrUpdate(entity);
			return _mapper.Map<TownDto>(entity);
		}

		public void Delete(int id)
		{
			var entity = _townRepository.Read(id);
			_townRepository.Delete(entity);
		}

		public TownDto GetById(int id)
		{
			var entity = _townRepository.Read(id);
			return _mapper.Map<TownDto>(entity);
		}
		public TownDto Update(TownDto town)
		{
			var entity = _mapper.Map<Town>(town);
			_townRepository.Update(entity);
			return _mapper.Map<TownDto>(entity);
		}
	}
}
