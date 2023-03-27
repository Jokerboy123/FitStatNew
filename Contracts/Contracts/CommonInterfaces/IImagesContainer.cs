using Contracts.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.CommonInterfaces
{
    public interface IImagesContainer: IBaseEntityModel
	{
		///  <summary>
		///  Список файлов-изображений профиля
		/// </summary>
		public List<DataFileDtoBase> Images { get; set; }
		/// <summary>
		/// Код первого изображения
		/// </summary>
		public Guid? ImageId { get; set; }
	}
}
