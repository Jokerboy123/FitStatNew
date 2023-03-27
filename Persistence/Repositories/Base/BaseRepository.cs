using Domain.Entities;
using Domain.Entities.Base;
using Domain.IRepositories.Base;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.Base
{
    public class BaseRepository<T> : IRepository<T> where T : Entity
    {      

        protected readonly SQLiteAsyncConnection database;
        public BaseRepository(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<User>().Wait();
        }

      
    }
}
