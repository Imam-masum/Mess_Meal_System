using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Abstructions.Base
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        //get by all 
        Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken cancellationToken=default);

        //get by Id
        Task<TEntity?> GetByIdAsync(long id,CancellationToken cancellationToken=default);

        //get by conditions

        Task<IEnumerable<TEntity>> GetByConditionAsync(Expression<Func<TEntity,bool>> expression,CancellationToken cancellationToken=default);
        Task<TEntity> GetFirstOrDefaultAsync(Expression<Func<TEntity,bool>> expression,CancellationToken cancellationToken=default);

        //Add Entity
        Task AddEntity(TEntity entity,CancellationToken cancellationToken=default);

        //add a range of entity

        Task AddRangeEntity(IEnumerable<TEntity> entityList,CancellationToken cancellationToken=default);

        //Update entity
        Task UpdateEntity(TEntity entity,CancellationToken cancellationToken = default);

        //update a range of entity

        Task UpdateRangeEntity(IEnumerable<TEntity> entityList, CancellationToken cancellationToken = default);

        //Delete by Id

        Task DeleteByIdAsyn(long id,CancellationToken cancellationToken=default);



    }
}
