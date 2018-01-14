using NHibernateORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateORM
{
    public interface IProductDao
    {
        object Save(Product entity);

        void Update(Product entity);

        void Delete(Product entity);

        Product Get(object id);

        Product Load(object id);

        IList<Product> LoadAll();
    }
}
