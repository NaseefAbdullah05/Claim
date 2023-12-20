//using System;
//using System.Configuration;
//using System.Data.Common;

//namespace Gainsco.ClaimCenter.CodedUITests.Framework.Data
//{
//    public class DbConnectionFactory
//    {
//        #region Fields

//        private readonly DbProviderFactory _providerFactory;

//        #endregion Fields

//        #region Constructors

//        public DbConnectionFactory(DbProviderFactory providerFactory)
//        {
//            if (providerFactory == null)
//            {
//                throw new ArgumentNullException("providerFactory");
//            }

//            _providerFactory = providerFactory;
//        }

//        #endregion Constructors

//        #region Methods

//        #region Public Methods

//        public DbConnection CreateConnection()
//        {
//            var connectionString = ConfigurationManager.ConnectionStrings["As400"].ConnectionString;
//            return CreateConnection(connectionString);
//        }

//        public DbConnection CreateConnectionForSql()
//        {
//            var connectionString = ConfigurationManager.ConnectionStrings["GainscoConnect"].ConnectionString;
//            return CreateConnection(connectionString);
//        }
//        public DbConnection CreateConnection(string nameOrConnectionString)
//        {
//            DbConnection conn = _providerFactory.CreateConnection();


//            DbConnectionStringBuilder connStringBuilder = _providerFactory.CreateConnectionStringBuilder();
//            connStringBuilder.ConnectionString = nameOrConnectionString;

//            conn.ConnectionString = nameOrConnectionString;

//            return conn;
//        }

//        #endregion Public Methods

//        #endregion Methods
//    }
//}
