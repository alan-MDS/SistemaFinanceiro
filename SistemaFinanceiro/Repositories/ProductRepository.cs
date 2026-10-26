using FinacialSystem.DTOs;
using FinacialSystem.Entities;

namespace FinacialSystem.Repositories;

public static class ProductRepository
{
    private static readonly List<Product> Products = new() { new(0, "Unnamed", 0, 0)};
    
    public static void AddProduct(ProductDto product)
    {
        Product lastProduct = Products.Last(); //garantimos uma lista não vazia
        Product newProduct = new(lastProduct.Id+1, product.Nome, product.Preco, product.Estoque);
        Products.Add(newProduct);
    }

    public static List<Product> ShowList()
    {
        return Products.Where(p => p.Id > 0).ToList();
    }

    public static Product? FindProductById(int id)
    {
        if (id <= 0)
        {
            Console.WriteLine("\n\n>>>>Invalid ID\n");
            return null;
        }
        return Products.FirstOrDefault(p => p.Id == id);
    }

    public static void UpdateProduct(int id, ProductDto produtoAtualizado)
    {
        Product? p = FindProductById(id);
        if (p == null)
            return;

        p.Nome = produtoAtualizado.Nome;
        p.Preco = produtoAtualizado.Preco;
        p.Estoque = produtoAtualizado.Estoque;
    }

    public static void DeleteProduct(int id)
    {
        Product? p = FindProductById(id);
        if (p == null)
            return;

        Products.Remove(p);
    }
}