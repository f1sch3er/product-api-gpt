
namespace Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string? Category { get; set; } = string.Empty;
        public int Stock { get; set; }
        public List<string> Tags { get; private set; } = new List<string>();
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }
        public DateTime DeletedAt { get; private set; }

        public Product(string name, string description, decimal price, string category, int stock, List<string> tags)
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.UtcNow;

            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.Category = category;
            this.Stock = stock;
            this.Tags = tags ?? new List<string>();
        }
        public void SetName(string name)
        {
            if (name.Length < 3)
            {
                throw new ArgumentException("Invalid name");
            }
            this.Name = name;
        }

        public void SetPrice(decimal price)
        {
            if (price < 0) 
            { 
                throw new ArgumentException("Price needs great than zero"); 
            } 
            this.Price = price;
        }
        public void MarkAsUpdated() 
        { 
            this.UpdatedAt = DateTime.UtcNow;
        }

        public void MarkAsDeleted()
        {
            this.DeletedAt = DateTime.UtcNow;
        }
    }
}
