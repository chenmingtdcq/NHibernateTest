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
        object Save(CLKZD entity);

        void Update(CLKZD entity);

        void Delete(CLKZD entity);

        CLKZD Get(object id);

        CLKZD Load(object id);

        IList<CLKZD> LoadAll();
    }
}
