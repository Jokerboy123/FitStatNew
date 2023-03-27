using System;
using Domain.IEntities;

namespace Domain.Entities.Base
{
	public class TrackedEntity : Entity, ITrackedEntity {
		public TrackedEntity()
        {
			DateCreated = DateTime.UtcNow;
        }
		public DateTime DateCreated { get; set; }
		public DateTime DateChanged { get; set; }
		public string WhoChanged { get; set; }
	}
}