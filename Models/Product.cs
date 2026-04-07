
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

            this.SetName(name);
            this.SetDescription(description);
            this.SetPrice(price);
            this.SetCategory(category);
            this.SetStock(stock);
            
            this.Tags = tags ?? new List<string>();
        }
        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name)||name.Length < 3)
            {
                throw new ArgumentException("Invalid name");
            }
            this.Name = name;
        }
        public void SetDescription(string description)
        {
            if (string.IsNullOrEmpty(description))
            {
                throw new ArgumentException("Description is required");
            }
            this.Description = description;
        }

        public void SetPrice(decimal price)
        {
            if (price <= 0) 
            { 
                throw new ArgumentException("Price needs great than zero"); 
            } 
            this.Price = price;
        }


        public void SetStock(int stock)
        {
            if (stock < 0)
            {
                throw new ArgumentException("Stock cannot be negative");
            }
            this.Stock = stock;
        }

        public void SetCategory(string category)
        {
            if (string.IsNullOrEmpty(category))
            {
                throw new ArgumentException("Category is required");
            }
            this.Category = category;
        }

        public void AddTag(string tag)
        {
            if (string.IsNullOrWhiteSpace(tag))
                throw new ArgumentException("Invalid tag");

            if (Tags.Contains(tag))
                return;

            Tags.Add(tag);
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
