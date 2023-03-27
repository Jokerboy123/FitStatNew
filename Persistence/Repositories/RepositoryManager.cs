using Domain.IRepositories;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class RepositoryManager: IRepositoryManager
    {
        private readonly Lazy<IUserRepository> _lazyUserRepository;
        public RepositoryManager(string dbPath)
        {
            _lazyUserRepository = new Lazy<IUserRepository>(() => new UserRepository(dbPath));
        }
        public IUserRepository _userRepository => _lazyUserRepository.Value;
    }
}
