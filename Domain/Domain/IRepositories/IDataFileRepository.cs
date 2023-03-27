using Domain.Entities;
using Domain.Entities.EntitiesQueryModels;
using Domain.IRepositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.IRepositories
{
    public interface IDataFileRepository : IRepository<DataFile>
    {
        /// <summary>
        /// Создание файла
        /// </summary>
        /// <param name="NewFile">Объект файла</param>
        /// <returns></returns>
        Task<DataFile> CreateFile(DataFile NewFile);
        /// <summary>
        /// Удалить файлы объекта
        /// </summary>
        /// <param name="ParentId">Код объекта</param>
        /// <returns></returns>
        Task RemoveFilesOfParent(Guid ParentId);
        /// <summary>
        /// Метод получения файла.
        /// </summary>
        Task<Guid?> GetFileIdByParentCode(Guid ParentCode);
        /// <summary>
        /// Метод получения файлов без содержания.
        /// </summary>
        Task<IReadOnlyList<DataFilePreview>> GetFilesOfParentWithoutContent(Guid ParentCode);
        /// <summary>
        /// Метод получения файлов по родительскому коду.
        /// </summary>
        Task<IReadOnlyList<DataFile>> GetFilesByParentCode(Guid ParentCode);
    }
}
