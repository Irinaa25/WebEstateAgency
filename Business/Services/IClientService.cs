using Business.Interop.Data;

using System.Collections.Generic;

namespace Business.Services
{
	public interface IClientService
	{
		IEnumerable<ClientDto> GetClients();
		ClientDto CreateClient(ClientDto client);
		public IEnumerable<ClientDto> GetAll();
		public ClientDto CreateOrUpdate(ClientDto client);
		public ClientDto Update(ClientDto client);
		public ClientDto GetById(int id);
		public void Delete(int id);
	}
}
