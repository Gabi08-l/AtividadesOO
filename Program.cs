using System;
using AtividadeOO;

internal class Program
{
    private static void Main(string[] args)
    {
        var livro1 = new Livros()
        {
            Titulo = "Aprendendo ingles",
            Autor = "Bango",
            Editora = "Azul",
            AnoLancamento = 2020
        };
        Console.WriteLine($"itulo: {livro1.Titulo}, Editora: {livro1.Editora}, Ano de Lançamento {livro1.AnoLancamento}");


        var livro2 = new Livros()
        {
            Titulo = " Não Aprendendo ingles",
            Autor = "Bangu",
            Editora = "Azulado",
            AnoLancamento = 2025
        };
        Console.WriteLine($"titulo: {livro2.Titulo}, Editora: {livro2.Editora}, Ano de Lançamento {livro2.AnoLancamento}");


        var livro3 = new Livros()
        {
            Titulo = "Aprendendo espanhol",
            Autor = "Django",
            Editora = "Vermelho",
            AnoLancamento = 2015
        };
        Console.WriteLine($"titulo: {livro3.Titulo}, Editora: {livro3.Editora}, Ano de Lançamento {livro3.AnoLancamento}");


        Console.WriteLine("--------------------------------------------------");

        var Aluno1 = new Alunos()
        {
            RM = 335788,
            Nome = "Pedro",
            Nascimento = new DateTime(2008, 05, 20), // Corrigido para DateTime
            Email = "Senaioloko@gmail.com"
        };

        Console.WriteLine($"RM: {Aluno1.RM}, Nome: {Aluno1.Nome}, Nascimento: {Aluno1.Nascimento: dd/MM/yyyy}, Email: {Aluno1.Email}");

        var Aluno2 = new Alunos()
        {
            RM = 135788,
            Nome = "Erick",
            Nascimento = new DateTime(2000, 3, 15),
            Email = "Senaioloko123@gmail.com"
        };

        Console.WriteLine($"RM: {Aluno2.RM}, Nome: {Aluno2.Nome}, Nascimento: {Aluno2.Nascimento: dd/MM/yyyy}, Email: {Aluno2.Email}");


        var Aluno3 = new Alunos()
        {
            RM = 235788,
            Nome = "Mayk",
            Nascimento = new DateTime(2009, 02, 20),
            Email = "SenaiolokO423@gmail.com"
        };

        Console.WriteLine($"RM: {Aluno3.RM}, Nome: {Aluno3.Nome}, Nascimento: {Aluno3.Nascimento: dd/MM/yyyy}, Email: {Aluno3.Email}");



        Console.WriteLine("--------------------------------------------------");


        var produto1 = new Produtos()
        {
            Codigo = 1,
            Nome = "Caneta",
            Preco = 2.20m,
            Estoque = 10
        };

        var produto2 = new Produtos()
        {
            Codigo = 4,
            Nome = "Estojo",
            Preco = 5.50m,
            Estoque = 7
        };

        var produto3 = new Produtos()
        {
            Codigo = 8,
            Nome = "Cderno",
            Preco = 10.50m,
            Estoque = 12
        };

        Console.WriteLine($"\nCodigo : {produto1.Codigo}");
        Console.WriteLine($"Nome: {produto1.Nome}");
        Console.WriteLine($"Preço: {produto1.Preco}");
        Console.WriteLine($"Estoque: {produto1.Estoque}");
        Console.WriteLine($"Total em Estoque: {produto1.ValorEstoque(): 0.00}");


        Console.WriteLine($"Nome: {produto2.Nome}");
        Console.WriteLine($"Preço: {produto2.Preco}");
        Console.WriteLine($"Estoque: {produto2.Estoque}");
        Console.WriteLine($"Total em estoque: {produto2.ValorEstoque(): 0.00}");


        Console.WriteLine($"Nome: {produto3.Nome}");
        Console.WriteLine($"Preço: {produto3.Preco}");
        Console.WriteLine($"Estoque: {produto3.Estoque}");
        Console.WriteLine($"Total em estoque: {produto3.ValorEstoque(): 0.00}");


        Console.WriteLine("--------------------------------------------------");

        var Carros1 = new Carros()
        {
            Marca = "Fiat",
            Modelo = "Toro",
            Velocidade = 00
        };

        Console.WriteLine($"Marca: {Carros1.Marca} , modelo: {Carros1.Modelo} , velocidade: {Carros1.Velocidade} ");

        Console.WriteLine($"Velocidade Atual: {Carros1.Acelerar(10)} km/h");
        Console.WriteLine($"Velocidade Atual: {Carros1.Acelerar(10)} km/h");
        Console.WriteLine($"Velocidade Atual: {Carros1.Desacelerar(5)} km/h");


        Console.WriteLine("--------------------------------------------------");


        var f1 = new Funcionarios("Ana", 25, "Analista");
        var f2 = new Funcionarios("Felipe", 40, "Dev");
        var f3 = new Funcionarios("Carla", 20, "Gerente");


        f1.Exibir();
        f2.Exibir();
        f3.Exibir();

        f1.Envelhecer(5);
        f2.Envelhecer(2);
        f3.Envelhecer(1);


        Console.WriteLine("-------------------------------------------");

        Gato gato = new Gato("Gato", "Mingau");
        gato.EmitirSom();

        Porco porco = new Porco("Porco", "Porky");
        porco.EmitirSom();

        Capivara capivara = new Capivara("Capivara", "Capi");
        capivara.EmitirSom();

        Console.WriteLine("-------------------------------------------");

        var Conta1 = new Conta("Banco Itau", 12345, 100, 24668);
        var Conta2 = new Conta("Banco Flass", 123455, 1000, 24468);
        var Conta3 = new Conta("Banco Santander", 122345, 12000, 2468);

        Console.WriteLine($"\nBanco: {Conta1.Banco} | Conta:{Conta1.Agencia} | Conta:{Conta1.conta} | Saldo:{Conta1.Saldo}");
        Console.WriteLine($"\nBanco: {Conta2.Banco} | Conta:{Conta2.Agencia} | Conta:{Conta2.conta} | Saldo:{Conta2.Saldo}");
        Console.WriteLine($"\nBanco: {Conta3.Banco} | Conta:{Conta3.Agencia} | Conta:{Conta3.conta} | Saldo:{Conta3.Saldo} | Limite: {Conta3.Limite}");
        Console.WriteLine($"\nSaque de 100 reais da Conta 1: {Conta1.Sacar(100)}");
        Console.WriteLine($"\nDeposito de 100 da Conta 1: {Conta1.Sacar(100)}");




    }
}