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
            _databaseName = String.Format("Test_{0}", DateTime.Now.ToString("yyyyMMdd_HHmmss_ffff_" + Guid.NewGuid().ToString().Substring(0, 8)));
            SchoolContext.Instance("mongodb://localhost:27017", _databaseName);
            SchoolContext.Instance().CreateTestDatabase();
        }

        public string TestClassName
        {
            get; set;
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
