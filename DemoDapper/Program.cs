using Dapper;
using eShop.CoreBusiness.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DemoDapper
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectStr = "Data Source=(local);Initial Catalog=eShop;Integrated Security=True";
            using (IDbConnection conn = new SqlConnection(connectStr))
            {
                var results = conn.Query<Product>("SELECT * FROM Product");
                foreach (var record in results)
                {
                    Console.WriteLine($"{record.Name}: {record.Price}");
                }
            }
        }
    }
}
