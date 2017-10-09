﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;

namespace SEPPokemon.Controllers
{
    public class DataMigrationController : Controller
    {
        public static void Page_Load()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var excel = new ExcelPackage(new FileInfo(@"D:\DataSample.xlsx"));
            var dt = excel.ToDataTable();
            var table = "Pokemon";
            using (var conn = new SqlConnection("Server=(localdb)\\mssqllocaldb;Database=SEPPokemon4Context-26c6f443-cf59-4e4b-a5ed-2aca32f4b22d;Integrated Security=SSPI"))
            {
                var bulkCopy = new SqlBulkCopy(conn);
                bulkCopy.DestinationTableName = table;
                conn.Open();
                var schema = conn.GetSchema("Columns", new[] { null, null, table, null });
                foreach (DataColumn sourceColumn in dt.Columns)
                {
                    foreach (DataRow row in schema.Rows)
                    {
                        if (string.Equals(sourceColumn.ColumnName, (string)row["COLUMN_NAME"], StringComparison.OrdinalIgnoreCase))
                        {
                            bulkCopy.ColumnMappings.Add(sourceColumn.ColumnName, (string)row["COLUMN_NAME"]);
                            break;
                        }
                    }
                }
                bulkCopy.WriteToServer(dt);
            }
        }
        public IActionResult Index()
        {
            Page_Load();
            return View();
        }
    }
}
