namespace MiniETicaret.Products.WebAPI.Dtos
{
    public sealed record class CreateProductDto(string Name, decimal Price, int Stock);
}
