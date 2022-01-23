using Business.Enties;
using Business.Repositories.DataRepositories;

using Microsoft.EntityFrameworkCore;
using Repository.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.Repositories
{
	public class EstateRepository : AbstractRepository<Estate, int>, IEstateRepository
	{
		public EstateRepository(Context context)
		{
			_context = context;
		}

		#region implementation
		protected override int KeySelector(Estate entity) => entity.Id;

		protected override Estate ReadImplementation(int key)
		{
			return QueryImplementation().FirstOrDefault(i => i.Id == key);
		}

		protected override async Task<Estate> ReadImplementationAsync(int key)
		{
			return await QueryImplementation().FirstOrDefaultAsync(i => i.Id == key);
		}

		protected override void CreateImplementation(Estate value)
		{
			_context.Estates.Add(value);
		}

		protected override async Task CreateImplementationAsync(Estate value)
		{
			await _context.Estates.AddAsync(value);
		}

		protected override void UpdateImplementation(Estate entity, Estate value)
		{
			_context.ChangeTracker.Clear();
			_context.Update(value);
		}

		protected override void DeleteImplementation(Estate value)
		{
			var entity = ReadImplementation(value.Id);
			if (entity == null) return;
			_context.Estates.Remove(entity);
		}

		protected override IQueryable<Estate> QueryImplementation()
		{
			return _context.Estates
				.Include(estate => estate.EstateType)
				.Include(estate => estate.Client)
				.Include(estate => estate.Deals)
				.Include(estate => estate.Street);
		}
		#endregion

	}
}
