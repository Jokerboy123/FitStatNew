using Contracts.CommonInterfaces;
using Contracts.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Base
{/// <summary>
/// Этот класс нужен, если мы отображаем сущность, в которой могут быть изображения
/// </summary>
    public class BaseEntityImageContainerModel: BaseTrackedModel, IImagesContainer
    {
		public BaseEntityImageContainerModel()
        { 
			ImageId = null;
		}
		///  <summary>	 
		///  Список файлов-изображений профиля	 
		/// </summary>
		public List<DataFileDtoBase> Images { get; set; } = new List<DataFileDtoBase>();
		/// <summary>
		/// Код первого изображения
		/// </summary>
		public Guid? ImageId { get; set; }
	}
}
