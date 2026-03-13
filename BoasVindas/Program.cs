using System;

public class Saudacao
{
    private readonly string nomeCliente;

    public Saudacao(string nomeCliente)
    {
        this.nomeCliente = nomeCliente;
    }

    public string ObterMensagem()
    {
        return $"Ola {nomeCliente}, seja bem-vindo(a)!";
    }
}

public class Program
{
    public static void Main()
    {
      
        Console.Write("Digite seu nome aqui: ");

        string nome = Console.ReadLine();

        Saudacao s = new Saudacao(nome);

        Console.WriteLine(s.ObterMensagem());
    }
}