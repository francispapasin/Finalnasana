using SQLite;
using System.IO;
using System.Threading.Tasks;
using Finalnasana.Models;
using Finalnasana.Services;

namespace Finalnasana.Services
{
    public class DatabaseService
    {
        private readonly SQLiteAsyncConnection _database;

        public DatabaseService()
        {
            var dbPath = Path.Combine(FileSystem.AppDataDirectory, "StudentSchedule.db");
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<StudentSchedule>().Wait();
        }

        public Task<List<StudentSchedule>> GetSchedulesAsync()
        {
            return _database.Table<StudentSchedule>().ToListAsync();
        }

        public Task<StudentSchedule> GetScheduleAsync(int id)
        {
            return _database.FindAsync<StudentSchedule>(id);
        }

        public Task<int> AddScheduleAsync(StudentSchedule schedule)
        {
            return _database.InsertAsync(schedule);
        }

        public Task<int> UpdateScheduleAsync(StudentSchedule schedule)
        {
            return _database.UpdateAsync(schedule);
        }

        public Task<int> DeleteScheduleAsync(int id)
        {
            return _database.DeleteAsync<StudentSchedule>(id);
        }
    }
}
