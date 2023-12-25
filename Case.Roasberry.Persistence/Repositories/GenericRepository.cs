using Case.Roasberry.Application.Contracts.Persistence;
using Case.Roasberry.Core.Common;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Case.Roasberry.Persistence.Repositories;
public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
{
    private readonly ApplicationDbContext _context;
    private IQueryable<TEntity> Table { get; } = null!;

    public GenericRepository(ApplicationDbContext context)
    {
        _context = context;
        Table = context.Set<TEntity>();
    }

    public async Task<IList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>>? predicate = null)
    {
        var result = Table.AsQueryable();
        if (predicate != null)
        {
            result = result.Where(predicate);
        }
        return await result.ToListAsync();
    }

    public async Task<TEntity?> GetByIdAsync(Guid id)
    {
        var result = Table.AsQueryable().AsNoTracking();
        return await result.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<TEntity> InsertAsync(TEntity entity)
    {
        ArgumentNullException.ThrowIfNull(entity);
        entity.Id = Guid.NewGuid();
        _context.Add(entity);
        if (entity is IAuditable auditableEntity)
        {
            auditableEntity.CreatedOn = DateTime.Now;
            auditableEntity.ModifiedOn = null;
        }
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task UpdateAsync(TEntity entity)
    {
        ArgumentNullException.ThrowIfNull(entity);

        var updatedEntity = _context.Entry(entity);
        updatedEntity.State = EntityState.Modified;
        if (entity is IAuditable auditableEntity)
        {
            auditableEntity.ModifiedOn = DateTime.Now;
            _context.Entry(auditableEntity).Property(x => x.CreatedOn).IsModified = false;
            _context.Entry(auditableEntity).Property(x => x.CreatedBy).IsModified = false;
        }
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        ArgumentNullException.ThrowIfNull(entity);

        var addedEntity = _context.Entry(entity);
        addedEntity.State = EntityState.Deleted;
        await _context.SaveChangesAsync();
    }
}
