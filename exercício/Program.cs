//Exercício 1

// Console.WriteLine("Digite o nome do produto:");
// string nome = Console.ReadLine();

// Console.WriteLine("Digite a quantidade comprada do produto:");
// int quantidade = int.Parse(Console.ReadLine());

// Console.WriteLine("Digite o preço unitário do produto:");
// decimal precoUnitario = decimal.Parse(Console.ReadLine());

// decimal valorTotal = quantidade * precoUnitario;
// Console.WriteLine($"O produto {nome} tem um valor de: R$ {precoUnitario:F2}, foram comprados {quantidade} e o valor total da compra é: R$ {valorTotal:F2}");

//Exercício 2
// Console.WriteLine("Digite o nome do aluno:");
// string nomeAluno = Console.ReadLine();

// Console.WriteLine($"Digite a nota do aluno {nomeAluno}:");
// int nota = int.Parse(Console.ReadLine());

// if (nota > 10 || nota < 0)
// {
//     Console.WriteLine("Nota inválida! Digite uma nota entre 0 e 10.");
// }
// else if (nota >= 7)
// {
//     Console.WriteLine($"O aluno {nomeAluno} foi aprovado com a nota {nota}.");
// }
// else if (nota >= 5 && nota < 7)
// {
//     Console.WriteLine($"O aluno {nomeAluno} está de recuperação com a nota {nota}.");
// }


// else if (nota < 5)
// {
//     Console.WriteLine($"O aluno {nomeAluno} foi reprovado com a nota {nota}.");
// }

// Exercício 3
// int tentativas = 0;
// int Num = 8;
//     Console.WriteLine("Digite um número:");
//     int resposta = int.Parse(Console.ReadLine());
//     tentativas++;
// while (resposta != Num)
// {
//     if (resposta < Num)
//     {
//         Console.WriteLine("O número digitado é menor que o número secreto.");
//     }
//     else if (resposta > Num)
//     {
//         Console.WriteLine("O número digitado é maior que o número secreto.");
//     }
//     Console.WriteLine("Digite um número:");
//      resposta = int.Parse(Console.ReadLine());
//      tentativas++;
// }
// Console.WriteLine($"Parabéns! Você acertou o número secreto em {tentativas} tentativas.");

// Exercício 4
// decimal Soma(int a, int b)
// {
//     return a + b;
// }
// decimal Multiplicacao(int a, int b)
// {
//     return a * b;
// }

// Console.WriteLine("Digite o primeiro número:");
// int a = int.Parse(Console.ReadLine());

// Console.WriteLine("Digite o segundo número:");
// int b = int.Parse(Console.ReadLine());

// Console.WriteLine($"Soma: {Soma(a, b)}");
// Console.WriteLine($"Multiplicação: {Multiplicacao(a, b)}");

//Exercício 5
// decimal somanotas = 0;
// decimal[] notas = new decimal[3];
// Console.WriteLine("Digite a primeira nota do aluno:");
// notas[0] = decimal.Parse(Console.ReadLine());

// Console.WriteLine("Digite a segunda nota do aluno:");
// notas[1] = decimal.Parse(Console.ReadLine());

// Console.WriteLine("Digite a terceira nota do aluno:");
// notas[2] = decimal.Parse(Console.ReadLine());

// for (int i = 0; i < notas.Length; i++)
// {
// Console.WriteLine($"Nota: {notas[i]}");
// }

// foreach (decimal nota in notas)
// {
//     somanotas = somanotas + nota;
// }
// Console.WriteLine($"A média é {(somanotas / notas.Length):F2}");

//Exercício 6
// List<string> produtos = new List<string>();
// for (int i = 0; i < 3; i++)
// {
// Console.WriteLine("Digite o nome do produto:");
// produtos.Add(Console.ReadLine());
// }

// foreach (string produto in produtos)
// {
//     Console.WriteLine(produto);
// }

// Console.WriteLine("Digite o nome do produto que deseja remover:");
// string produtoRemover = Console.ReadLine();
// if (produtos.Contains(produtoRemover))
// {
//     produtos.Remove(produtoRemover);
//     Console.WriteLine($"O produto {produtoRemover} foi removido da lista.");
// }
// else
// {
//     Console.WriteLine($"O produto {produtoRemover} não foi encontrado na lista.");
// }


// foreach (string produto in produtos)
// {
//     Console.WriteLine(produto);
// }