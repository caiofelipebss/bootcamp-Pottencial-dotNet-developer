﻿using ExemploFundamentos.Models;


Console.WriteLine("Digite uma letra: ");
var letra = Console.ReadLine().ToUpper();

switch (letra)
{
    case "A":
    case "B":
    case "C":
    case "D":
    case "E":
        Console.WriteLine("Vogal! ");
        break;

    default: 
        Console.WriteLine("Não é uma vogal!");
        break;
}





































//int quantidadeEstoque = 3;
//int quantidadeCompra = 3;
//bool possivelVenda = quantidadeCompra > 0 && quantidadeEstoque >= quantidadeCompra;


//Console.WriteLine($"Quantidade em estoque: {quantidadeEstoque}");
//Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
//Console.WriteLine($"É possível realizar a venda? {possivelVenda}");


//if (quantidadeCompra == 0)
//{
//    Console.WriteLine("Venda inválida!");
//}
//else if (possivelVenda)
//{
//    Console.WriteLine("Venda realizada! ");
//}
//else
//{
//    Console.WriteLine("Desculpe. Não temos a quantidade desejada! ");
//}

//Console.ReadKey();