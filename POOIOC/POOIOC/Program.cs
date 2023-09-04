using POOIOC;

internal class Program
{
    public static void Main(string[] args)
    {
        Biblioteca biblioteca = new Biblioteca();
        biblioteca.AdicionarItem(new Livro()
        {
            Codigo = 10,
            Titulo = "Senhor dos Anéis - O Retorno do Rei",
            AnoPublicacao = 1954,
            Autor = "J.R.R. Tolkien",
            NumeroDePaginas = 450
        });

        biblioteca.AdicionarItem(new Revista()
        {
            Codigo = 20,
            Titulo = "Revista Científica de Tecnologia e Sociedade Vol.5",
            Autor = "Maria Antonieta",
            AnoPublicacao = 2017,
            NumeroDePaginas = 50
        });

        biblioteca.AdicionarItem(new MidiaDigital()
        {
            Codigo = 30,
            Titulo = "Código Limpo - E-Book",
            Autor = "Robert Cecil Martin",
            AnoPublicacao = 2008,
            NumeroDePaginas = 456
        });

        biblioteca.EmprestarItem(10);
        biblioteca.DevolverItem(10);

        biblioteca.DevolverItem(20);

        biblioteca.EmprestarItem(30);
        biblioteca.DevolverItem(30);

        biblioteca.EmprestarItem(20);
        biblioteca.DevolverItem(20);

        biblioteca.EmprestarItem(40);

    }
}