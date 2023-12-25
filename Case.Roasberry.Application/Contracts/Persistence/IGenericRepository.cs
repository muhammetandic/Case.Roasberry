using Case.Roasberry.Core.Common;
using System.Linq.Expressions;

namespace Case.Roasberry.Application.Contracts.Persistence;
public interface IGenericRepository<TEntity> where TEntity : IEntity
{
    Task<IList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>>? predicate = null);

    Task<TEntity?> GetByIdAsync(Guid id);

    Task<TEntity> InsertAsync(TEntity entity);

    Task UpdateAsync(TEntity entity);

    Task DeleteAsync(Guid id);
}
