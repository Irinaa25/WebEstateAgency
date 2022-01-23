using AutoMapper;
using Business.Enties;
using Business.Interop.Data;
using Business.Repositories;
using Business.Repositories.DataRepositories;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
	public class ClientService : IClientService
	{
		private readonly IClientRepository _clientRepository;
		private readonly IMapper _mapper;

		public ClientService(IClientRepository repository, IMapper mapper)
		{
			_clientRepository = repository;
			_mapper = mapper;
		}
		public ClientDto CreateClient(ClientDto client)
		{
			var entity = _mapper.Map<Client>(client);
			_clientRepository.CreateOrUpdate(entity);
			return _mapper.Map<ClientDto>(entity);
		}

		public IEnumerable<ClientDto> GetClients()
		{
			var entities = _clientRepository.Query();

			return _mapper.Map<IEnumerable<Client>, IEnumerable<ClientDto>>(entities);
		}

		public IEnumerable<ClientDto> GetAll()
		{
			var clients = _clientRepository.Query();

			return _mapper.Map<IEnumerable<Client>, IEnumerable<ClientDto>>(clients);
		}


		public ClientDto CreateOrUpdate(ClientDto client)
		{
			var entity = _mapper.Map<Client>(client);
			_clientRepository.CreateOrUpdate(entity);
			return _mapper.Map<ClientDto>(entity);
		}

		public void Delete(int id)
		{
			var entity = _clientRepository.Read(id);
			_clientRepository.Delete(entity);
		}

		public ClientDto GetById(int id)
		{
			var entity = _clientRepository.Read(id);
			return _mapper.Map<ClientDto>(entity);
		}
		public ClientDto Update(ClientDto client)
		{
			var entity = _mapper.Map<Client>(client);
			_clientRepository.Update(entity);
			return _mapper.Map<ClientDto>(entity);
		}
	}
}

