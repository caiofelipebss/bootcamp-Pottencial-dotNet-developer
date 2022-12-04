using ExemploFundamentos.Models;

var pessoa1 = new Pessoa();

Console.Write("Digite seu nome: ");
pessoa1.Name = Console.ReadLine();

Console.Write("Digite sua idade: ");
pessoa1.Age = int.Parse(Console.ReadLine());
pessoa1.Apresentar();
