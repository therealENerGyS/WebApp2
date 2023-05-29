namespace WebApp2.Models.Entities
{
    public class ContactEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? PhoneNumber { get; set; }
        public string? CompanyName { get; set; }
        public string Comment { get; set; } = null!;
        public DateTime Created { get; set; } = DateTime.Now;
    }
}