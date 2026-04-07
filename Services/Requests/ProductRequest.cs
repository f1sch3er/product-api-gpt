

namespace Services.Requests
{
    public record ProductRequest(
        string Name,
        string Description,
        decimal Price,
        string Category,
        int Stock,
        List<string> Tags
    );
    
}
