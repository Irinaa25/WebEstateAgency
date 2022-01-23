using Business.Interop.Data;

using System.Collections.Generic;

namespace Business.Services
{
	public interface IEstateService
	{
		public EstateDto CreateEstate(EstateDto estate);
		public IEnumerable<EstateDto> GetAll();
		public IEnumerable<EstateDto> FindByName(string name);
		public EstateDto CreateOrUpdate(EstateDto estate);
		public EstateDto Update(EstateDto estate);
		public EstateDto GetById(int id);
		public void Delete(int id);
	}
}
