using Business.Interop.Data;

using System.Collections.Generic;

namespace Business.Services
{
	public interface IEstateTypeService
	{
		IEnumerable<EstateTypeDto> GetEstateTypes();
		EstateTypeDto CreateEstateType(EstateTypeDto estateType);
		public IEnumerable<EstateTypeDto> GetAll();
		public EstateTypeDto CreateOrUpdate(EstateTypeDto estateType);
		public EstateTypeDto Update(EstateTypeDto estateType);
		public EstateTypeDto GetById(int id);
		public void Delete(int id);
	}
}
