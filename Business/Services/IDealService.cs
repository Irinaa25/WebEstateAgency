using Business.Interop.Data;

using System.Collections.Generic;

namespace Business.Services
{
	public interface IDealService
	{
		IEnumerable<DealDto> GetDeals();
		DealDto CreateDeal(DealDto deal);
		public IEnumerable<DealDto> GetAll();
		public DealDto CreateOrUpdate(DealDto deal);
		public DealDto Update(DealDto deal);
		public DealDto GetById(int id);
		public void Delete(int id);
	}
}
