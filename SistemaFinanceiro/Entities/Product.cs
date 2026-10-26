namespace FinacialSystem.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }

        public Product(int id, string nome, decimal preco, int estoque)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
        }
    }
}
