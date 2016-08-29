using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace MobileVisit.EntityFramework.Repositories
{
    public abstract class MobileVisitRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<MobileVisitDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected MobileVisitRepositoryBase(IDbContextProvider<MobileVisitDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class MobileVisitRepositoryBase<TEntity> : MobileVisitRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected MobileVisitRepositoryBase(IDbContextProvider<MobileVisitDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
