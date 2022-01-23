using Business.Interop.Data;

using System.Collections.Generic;

namespace Business.Services
{
	public interface ITownService
	{
		IEnumerable<TownDto> GetTowns();
		TownDto CreateTown(TownDto town);
		public IEnumerable<TownDto> GetAll();
		public TownDto CreateOrUpdate(TownDto town);
		public TownDto Update(TownDto town);
		public TownDto GetById(int id);
		public void Delete(int id);
	}
}

