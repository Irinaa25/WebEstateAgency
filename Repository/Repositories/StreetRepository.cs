using Business.Enties;
using Business.Repositories.DataRepositories;

using Microsoft.EntityFrameworkCore;
using Repository.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class StreetRepository : AbstractRepository<Street, int>, IStreetRepository
	{
		public StreetRepository(Context context)
		{
			_context = context;
		}

		#region implementation
		protected override int KeySelector(Street entity) => entity.Id;

		protected override Street ReadImplementation(int key)
		{
			return QueryImplementation().FirstOrDefault(i => i.Id == key);
		}

		protected override async Task<Street> ReadImplementationAsync(int key)
		{
			return await QueryImplementation().FirstOrDefaultAsync(i => i.Id == key);
		}

		protected override void CreateImplementation(Street value)
		{
			_context.Streets.Add(value);
		}

		protected override async Task CreateImplementationAsync(Street value)
		{
			await _context.Streets.AddAsync(value);
		}

		protected override void UpdateImplementation(Street entity, Street value)
		{
			_context.ChangeTracker.Clear();
			_context.Update(value);
		}

		protected override void DeleteImplementation(Street value)
		{
			var entity = ReadImplementation(value.Id);
			if (entity == null) return;
			_context.Streets.Remove(entity);
		}

		protected override IQueryable<Street> QueryImplementation()
		{
			return _context.Streets
				.Include(street => street.Estates)
				.Include(street => street.District);
		}
		#endregion
	}
}
