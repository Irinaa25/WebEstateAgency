using Business.Enties;
using Business.Repositories.DataRepositories;

using Microsoft.EntityFrameworkCore;
using Repository.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class EstateTypeRepository : AbstractRepository<EstateType, int>, IEstateTypeRepository
	{
		public EstateTypeRepository(Context context)
		{
			_context = context;
		}

		#region implementation
		protected override int KeySelector(EstateType entity) => entity.Id;

		protected override EstateType ReadImplementation(int key)
		{
			return QueryImplementation().FirstOrDefault(i => i.Id == key);
		}

		protected override async Task<EstateType> ReadImplementationAsync(int key)
		{
			return await QueryImplementation().FirstOrDefaultAsync(i => i.Id == key);
		}

		protected override void CreateImplementation(EstateType value)
		{
			_context.EstateTypes.Add(value);
		}

		protected override async Task CreateImplementationAsync(EstateType value)
		{
			await _context.EstateTypes.AddAsync(value);
		}

		protected override void UpdateImplementation(EstateType entity, EstateType value)
		{
			_context.ChangeTracker.Clear();
			_context.Update(value);
		}

		protected override void DeleteImplementation(EstateType value)
		{
			var entity = ReadImplementation(value.Id);
			if (entity == null) return;
			_context.EstateTypes.Remove(entity);
		}

		protected override IQueryable<EstateType> QueryImplementation()
		{
			return _context.EstateTypes
				.Include(estatetype => estatetype.Estates);
		}
		#endregion
	}

}
