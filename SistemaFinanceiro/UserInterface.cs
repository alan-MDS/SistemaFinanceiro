using FinacialSystem.DTOs;
using FinacialSystem.Entities;
using FinacialSystem.Repositories;
using System.Text.Json;

namespace FinancialSystem;
public class UserInterface
{
    public void ShowInterface()
    {
        bool loop = true;
        while (loop)
        {
            //initialize the list
            ProductRepository.ShowList();

            Console.WriteLine("===================================\n       SISTEMA DE PRODUTOS\n===================================");
            Console.WriteLine("1 - Cadastrar produto\r\n2 - Listar produtos\r\n3 - Buscar produto\r\n4 - Editar produto\r\n5 - Excluir produto\r\n0 - Sair");
            string? option = Console.ReadLine();

            if (!String.IsNullOrWhiteSpace(option))
            {
                switch (option)
                {
                    case "1":
                        ProductDto product = ProductForm();
                        ProductRepository.AddProduct(product);
                    break;

                    case "2":
                        List<Product> productList = ProductRepository.ShowList();
                        var options = new JsonSerializerOptions { WriteIndented = true };
                        string jsonString = JsonSerializer.Serialize(productList, options);

                        Console.WriteLine(jsonString);
                    break;

                    case "3":
                        Console.WriteLine("\nWrite product ID: ");
                        if (!int.TryParse(Console.ReadLine(), out int id))
                            break;
                        Product? prod = ProductRepository.FindProductById(id);
                        if(prod != null)
                        {
                            options = new JsonSerializerOptions { WriteIndented = true };
                            jsonString = JsonSerializer.Serialize(prod, options);
                            Console.WriteLine(jsonString);
                        }
                    break;

                    case "4":
                        Console.WriteLine("\nWhat's product ID?  ");
                        if(!int.TryParse(Console.ReadLine(), out int searcId))
                        {
                            Console.WriteLine("\n>>>>> Invalid ID");
                            break;
                        }
                        else
                        {
                            ProductDto editedProduct = ProductForm();
                            ProductRepository.UpdateProduct(searcId, editedProduct);
                        }
                    break;

                    case "5":
                        Console.WriteLine("\nWhat's product ID?  ");
                        if (!int.TryParse(Console.ReadLine(), out int idForDelete))
                        {
                            Console.WriteLine("\n\n>>>>> Invalid ID");
                            break;
                        }
                        else
                        {
                            //seria bom ter uma etapa de confirmação
                            ProductRepository.DeleteProduct(idForDelete);
                        }
                    break;

                    case "0":
                        loop = false;
                    break;

                    default:
                        Console.WriteLine("\n\n>>>>> Invalid option, try again");
                    break;
                }
            }
        }
    }
    
    private ProductDto ProductForm()
    {
        Console.WriteLine("\nProduct name: ");
        string productName = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(productName))
        {
            Console.WriteLine("\n\n>>>>> Invalid name, 'product name' will be defined\n");
            productName = "product name";
        }
        Console.WriteLine("\nPrice: ");
        string? priceString = Console.ReadLine();

        if (!decimal.TryParse(priceString, out decimal price))
        {
            Console.WriteLine("\n\n>>>>> Invalid value! '0' will be defined\n");
            price = 0;
        }
        
        Console.WriteLine("\nStock: ");
        string? stockString = Console.ReadLine();

        if (!int.TryParse(stockString, out int stock))
        {
            Console.WriteLine("\n\n>>>>> Invalid value, '0' will be defined\n");
            stock = 0;
        }
        return new ProductDto(productName, price, stock);
    }
}
