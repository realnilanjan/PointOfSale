using Dapper;
using PointOfSale.Lib.DataModel;
using PointOfSale.Lib.Models;
using PointOfSale.Lib.Models.ReportModels;
using PointOfSale.Lib.TerminalModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

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

        public List<UserDataModel> LoadAllUsers()
        {
            var rows = LoadData<UserDataModel, dynamic>("dbo.LoadAllUsers", new { }, "POS");
            return rows;
        }

        public List<CategoryDataModel> LoadAllCategories()
        {
            var rows = LoadData<CategoryDataModel, dynamic>("dbo.LoadAllCategories", new { }, "POS");
            return rows;
        }
        
        public List<SupplierDataModel> LoadAllSuppliers()
        {
            var rows = LoadData<SupplierDataModel, dynamic>("dbo.LoadAllSuppliers", new { }, "POS");
            return rows;
        }

        public List<QuantityDescriptionModel> LoadAllQuantityDescriptions()
        {
            var rows = LoadData<QuantityDescriptionModel, dynamic>("dbo.LoadAllQuantityDescriptions", new { }, "POS");
            return rows;
        }

       

        public List<ProductDataModel> LoadAllProducts()
        {
            var rows = LoadData<ProductDataModel, dynamic>("dbo.LoadAllProducts", new { }, "POS");
            return rows;
        }

        public List<OrderedStockPurchasesModel> GetOrderedStockPurchases(string Barcode)
        {
            var rows = LoadData<OrderedStockPurchasesModel, dynamic>("dbo.GetOrderedStockPurchases", new { Barcode }, "POS");
            return rows;
        }

        public List<PurchaseOrdersDataModel> LoadPurchasedStock()
        {
            var rows = LoadData<PurchaseOrdersDataModel, dynamic>("dbo.GetAllPurchaseOrders", new { }, "POS");
            return rows;
        }

        public List<ProductToStockDataModel> ProductToStock(string Barcode)
        {
            var rows = LoadData<ProductToStockDataModel, dynamic>("dbo.ProductToStock", new { Barcode }, "POS");
            return rows;
        }

        public List<PurchasedStockDataModel> LoadAllStockPurchased()
        {
            var rows = LoadData<PurchasedStockDataModel, dynamic>("dbo.GetAllPurchasedStock", new { }, "POS");
            return rows;
        }

        public ProductForCartModel GetProductForCart(string Barcode)
        {
            var rows = LoadData<ProductForCartModel, dynamic>("dbo.GetProductForCart", new { Barcode }, "POS");
            return rows.FirstOrDefault();
        }

        public List<CouponDataModel> GetAllCoupons()
        {
            var rows = LoadData<CouponDataModel, dynamic>("dbo.GetAllCoupons", new { }, "POS");
            return rows;
        }

        public CouponDataModel GetCoupon(string CouponCode)
        {
            var rows = LoadData<CouponDataModel, dynamic>("dbo.GetAppliedCoupon", new { CouponCode }, "POS");
            return rows.FirstOrDefault();
        }

        public int SaveSale(string storedProcedure, SaleModel parameters, string connectionStringName)
        {
            string connectionString = GetConnectionString(connectionStringName);
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                var Id = connection.Query<int>(storedProcedure, parameters, commandType: CommandType.StoredProcedure).Single();
                return Id;
            }
        }

        public List<CustomerDataModel> GetAllCustomers()
        {
            var rows = LoadData<CustomerDataModel, dynamic>("dbo.GetAllCustomers", new { }, "POS");
            return rows;
        }

        public CustomerDataModel GetCustomerById(int Id)
        {
            var rows = LoadData<CustomerDataModel, dynamic>("dbo.GetCustomerDetails", new { Id }, "POS");
            return rows.FirstOrDefault();
        }

        public decimal? LoadTodaySalesTotal(string connectionStringName = "POS")
        {
            string connectionString = GetConnectionString(connectionStringName);
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                var result = connection.Query<decimal?>("dbo.GetSalesForToday", commandType: CommandType.StoredProcedure);
                return result.FirstOrDefault();
            }
        }

        public decimal? GetAllSaleTotal(string connectionStringName = "POS")
        {
            string connectionString = GetConnectionString(connectionStringName);
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                var result = connection.Query<decimal?>("dbo.GetTotalSales", commandType: CommandType.StoredProcedure);
                return result.FirstOrDefault();
            }
        }

        public int? GetStocksSold(string connectionStringName = "POS")
        {
            string connectionString = GetConnectionString(connectionStringName);
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                var result = connection.Query<int?>("dbo.GetStocksSold", commandType: CommandType.StoredProcedure);
                return result.FirstOrDefault();
            }
        }

        public int? GetTotalTransaction(string connectionStringName = "POS")
        {
            string connectionString = GetConnectionString(connectionStringName);
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                var result = connection.Query<int?>("dbo.GetTotalTransaction", commandType: CommandType.StoredProcedure);
                return result.FirstOrDefault();
            }
        }
    }
}
