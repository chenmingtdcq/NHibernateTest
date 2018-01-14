using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NHibernateORM;
using System.Data;
using System.Data.Common;

namespace NHibernateTest
{
    [TestClass]
    public class UnitTest1
    {
        private IProductDao productDao;

        [TestMethod]
        public void TestMethod1()
        {

        }

        [TestMethod]
        public void Init()
        {
            productDao = new ProductDao();
        }

        [TestMethod]
        public void SaveTest()
        {
            Init();
            var product = new NHibernateORM.Entity.Product()
            {
                ID = Guid.NewGuid(),
                BuyPrice = 10M,
                Code = "ABC123",
                QuantityPerUnit = "20x1",
                SellPrice = 11M,
                Unit = "台",
            };
            var obj = productDao.Save(product);

            Assert.IsNotNull(obj);
        }

        [TestMethod]
        public void TestSchema()
        {
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = "database=nhibernate;server=localhost;user id=root;password=mysqlbjdxcm2018;pooling=true;port=3306;allow zero datetime=true";
            conn.Open();
            var table = conn.GetSchema();
            DataTable tables = conn.GetSchema(DbMetaDataCollectionNames.ReservedWords);
        }
    }
}
