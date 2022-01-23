using Business.Enties;
using Business.Repositories.DataRepositories;

using Microsoft.EntityFrameworkCore;
using Repository.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class TownRepository : AbstractRepository<Town, int>, ITownRepository
	{
		public TownRepository(Context context)
		{
			_context = context;
		}

		#region implementation
		protected override int KeySelector(Town entity) => entity.Id;

		protected override Town ReadImplementation(int key)
		{
			return QueryImplementation().FirstOrDefault(i => i.Id == key);
		}

		protected override async Task<Town> ReadImplementationAsync(int key)
		{
			return await QueryImplementation().FirstOrDefaultAsync(i => i.Id == key);
		}

		protected override void CreateImplementation(Town value)
		{
			_context.Towns.Add(value);
		}

		protected override async Task CreateImplementationAsync(Town value)
		{
			await _context.Towns.AddAsync(value);
		}

		protected override void UpdateImplementation(Town entity, Town value)
		{
			_context.ChangeTracker.Clear();
			_context.Update(value);
		}

		protected override void DeleteImplementation(Town value)
		{
			var entity = ReadImplementation(value.Id);
			if (entity == null) return;
			_context.Towns.Remove(entity);
		}

		protected override IQueryable<Town> QueryImplementation()
		{
			return _context.Towns
				.Include(town => town.Districts)
					.ThenInclude(districts => districts.Streets)
				.Include(town => town.Districts)
					.ThenInclude(districts => districts.Town);
		}
		#endregion
	}
}
