using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        while (true)
        {

            string nome = Console.ReadLine();

            string email = Console.ReadLine();

            string telefone = Console.ReadLine();

            Console.WriteLine("Contato adicionado!\n" +
                            $"Nome: {nome}\n" + 
                            $"E-mail: {email}\n" +
                            $"Tel: {telefone}");
            
            break;
        }
    }
}