using AutoMapper;
using Business.Enties;
using Business.Interop.Data;
using Business.Repositories;
using Business.Repositories.DataRepositories;
using System.Collections.Generic;

namespace Business.Services
{
    public class StreetService : IStreetService
	{
		private readonly IStreetRepository _streetRepository;
		private readonly IMapper _mapper;

		public StreetService(IStreetRepository repository, IMapper mapper)
		{
			_streetRepository = repository;
			_mapper = mapper;
		}
		public StreetDto CreateStreet(StreetDto street)
		{
			var entity = _mapper.Map<Street>(street);
			_streetRepository.CreateOrUpdate(entity);
			return _mapper.Map<StreetDto>(entity);
		}

		public IEnumerable<StreetDto> GetStreets()
		{
			var entities = _streetRepository.Query();

			return _mapper.Map<IEnumerable<Street>, IEnumerable<StreetDto>>(entities);
		}

		public IEnumerable<StreetDto> GetAll()
		{
			var streets = _streetRepository.Query();

			return _mapper.Map<IEnumerable<Street>, IEnumerable<StreetDto>>(streets);
		}


		public StreetDto CreateOrUpdate(StreetDto street)
		{
			var entity = _mapper.Map<Street>(street);
			_streetRepository.CreateOrUpdate(entity);
			return _mapper.Map<StreetDto>(entity);
		}

		public void Delete(int id)
		{
			var entity = _streetRepository.Read(id);
			_streetRepository.Delete(entity);
		}

		public StreetDto GetById(int id)
		{
			var entity = _streetRepository.Read(id);
			return _mapper.Map<StreetDto>(entity);
		}
		public StreetDto Update(StreetDto street)
		{
			var entity = _mapper.Map<Street>(street);
			_streetRepository.Update(entity);
			return _mapper.Map<StreetDto>(entity);
		}
	}  
}
