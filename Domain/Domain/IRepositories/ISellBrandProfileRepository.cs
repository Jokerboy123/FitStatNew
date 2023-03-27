using Domain.Controls;
using Domain.Entities;
using Domain.Entities.Base;
using Domain.Entities.EntitiesQueryModels.SellBrandProfile;
using Domain.IRepositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.IRepositories
{
    public interface ISellBrandProfileRepository : IRepository<SellBrandProfile>
    {
        /// <summary>
        /// получение ID продавца по его бренду
        /// </summary>
        /// <param name="Id"></param>
        Task<Guid> GetSellerId(Guid Id);
        /// <summary>
        /// Существует ли какой-либо бренд по заданному имени
        /// </summary>
        /// <param name="Id">Если проверяемый бренд существует</param>
        /// <param name="Name">Наименование</param>
        Task<bool> IsSellBrandProfileExists(Guid? Id, string Name);
        /// <summary>
        /// Создание или редактирование бренда
        /// </summary>
        /// <param name="CurrentSellBrandProfile"></param>
        /// <returns></returns>
        Task<SellBrandProfile> CreateOrEditSellBrandProfile(SellBrandProfile CurrentSellBrandProfile);
        /// <summary>
        /// Выборка брендов
        /// </summary>
        /// <param name="Page">Номер страницы</param>
        /// <param name="IsRemoved">Удален</param>
        /// <param name="WorkingUserId">Код работающего пользователя</param>
        /// <param name="SearchName">Поисковая строка</param>
        /// <param name="Take">Кол-во записей для выборки</param>
        /// <returns></returns>
        Task<PagedQueryModel<SellBrandProfileSearchQueryModel>> GetSellBrandProfilesForPage(int Page, bool IsRemoved, Guid? WorkingUserId = null, string SearchName = null, int Take = 25);
        /// <summary>
        /// Метод получения бренда по ИД
        /// </summary>
        /// <param name="id">Код бренда</param>
        Task<SellBrandProfile> GetSellBrandProfileById(Guid id);
        /// <summary>
        /// Удаление бренда
        /// </summary>
        /// <param name="Id">Идентификатор</param>
        /// <param name="WhoChangedInfo">Информация о том, кто удаляет</param>
        /// <returns></returns>
        Task RemoveSellBrandProfile(Guid Id, string WhoChangedInfo);
        /// <summary>
        /// Вывод перечня брендов в выпадающий список
        /// </summary>
        /// <param name="UserId">Код пользователя, владеющего брендом</param>       
        /// <param name="Name">Имя бренда</param>
        /// <returns></returns>
        Task<List<SelectViewDomain<Guid>>> GetBrandsForSelect(Guid? UserId = null, string Name = "");
        /// <summary>
        /// Получаем кол-во брендов, созданных данным пользователем
        /// </summary>
        /// <param name="UserId">Код пользователя</param>
        /// <returns></returns>
        Task<int> GetBrandsCountOfUser(Guid UserId);
    }
}
