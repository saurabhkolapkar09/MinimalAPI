namespace minimalAPIDemo.Models.DTO
{
    public record ProductDto(
     string Name,
     string Description,
     float Price,
     int StockQuantity
    );
}
