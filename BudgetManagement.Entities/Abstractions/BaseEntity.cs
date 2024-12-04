namespace BudgetManagement.Entities.Abstractions
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
    }
}
