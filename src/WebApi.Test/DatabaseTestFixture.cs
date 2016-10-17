/*
 * Copyright André Kirst
 * 2016 - 2016
 * School
*/
using System;
using WebApi.Base;

namespace WebApi.Test
{
    public class DatabaseTestFixture : IDisposable
    {
        private string _databaseName = String.Empty;

        /// <summary>
        /// Konstruktor für TestFixture
        /// </summary>
        public DatabaseTestFixture()
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
