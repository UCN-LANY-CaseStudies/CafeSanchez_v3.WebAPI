using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManager5000.DataAccess
{
    public interface IDao<TEntity> where TEntity : class
    {
        TEntity Create(TEntity entity);

        IEnumerable<TEntity> ReadAll();

        bool Update(TEntity entity);

        bool Delete(TEntity entity);
    }
}
