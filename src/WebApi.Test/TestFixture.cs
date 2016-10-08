using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Base;

namespace WebApi.Test
{
    public class TestFixture : IDisposable
    {
        private string _databaseName = String.Empty;

        /// <summary>
        /// Konstruktor für TestFixture
        /// </summary>
        public TestFixture()
        {
            _databaseName = String.Format("Test_{0}", DateTime.Now.ToString("yyyyMMddHHmmss"));
            SchoolContext.Instance("mongodb://localhost:27017", _databaseName);
            SchoolContext.Instance().CreateTestDatabase();
        }

        /// <summary>
        /// TestFixture aufräumen
        /// </summary>
        public void Dispose()
        {
            SchoolContext.Instance().DropDatabase(_databaseName);
        }
    }
}
