using CafeManager5000.DataAccess.Model;

namespace CafeManager5000.DataAccess
{
    public static class DaoFactory
    {
        public static IDao<TEntity>? Create<TEntity>(Modes mode = Modes.Memory) where TEntity : class
        {
            switch (mode)
            {
                case Modes.Memory:
                    if (typeof(TEntity).IsAssignableFrom(typeof(Product)))
                    {
                        return new DaoFake.ProductDao() as IDao<TEntity>;
                    }
                    else if (typeof(TEntity).IsAssignableFrom(typeof(Order)))
                    {
                        return new DaoFake.OrderDao() as IDao<TEntity>;
                    }
                    break;
                case Modes.Sql:
                    break;
            }
            throw new DaoException($"Factory could not create data access object for type [{typeof(TEntity)}]");
        }

        public enum Modes
        {
            Memory,
            Sql,
        }
    }
}