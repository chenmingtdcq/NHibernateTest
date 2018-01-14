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
            var cfg = new NHibernate.Cfg.Configuration().Configure(@"F:/program/practice/NHibernateTest/NHibernateTest/Config/hibernate.cfg.xml");
            sessionFactory = cfg.BuildSessionFactory();
            NHibernate.Tool.hbm2ddl.SchemaExport export = new NHibernate.Tool.hbm2ddl.SchemaExport(cfg);
            export.SetOutputFile(@"F:\program\practice\NHibernateTest\NHibernateTest\bin\sql\sql.sql");
            export.Drop(true, true);
            export.Create(true, true);
        }


        public void Delete(Product entity)
        {
            using (ISession session = sessionFactory.OpenSession())
            {
                session.Delete(entity);
                session.Flush();
            }
        }

        public Product Get(object id)
        {
            using (ISession session = sessionFactory.OpenSession())
            {
                return session.Get<Product>(id);
            }
        }

        public Product Load(object id)
        {
            using (ISession session = sessionFactory.OpenSession())
            {
                return session.Load<Product>(id);
            }
        }

        public IList<Product> LoadAll()
        {
            using (ISession session = sessionFactory.OpenSession())
            {
                return session.Query<Product>().ToList();
            }
        }

        public object Save(Product entity)
        {
            using (ISession session = sessionFactory.OpenSession())
            {
                var obj = session.Save(entity);
                session.Flush();
                return obj;
            }
        }

        public void Update(Product entity)
        {
            using (ISession session = sessionFactory.OpenSession())
            {
                session.Update(entity);
                session.Flush();
            }
        }
    }
}
