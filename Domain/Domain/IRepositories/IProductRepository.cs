using Domain.Entities;
using Domain.Entities.Base;
using Domain.Entities.EntitiesQueryModels.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.IRepositories
{
    public interface IProductRepository
    {   /// <summary>
        /// Создание или редактирование продукта
        /// </summary>
        /// <param name="CurrentProduct"></param>
        /// <returns></returns>
        Task<Product> CreateOrEditProduct(Product CurrentProduct);
        /// <summary>
        /// Существует ли какой-либо продукт по заданному имени
        /// </summary>
        /// <param name="Id">Если проверяемый продукт существует</param>
        /// <param name="Name">Наименование</param>
        Task<bool> IsProductExists(Guid? Id, string Name);
        /// <summary>
        /// получение ID (именно из таблицы User) продавца по его бренду
        /// </summary>
        /// <param name="Id"></param>
        Task<Guid> GetSellerId(Guid Id);
        /// <summary>
        /// Выборка продуктов
        /// </summary>
        /// <param name="Page">Номер страницы</param>
        /// <param name="IsRemoved">Удален</param>
        /// <param name="BrandId">Код бренда</param>
        /// <param name="WorkingUserId">Код работающего пользователя</param>
        /// <param name="SearchName">Поисковая строка</param>
        /// <param name="Take">Кол-во записей для выборки</param>
        /// <returns></returns>
        Task<PagedQueryModel<ProductSearchQueryModel>> GetProductsForPage(int Page, bool IsRemoved, Guid? BrandId = null, Guid? WorkingUserId = null, string SearchName = null, int Take = 25);
        /// <summary>
        /// Метод получения продукта по ИД
        /// </summary>
        /// <param name="Id">Код продукта</param>
        Task<ProductQueryModel> GetProductById(Guid Id);
        /// <summary>
        /// Получаем кол-во продуктов, созданных данным пользователем
        /// </summary>
        /// <param name="UserId">Код пользователя</param>
        /// <returns></returns>
        Task<int> GetProductsCountOfUser(Guid UserId);
        /// <summary>
        /// Удаление продукта
        /// </summary>
        /// <param name="Id">Код продукта</param>
        /// <returns></returns>
        Task RemoveProduct(Guid Id);
        /// <summary>
        /// Выборка продуктов для всех страниц поиска продукта
        /// </summary>
        /// <param name="Query">Параметры запроса</param>
        /// <returns></returns>
        Task<PagedQueryModel<ProductViewQueryModel>> GetProductsForSearch(ProductQuerySearchParams Query);

    }
}
