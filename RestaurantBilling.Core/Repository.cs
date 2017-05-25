using System;
using RestaurantBilling.Core.Models;
using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestaurantBilling.Core
{
    public class Repository
    {
        private readonly SQLiteAsyncConnection conn;

        public string StatusMessage { get; set; }

        public Repository(string dbPath)
        {
            conn = new SQLiteAsyncConnection(dbPath);
            conn.CreateTableAsync<Bill>().Wait();
        }

        public async Task CreateBill(Bill bill)
        {
            try {
				if (string.IsNullOrWhiteSpace(bill.CustomerEmail))
					throw new Exception("Customer Email is required");

				var result = await conn.InsertAsync(bill).ConfigureAwait(continueOnCapturedContext: false);
				StatusMessage = $"{result} record(s) added [Customer Email: {bill.CustomerEmail})";
            }
            catch(Exception ex)
            {
                StatusMessage = $"Failed to create {bill.CustomerEmail}'s bill. Error: {ex.Message}";
            }
        }

        public Task <List<Bill>> GetAllBills()
        {
            return conn.Table<Bill>().ToListAsync();
        }
    }
}
