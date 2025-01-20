using System;

class Program
{
    static void Main()
    {
        // Solicitar a quantidade de caracteres da senha
        Console.WriteLine("Digite a quantidade de caracteres para a senha: ");
        int quantidade = int.Parse(Console.ReadLine());

        // Perguntar se deve incluir letras, números e especiais
        Console.WriteLine("Adicionar letras? (S/N): ");
        bool incluirLetras = Console.ReadLine().ToUpper() == "S";
        Console.WriteLine("Adicionar números? (S/N): ");
        bool incluirNumeros = Console.ReadLine().ToUpper() == "S";
        Console.WriteLine("Adicionar especiais? (S/N): ");
        bool incluirEspeciais = Console.ReadLine().ToUpper() == "S";

        // Gerar e exibir a senha
        string senha = GerarSenha(quantidade, incluirLetras, incluirNumeros, incluirEspeciais);
        Console.WriteLine($"Sua senha gerada é: {senha}");
    }

    static string GerarSenha(int tamanho, bool letras, bool numeros, bool especiais)
    {
        string caracteres = "";

        // Definir os caracteres permitidos
        if (letras) caracteres += "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        if (numeros) caracteres += "0123456789";
        if (especiais) caracteres += "!@#$%^&*()_+-=[]{}|;:,.<>?";

        Random rand = new Random();
        char[] senha = new char[tamanho];

        // Gerar senha aleatória
        for (int i = 0; i < tamanho; i++)
        {
            senha[i] = caracteres[rand.Next(caracteres.Length)];
        }

        return new string(senha);
    }
}
