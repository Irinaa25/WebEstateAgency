using Business.Enties;
using Business.Repositories.DataRepositories;

using Microsoft.EntityFrameworkCore;
using Repository.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class DealRepository : AbstractRepository<Deal, int>, IDealRepository
	{
		public DealRepository(Context context)
		{
			_context = context;
		}

		#region implementation
		protected override int KeySelector(Deal entity) => entity.Id;

		protected override Deal ReadImplementation(int key)
		{
			return QueryImplementation().FirstOrDefault(i => i.Id == key);
		}

		protected override async Task<Deal> ReadImplementationAsync(int key)
		{
			return await QueryImplementation().FirstOrDefaultAsync(i => i.Id == key);
		}

		protected override void CreateImplementation(Deal value)
		{
			_context.Deals.Add(value);
		}

		protected override async Task CreateImplementationAsync(Deal value)
		{
			await _context.Deals.AddAsync(value);
		}

		protected override void UpdateImplementation(Deal entity, Deal value)
		{
			_context.ChangeTracker.Clear();
			_context.Update(value);
		}

		protected override void DeleteImplementation(Deal value)
		{
			var entity = ReadImplementation(value.Id);
			if (entity == null) return;
			_context.Deals.Remove(entity);
		}

		protected override IQueryable<Deal> QueryImplementation()
		{
			return _context.Deals
				.Include(deal => deal.Estate)
					.ThenInclude(estate => estate.EstateType)
				.Include(deal => deal.Client)
				.Include(deal => deal.Realtor);
		}
		#endregion
	}
}
