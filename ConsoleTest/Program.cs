using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var cfg = new Configuration().Configure("Config/hibernate.cfg.xml");
            var session = cfg.BuildSessionFactory();
            NHibernate.Tool.hbm2ddl.SchemaExport schemaExport = new NHibernate.Tool.hbm2ddl.SchemaExport(cfg);
            //schemaExport.SetOutputFile(@"");
            schemaExport.Drop(true, true);
            schemaExport.Create(true, true);
        }
    }
}
