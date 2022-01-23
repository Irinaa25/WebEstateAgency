using Business.Interop.Data;

using System.Collections.Generic;

namespace Business.Services
{
	public interface IDistrictService
	{
		IEnumerable<DistrictDto> GetDistricts();
		DistrictDto CreateDistrict(DistrictDto district);
		public IEnumerable<DistrictDto> GetAll();
		public DistrictDto CreateOrUpdate(DistrictDto district);
		public DistrictDto Update(DistrictDto district);
		public DistrictDto GetById(int id);
		public void Delete(int id);
	}
}
