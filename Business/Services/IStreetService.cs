using Business.Interop.Data;

using System.Collections.Generic;

namespace Business.Services
{
	public interface IStreetService
	{
		IEnumerable<StreetDto> GetStreets();
		StreetDto CreateStreet(StreetDto street);
		public IEnumerable<StreetDto> GetAll();
		public StreetDto CreateOrUpdate(StreetDto street);
		public StreetDto Update(StreetDto street);
		public StreetDto GetById(int id);
		public void Delete(int id);
	}
}
