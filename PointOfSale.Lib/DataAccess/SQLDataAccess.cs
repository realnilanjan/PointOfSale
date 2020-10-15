using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using PointOfSale.Lib.Models;

namespace PointOfSale.Lib.DataAccess
{
    public class SQLDataAccess
    {
        private string GetConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public void SaveData<T>(string storedProcedure, T parameters, string connectionStringName)
        {
            string connectionString = GetConnectionString(connectionStringName);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Execute(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public List<T> LoadData<T, U>(string storedProcedure, U parameters, string connectionStringName)
        {
            string connectionString = GetConnectionString(connectionStringName);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                List<T> rows = connection.Query<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure).ToList();
                return rows;
            }
        }

        public List<LoggedInUserModel> VerifyUser(string username, string password)
        {
            var rows = LoadData<LoggedInUserModel, dynamic>("dbo.UserLogin", new { username, password }, "POS");
            return rows;
        }

        public List<BusinessInformation> GetBusinessInformation()
        {
            var rows = LoadData<BusinessInformation, dynamic>("dbo.GetBusinessInfo", new { }, "POS");
            return rows;
        }

        public List<UserModel> LoadAllUsers()
        {
            var rows = LoadData<UserModel, dynamic>("dbo.LoadAllUsers", new { }, "POS");
            return rows;
        }
    }
}
