using Domain.IEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Base
{
    public static class TrackedEntityUtilities
	{   /// <summary>
		/// Заполнение сведений о редактировании текущей сущности
		/// </summary>
		/// <param name="Entity">Сущнность</param>
		/// <param name="WhoChanged">Кто изменил</param>
		/// <param name="DateChanged">Дата изменения (если не задана - берется текущая)</param>
		public static void FillChangeData(this ITrackedEntity Entity, string WhoChanged, DateTime? DateChanged = null)
		{
			Entity.WhoChanged = WhoChanged ?? "";
			Entity.DateChanged = DateChanged == null ? DateTime.UtcNow : DateChanged.Value;
		}
	}
}
