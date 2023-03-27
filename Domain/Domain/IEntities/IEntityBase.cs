namespace Domain.IEntities {
	public interface IEntityBase<TId> {
		TId Id { get; }
	}
}