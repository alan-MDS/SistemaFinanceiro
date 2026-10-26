using FinacialSystem.DTOs;
using FinacialSystem.Entities;
using FinancialSystem;

namespace FinacialSystem;
public class Program
{
    public static void Main(string[] args)
    {
        UserInterface userI = new();
        
        userI.ShowInterface();
    }
}
