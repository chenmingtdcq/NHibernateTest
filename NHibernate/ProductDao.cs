using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernateORM.Entity;
using NHibernate;

namespace NHibernateORM
{
    public class ProductDao : IProductDao
    {
        private ISessionFactory sessionFactory;


        public ProductDao()
        {
            var cfg = new NHibernate.Cfg.Configuration().Configure(@"F:\code\NHibernateTest\NHibernateTest\Config\hibernate.cfg.xml");
            sessionFactory = cfg.BuildSessionFactory();
            NHibernate.Tool.hbm2ddl.SchemaExport export = new NHibernate.Tool.hbm2ddl.SchemaExport(cfg);
            export.SetOutputFile(@"F:\code\NHibernateTest\NHibernateTest\bin\sql\sql.sql");
            export.Drop(true, true);
            export.Create(true, true);
        }


        public void Delete(CLKZD entity)
        {
            using (ISession session = sessionFactory.OpenSession())
            {
                session.Delete(entity);
                session.Flush();
            }
        }

        public CLKZD Get(object id)
        {
            using (ISession session = sessionFactory.OpenSession())
            {
                return session.Get<CLKZD>(id);
            }
        }

        public CLKZD Load(object id)
        {
            using (ISession session = sessionFactory.OpenSession())
            {
                return session.Load<CLKZD>(id);
            }
        }

        public IList<CLKZD> LoadAll()
        {
            using (ISession session = sessionFactory.OpenSession())
            {
                return session.Query<CLKZD>().ToList();
            }
        }

        public object Save(CLKZD entity)
        {
            using (ISession session = sessionFactory.OpenSession())
            {
                var obj = session.Save(entity);
                session.Flush();
                return obj;
            }
        }

        public void Update(CLKZD entity)
        {
            using (ISession session = sessionFactory.OpenSession())
            {
                session.Update(entity);
                session.Flush();
            }
        }
    }
}
