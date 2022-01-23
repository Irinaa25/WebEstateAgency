using Business.Enties;
using Business.Repositories.DataRepositories;

using Microsoft.EntityFrameworkCore;
using Repository.Data;
using System.Linq;
using System.Threading.Tasks;


namespace Repository.Repositories
{
	public class RealtorRepository : AbstractRepository<Realtor, int>, IRealtorRepository
	{
		public RealtorRepository(Context context)
		{
			_context = context;
		}

		#region implementation
		protected override int KeySelector(Realtor entity) => entity.Id;

		protected override Realtor ReadImplementation(int key)
		{
			return QueryImplementation().FirstOrDefault(i => i.Id == key);
		}

		protected override async Task<Realtor> ReadImplementationAsync(int key)
		{
			return await QueryImplementation().FirstOrDefaultAsync(i => i.Id == key);
		}

		protected override void CreateImplementation(Realtor value)
		{
			_context.Realtors.Add(value);
		}

		protected override async Task CreateImplementationAsync(Realtor value)
		{
			await _context.Realtors.AddAsync(value);
		}

		protected override void UpdateImplementation(Realtor entity, Realtor value)
		{
			_context.ChangeTracker.Clear();
			_context.Update(value);
		}

		protected override void DeleteImplementation(Realtor value)
		{
			var entity = ReadImplementation(value.Id);
			if (entity == null) return;
			_context.Realtors.Remove(entity);
		}

		protected override IQueryable<Realtor> QueryImplementation()
		{
			return _context.Realtors
				.Include(realtor => realtor.Deals);
		}
		#endregion
	}
}
