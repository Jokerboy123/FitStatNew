using Common;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.IRepositories
{
    public interface ILogRepository
    {    /// <summary>
         /// Метод создания записи
         /// </summary>
         /// <param name="Log"><see cref="Log"/></param>
          Task<Log> Create(Log log);
        /// <summary>
        /// Метод получения списка логов в диапазоне
        /// </summary>
        /// <param name="DateStart">Начальная дата</param>
        /// <param name="DateEnd">Конечная дата</param>
        Task<IEnumerable<Log>> GetLogsByDate(DateTime DateStart, DateTime DateEnd);
        /// <summary>
        /// Метод получения списка логов пользователя.
        /// </summary>
        /// <param name="UserId">Код пользователя</param>
        Task<IEnumerable<Log>> GetLogsByUserId(Guid UserId);
        /// <summary>
        /// Метод получения списка логов по типу Лога
        /// </summary>
        /// <param name="Type"><see cref="LogType"/></param>
        Task<IEnumerable<Log>> GetLogsByType(LogType Type);
    }
}
