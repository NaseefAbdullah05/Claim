//using Microsoft.HostIntegration.MsDb2Client;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.Common;
//using System.Reflection;

//namespace Gainsco.ClaimCenter.CodedUITests.Framework.Data
//{
//    public static class DbCommandHelper
//    {
//        public static List<T> ExecuteQueryToList<T>(this MsDb2Command command)
//        {
//            var reader = command.ExecuteReader();
//            var dataTable = new DataTable();
//            dataTable.Load(reader);

//            if (dataTable.Rows.Count == 0)
//                return default(List<T>);

//            return CreateListFromTable<T>(dataTable);
//        }

//        public static T ExecuteQueryToObject<T>(this MsDb2Command command)
//        {
//            var reader = command.ExecuteReader();
//            var dataTable = new DataTable();
//            dataTable.Load(reader);

//            if (dataTable.Rows.Count == 0)
//                return default(T);

//            return CreateItemFromRow<T>(dataTable.Rows[0]);
//        }

//        public static List<T> ExecuteQueryToList<T>(this DbCommand command)
//        {
//            var reader = command.ExecuteReader();
//            var dataTable = new DataTable();
//            dataTable.Load(reader);

//            if (dataTable.Rows.Count == 0)
//                return default(List<T>);

//            return CreateListFromTable<T>(dataTable);
//        }

//        public static T ExecuteQueryToObject<T>(this DbCommand command)
//        {
//            var reader = command.ExecuteReader();
//            var dataTable = new DataTable();
//            dataTable.Load(reader);

//            if (dataTable.Rows.Count == 0)
//                return default(T);

//            return CreateItemFromRow<T>(dataTable.Rows[0]);
//        }

//        private static List<T> CreateListFromTable<T>(DataTable tbl)
//        {
//            // define return list
//            List<T> lst = new List<T>();

//            // go through each row
//            foreach (DataRow r in tbl.Rows)
//            {
//                // add to the list
//                lst.Add(CreateItemFromRow<T>(r));
//            }

//            // return the list
//            return lst;
//        }

//        private static T CreateItemFromRow<T>(DataRow row)
//        {
//            // create a new object
//            T item = (T)Activator.CreateInstance(typeof(T));

//            // set the item
//            SetItemFromRow(item, row);

//            // return 
//            return item;
//        }

//        private static void SetItemFromRow<T>(T item, DataRow row)
//        {
//            // go through each column
//            foreach (DataColumn c in row.Table.Columns)
//            {
//                // find the property for the column
//                PropertyInfo p = item.GetType().GetProperty(c.ColumnName, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);

//                // if exists, set the value
//                if (p != null && row[c] != DBNull.Value)
//                {
//                    p.SetValue(item, row[c], null);
//                }
//            }
//        }
//    }
//}
