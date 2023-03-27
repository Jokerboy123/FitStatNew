using Domain.Entities;
using Domain.IRepositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.IRepositories
{
    public interface ISettingsRepository : IRepository<SystemSettings>
    { /// <summary>
      /// Сохранение настроек Системы
      /// </summary>
      /// <param name="ChangedSettings">Измененные настройки</param>
      /// <param name="UserId">Код пользователя, который выполняет изменения</param>
      /// <param name="UserEditInfo">Описание пользователя, который меняет настройки</param>
      /// <returns></returns>
        Task<SystemSettings> SaveSettings(SystemSettings ChangedSettings,
           Guid UserId, string UserEditInfo);
        /// <summary>
        /// Получения текущих настроек
        /// </summary>
        Task<SystemSettings> GetSettings();
    }
}
