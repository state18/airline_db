using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace AirlineDBProject {
    public static class DataAccess {

        private static String cnnName = "AirlineDB";

        // This is just an example for reference. Delete this before turning in project.
        public static List<Customer> GetCustomers(string lastName) {

            using (IDbConnection connection = new MySql.Data.MySqlClient.MySqlConnection(Helper.CnnVal(cnnName))) {
                return connection.Query<Customer>($"select * from Customer where lName = '{lastName}'").ToList();
            }
        }

        /// <summary>
        /// Lookup username/password in database. Return appropriate code...
        /// 0: Username found and input password matches.
        /// 1: Username found but input password does not match.
        /// 2: Username not found.
        /// </summary>
        /// <returns></returns>
        public static int VerifyLogin(string inputUserName, string inputPassword) {
            using (IDbConnection connection = new MySql.Data.MySqlClient.MySqlConnection(Helper.CnnVal(cnnName))) {
                // First, try to lookup the customer by username.
                var foundCustomer = connection.Query<Customer>($"select * from Customer where username = '{inputUserName}'");

                if (foundCustomer.Count() == 0)
                    return 2;

                if (foundCustomer.First().passwd.Equals(inputPassword))
                    return 0;
                else
                    return 1;
            }
        }
    }
}