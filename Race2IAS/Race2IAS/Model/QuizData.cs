using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Race2IAS.Model
{
    public class QuizData
    {
        readonly SQLiteAsyncConnection database;
        public QuizData(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<questions>().Wait();
        }
        public Task<List<questions>> GetItemsAsync()
        {
            return database.Table<questions>().ToListAsync();
        }
        public async Task<questions> GetItemsAsync(int id)
        {
            questions q = await database.Table<questions>().Where(i => i._id == id).FirstOrDefaultAsync();
            return q;
        }
    }
}
