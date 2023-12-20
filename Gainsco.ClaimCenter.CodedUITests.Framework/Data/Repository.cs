//using Gainsco.ClaimCenter.CodedUITests.Framework.Data.Models;
//using Microsoft.HostIntegration.MsDb2Client;
//using System.Collections.Generic;
//using System.Data.Common;
//using System.Data.SqlClient;

//namespace Gainsco.ClaimCenter.CodedUITests.Framework.Data
//{
//    public static class Repository
//    {
//        private static string _fileSchema = System.Configuration.ConfigurationManager.AppSettings["As400FileSchema"];

//        private static string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["GainscoConnect"].ConnectionString;


//        private static SqlConnection Connection()
//        {
//            var connection = new SqlConnection(_connectionString);
//            connection.Open();
//            return connection;
//        }


//        public static List<DriverRegistration> GetAllDriverLicense()
//        {
//            var sql = @"
//                SELECT 
//                DRIVER_FIRST_NAME AS DriverFirstName, 
//                DRIVER_LAST_NAME AS DriverLastName , 
//                DRIVER_MIDDLE_NAME AS DriverMiddleName, 
//                DRIVER_ADDRESS AS DriverAddress,
//                DRIVER_CITY AS DriverCity , 
//                DRIVER_STATE AS DriverState,
//                DRIVER_ZIP AS DriverZip , 
//                DRIVER_DATE_OF_BIRTH AS DriverDateOfBirth, 
//                DRIVER_LICENSE_NBR AS DriverLicenseNumber, 
//                DRIVER_LICENSE_STATE AS DriverLicenseState , 
//                DRIVER_CLASS AS DriverClass
//                FROM @schema.MVRMSTR (NOLOCK)
//                ";

//            sql = sql.Replace("@schema", _fileSchema);

//            // Connect to DB2
//            using (var connection = (MsDb2Connection)new DbConnectionFactory(MsDb2Factory.Instance).CreateConnection())
//            {
//                connection.Open();

//                // Execute the sql statement
//                var command = new MsDb2Command(sql, connection);

//                return command.ExecuteQueryToList<DriverRegistration>();
//            }
//        }

//        public static DriverRegistration GetDriverLicense(string licenseNumber)
//        {
//            DriverRegistration driverRegistration = new DriverRegistration();

//            var sql = @"
//                SELECT 
//                DRIVER_FIRST_NAME AS DriverFirstName, 
//                DRIVER_LAST_NAME AS DriverLastName , 
//                DRIVER_MIDDLE_NAME AS DriverMiddleName, 
//                DRIVER_ADDRESS AS DriverAddress,
//                DRIVER_CITY AS DriverCity , 
//                DRIVER_STATE AS DriverState,
//                DRIVER_ZIP AS DriverZip , 
//                DRIVER_DATE_OF_BIRTH AS DriverDateOfBirth, 
//                DRIVER_LICENSE_NBR AS DriverLicenseNumber, 
//                DRIVER_LICENSE_STATE AS DriverLicenseState , 
//                DRIVER_CLASS AS DriverClass
//                FROM @schema.MVRMSTR (NOLOCK)
//                WHERE DRIVER_LICENSE_NBR = @licenseNumber
//                ";

//            sql = sql.Replace("@schema", _fileSchema);

//            // Connect to DB2
//            using (var connection = (MsDb2Connection)new DbConnectionFactory(MsDb2Factory.Instance).CreateConnection())
//            {
//                connection.Open();

//                // Execute the sql statement
//                var command = new MsDb2Command(sql, connection);
//                command.Parameters.Add(new MsDb2Parameter { ParameterName = "@licenseNumber", Value = licenseNumber });
//                return command.ExecuteQueryToObject<DriverRegistration>();
//            }
//        }

//        public static DriverRegistration GetExistingDriverLicenseNumber()
//        {
//            var sql = @"
//                SELECT 
//                DRIVER_FIRST_NAME AS DriverFirstName, 
//                DRIVER_LAST_NAME AS DriverLastName , 
//                DRIVER_MIDDLE_NAME AS DriverMiddleName, 
//                DRIVER_ADDRESS AS DriverAddress,
//                DRIVER_CITY AS DriverCity , 
//                DRIVER_STATE AS DriverState,
//                DRIVER_ZIP AS DriverZip , 
//                DRIVER_DATE_OF_BIRTH AS DriverDateOfBirth, 
//                DRIVER_LICENSE_NBR AS DriverLicenseNumber, 
//                DRIVER_LICENSE_STATE AS DriverLicenseState , 
//                DRIVER_CLASS AS DriverClass
//                FROM @schema.MVRMSTR (NOLOCK)
//                WHERE DRIVER_STATE = 'TX'
//                AND DRIVER_LICENSE_NBR  like '1%'
//                ORDER BY RAND()
//                LIMIT 1
//                ";

//            sql = sql.Replace("@schema", _fileSchema);

//            // Connect to DB2
//            using (var connection = (MsDb2Connection)new DbConnectionFactory(MsDb2Factory.Instance).CreateConnection())
//            {
//                connection.Open();

//                // Execute the sql statement
//                var command = new MsDb2Command(sql, connection);
//                //command.Parameters.Add(new MsDb2Parameter { ParameterName = "@licenceNumber", Value = licenceNumber });

//                return command.ExecuteQueryToObject<DriverRegistration>();
//            }
//        }

//        public static FormRequest GetFormRequestPDFFileArchive(string policyNumber)
//        {
//            var sql = @"
//                SELECT TOP 1 FormRequestId, ArchiveFolder, ArchiveName
//                FROM dbo.FormRequest (NOLOCK)
//                WHERE PolicyNumber = replace (@policyNumber,'-','')
//                        AND ArchiveName LIKE 'PRINT_ALL%'";

//            using (var connection = Connection())
//            {
//               // connection.Open();

//                // Execute the sql statement
//                var command = connection.CreateCommand();
//                command.CommandText = sql;
//                command.Parameters.Add(new SqlParameter { ParameterName = "@policyNumber", Value = policyNumber });

//                return command.ExecuteQueryToObject<FormRequest>();
//            }
//        }
//    }
//}