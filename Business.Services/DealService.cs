using AutoMapper;
using Business.Enties;
using Business.Interop.Data;
using Business.Repositories;
using Business.Repositories.DataRepositories;
using System.Collections.Generic;

namespace Business.Services
{
    public class DealService : IDealService
	{
		private readonly IDealRepository _dealRepository;
		private readonly IMapper _mapper;

		public DealService(IDealRepository repository, IMapper mapper)
		{
			_dealRepository = repository;
			_mapper = mapper;
		}
		public DealDto CreateDeal(DealDto deal)
		{
			var entity = _mapper.Map<Deal>(deal);
			_dealRepository.CreateOrUpdate(entity);
			return _mapper.Map<DealDto>(entity);
		}

		public IEnumerable<DealDto> GetDeals()
		{
			var entities = _dealRepository.Query();

			return _mapper.Map<IEnumerable<Deal>, IEnumerable<DealDto>>(entities);
		}

		public IEnumerable<DealDto> GetAll()
		{
			var deals = _dealRepository.Query();

			return _mapper.Map<IEnumerable<Deal>, IEnumerable<DealDto>>(deals);
		}


		public DealDto CreateOrUpdate(DealDto deal)
		{
			var entity = _mapper.Map<Deal>(deal);
			_dealRepository.CreateOrUpdate(entity);
			return _mapper.Map<DealDto>(entity);
		}

		public void Delete(int id)
		{
			var entity = _dealRepository.Read(id);
			_dealRepository.Delete(entity);
		}

		public DealDto GetById(int id)
		{
			var entity = _dealRepository.Read(id);
			return _mapper.Map<DealDto>(entity);
		}
		public DealDto Update(DealDto deal)
		{
			var entity = _mapper.Map<Deal>(deal);
			_dealRepository.Update(entity);
			return _mapper.Map<DealDto>(entity);
		}
	}
}

