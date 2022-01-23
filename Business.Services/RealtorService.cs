using AutoMapper;

using Business.Enties;
using Business.Repositories;
using Business.Repositories.DataRepositories;
using Business.Interop.Data;

using System.Collections.Generic;

namespace Business.Services
{
	public class RealtorService : IRealtorService
	{
		private readonly IRealtorRepository _realtorRepository;
		private readonly IMapper _mapper;

		public RealtorService(IRealtorRepository repository, IMapper mapper)
		{
			_realtorRepository = repository;
			_mapper = mapper;
		}

		public RealtorDto CreateRealtor(RealtorDto realtor)
		{
			var entity = _mapper.Map<Realtor>(realtor);
			_realtorRepository.CreateOrUpdate(entity);
			return _mapper.Map<RealtorDto>(entity);
		}

		public IEnumerable<RealtorDto> GetRealtors()
		{
			var entities = _realtorRepository.Query();

			return _mapper.Map<IEnumerable<Realtor>, IEnumerable<RealtorDto>>(entities);
		}

		public IEnumerable<RealtorDto> GetAll()
		{
			var realtors = _realtorRepository.Query();

			return _mapper.Map<IEnumerable<Realtor>, IEnumerable<RealtorDto>>(realtors);
		}


		public RealtorDto CreateOrUpdate(RealtorDto realtor)
		{
			var entity = _mapper.Map<Realtor>(realtor);
			_realtorRepository.CreateOrUpdate(entity);
			return _mapper.Map<RealtorDto>(entity);
		}

		public void Delete(int id)
		{
			var entity = _realtorRepository.Read(id);
			_realtorRepository.Delete(entity);
		}

		public RealtorDto GetById(int id)
		{
			var entity = _realtorRepository.Read(id);
			return _mapper.Map<RealtorDto>(entity);
		}
		public RealtorDto Update(RealtorDto realtor)
		{
			var entity = _mapper.Map<Realtor>(realtor);
			_realtorRepository.Update(entity);
			return _mapper.Map<RealtorDto>(entity);
		}
	}
}
