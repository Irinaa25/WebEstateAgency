using Business.Interop.Data;

using System.Collections.Generic;

namespace Business.Services
{
	public interface IRealtorService
	{
		IEnumerable<RealtorDto> GetRealtors();
		public RealtorDto CreateRealtor(RealtorDto realtor);
		public IEnumerable<RealtorDto> GetAll();
		public RealtorDto CreateOrUpdate(RealtorDto realtor);
		public RealtorDto Update(RealtorDto realtor);
		public RealtorDto GetById(int id);
		public void Delete(int id);
	}
}
