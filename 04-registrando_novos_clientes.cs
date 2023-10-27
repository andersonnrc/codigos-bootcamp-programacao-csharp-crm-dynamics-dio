using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        List<string> clientes = new List<string>();

        bool condicao = true;
        
        while (condicao)
        {
            string nome = Console.ReadLine();
            string email = Console.ReadLine();
            string telefone = Console.ReadLine();

            // Registra o cliente (simulação)
            string clienteInfo = $"{nome}, {email}, {telefone}";
            clientes.Add(clienteInfo);

            string continuar = Console.ReadLine();

            switch(continuar)
            {
              case "N":
                foreach(var item in clientes) 
                {
                  Console.WriteLine(item);
                }
                condicao = false;
                break;

              case "S":
                continue;
            }
        }
    }
}