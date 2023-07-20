using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        string nome, option = " ";
        List<string> taskList = new List<string>();

        Console.WriteLine("Lista de tarefas\n");
        Console.WriteLine("Qual seu nome de usuário? ");
        nome = Console.ReadLine() ?? "";
        Console.Clear();
        Console.WriteLine(nome + " seja bem-vindo(a)!");
        Thread.Sleep(3000);
        Console.Clear();

        while (option != "0")
        {
            Console.WriteLine(nome + ", escolha uma das opções abaixo.\n");
            Console.WriteLine("1 - Criar uma nova lista de tarefas.");
            Console.WriteLine("2 - Visualizar minha lista de tarefas.");
            Console.WriteLine("3 - Adicionar item na minha lista de tarefas.");
            Console.WriteLine("4 - Excluir item da minha lista de tarefas.");
            Console.WriteLine("0 - Sair");
            option = Console.ReadLine() ?? "";

            switch (option)
            {
                case "1":
                    taskList.Clear();
                    Console.Clear();
                    Console.WriteLine("Lista de tarefas criada com sucesso!");
                    Thread.Sleep(1500);
                    break;

                case "2":
                    Console.Clear();
                    if (taskList.Count == 0)
                    {
                        Console.WriteLine(nome + ", sua lista de tarefas está vazia. Adicione novos itens!");
                    }
                    else
                    {
                        Console.WriteLine("Sua lista de tarefas:");
                        for (int i = 0; i < taskList.Count; i++)
                        {
                            Console.WriteLine($"{i + 1} - {taskList[i]}");
                        }
                    }
                    Thread.Sleep(1500);
                    break;

                case "3":
                    Console.Clear();
                    Console.WriteLine("Que item você deseja adicionar?");
                    string newItem = Console.ReadLine() ?? "";
                    taskList.Add(newItem);
                    Console.Clear();
                    Console.WriteLine("Item adicionado com sucesso na sua lista de tarefas");
                    Thread.Sleep(1500);
                    break;

                case "4":
                    Console.Clear();
                    if (taskList.Count == 0)
                    {
                        Console.WriteLine("Sua lista de tarefas está vazia. Nada para excluir!");
                    }
                    else
                    {
                        Console.WriteLine("Sua lista de tarefas:");
                        for (int i = 0; i < taskList.Count; i++)
                        {
                            Console.WriteLine($"{i + 1} - {taskList[i]}");
                        }
                        Console.WriteLine("Digite o número do item que deseja excluir:");
                        int indexToRemove;
                        if (int.TryParse(Console.ReadLine(), out indexToRemove) && indexToRemove >= 1 && indexToRemove <= taskList.Count)
                        {
                            taskList.RemoveAt(indexToRemove - 1);
                            Console.WriteLine("Item removido com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida. Tente novamente!");
                        }
                    }
                    Thread.Sleep(1500);
                    break;

                case "0":
                    Console.WriteLine("Saindo do aplicativo. Até mais!");
                    Thread.Sleep(2500);
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente!");
                    break;
            }

            Console.Clear();
        }
    }
}
