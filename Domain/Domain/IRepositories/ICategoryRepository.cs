using Domain.Controls;
using Domain.Entities;
using Domain.IRepositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.IRepositories
{
    public interface ICategoryRepository:IRepository<Category>
    {
        /// <summary>
        /// Вывод перечня категорий в выпадающий список
        /// </summary>
        /// <param name="UserId">Код пользователя, создавшего категорию</param>       
        /// <param name="Name">Имя категории</param>
        /// <returns></returns>
        Task<List<SelectViewDomain<Guid>>> GetCategoryForSelect(Guid? UserId = null, string Name = "");
    }
}
