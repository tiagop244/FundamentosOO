using FundamentosOO;
using System.Security.Cryptography.X509Certificates;

internal class Program
{

    private static void Main(string[] args)
    {
        //Livro livro1 = new Livro();

        //livro1.Titulo = "Harrry Potter";
        //livro1.Editora = "Editora Abril";
        //livro1.Autor = "J.K.H";
        //livro1.AnoLancamento = 2001;

        //Livro livro2 = new Livro();
        //livro2.Titulo = "Programando em C#";
        //livro2.Editora = "Editora Nova";
        //livro2.Autor = "Gustavo Castello";
        //livro2.AnoLancamento = 1982;

        //Livro livro3 = new Livro();
        //livro3.Titulo = "Pai Rico Pai Pobre";
        //livro3.Editora = "Minha Editora";
        //livro3.Autor = "Cristiano de Paula";
        //livro3.AnoLancamento = 2000;

        Aluno aluno1 = new Aluno();

        aluno1.Nome = "Tiago Pereira";
        aluno1.RM = "1234TI";
        aluno1.Email = "tiago.p.duarte@aluno.senai.br";
        aluno1.Nascimento = new DateOnly(2008, 02, 18);

        Console.WriteLine("Aluno1");
        Console.WriteLine("Nome : " + aluno1.Nome);
        Console.WriteLine("====================================");

        Produto p1 = new Produto();
        p1.Nome = "Coca-Cola 2 Litros";
        p1.Codigo = 123456;
        p1.Preco = 12.99;
        p1.Estoque = 96;

        p1.QuantidadeEstoque();
        p1.Estoque = 85;
        p1.QuantidadeEstoque();
        Console.WriteLine("====================================");
        Console.WriteLine();

        Carro carro1 = new Carro();
        carro1.Marca = "Ferrari";
        carro1.Modelo = "488";
        carro1.Velocidade = 80;

        carro1.Acelerar();
        carro1.Acelerar();
        carro1.Acelerar();
        carro1.Desacelerar();

        Console.WriteLine("====================================");
        Console.WriteLine();

    }

}