using System;

namespace Domain.IEntities {
	public interface ITrackedEntity {
	 	public DateTime DateCreated { get; set; }
	 	public DateTime DateChanged { get; set; }
	 	public string WhoChanged { get; set; }
	}
}