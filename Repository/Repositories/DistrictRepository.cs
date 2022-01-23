using Business.Enties;
using Business.Repositories.DataRepositories;

using Microsoft.EntityFrameworkCore;
using Repository.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class DistrictRepository : AbstractRepository<District, int>, IDistrictRepository
	{
		public DistrictRepository(Context context)
		{
			_context = context;
		}

		#region implementation
		protected override int KeySelector(District entity) => entity.Id;

		protected override District ReadImplementation(int key)
		{
			return QueryImplementation().FirstOrDefault(i => i.Id == key);
		}

		protected override async Task<District> ReadImplementationAsync(int key)
		{
			return await QueryImplementation().FirstOrDefaultAsync(i => i.Id == key);
		}

		protected override void CreateImplementation(District value)
		{
			_context.Districts.Add(value);
		}

		protected override async Task CreateImplementationAsync(District value)
		{
			await _context.Districts.AddAsync(value);
		}

		protected override void UpdateImplementation(District entity, District value)
		{
			_context.ChangeTracker.Clear();
			_context.Update(value);
		}

		protected override void DeleteImplementation(District value)
		{
			var entity = ReadImplementation(value.Id);
			if (entity == null) return;
			_context.Districts.Remove(entity);
		}

		protected override IQueryable<District> QueryImplementation()
		{
			return _context.Districts
				.Include(districts => districts.Streets)
					.ThenInclude(streets => streets.Estates)
				.Include(districts => districts.Town);
		}
		#endregion
	}
}
