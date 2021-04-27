


namespace PizzaBox.Domain.Abstracts
{
  /// Gives the ORM an ID for ordering
  public interface IEntity
  {
    public int EntityId { get; set; }
  }
}