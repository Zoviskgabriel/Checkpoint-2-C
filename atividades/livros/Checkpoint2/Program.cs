public class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int AnoPublicacao { get; set; }

    public Livro(string titulo, string autor, int anoPublicacao)
    {
        Titulo = titulo;
        Autor = autor;
        AnoPublicacao = anoPublicacao;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"{Titulo} – {Autor} ({AnoPublicacao})");
    }
}

class Program
{
    static void Main()
    {
        Livro livro = new Livro("1984", "George Orwell", 1949);
        livro.ExibirInformacoes();  // Saída: 1984 – George Orwell (1949)
    }
}
