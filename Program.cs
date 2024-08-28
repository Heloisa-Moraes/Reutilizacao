using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        //Software de validação de senha 

        Console.Write("Digite uma senha:");
        String senha = ValidarSenha(Console.ReadLine());

        Console.Write("\nConfirme sua senha:");
        String confirmaSenha = ValidarSenha(Console.ReadLine());

        bool igual = ComparaTexto(senha, confirmaSenha);

        if (igual)
            Console.WriteLine("\nArmazenando dados!");
        else
            Console.WriteLine("\nRefaca o processo");
    }

    private static string ValidarSenha(string texto)
    {
        if (texto.Length < 8)
            Console.WriteLine("Tamanho inválido");
        if (!texto.Any(char.IsDigit))
            Console.WriteLine("Não posssui numeros");
        if (!texto.Any(char.IsUpper))
            Console.WriteLine("Não possui letra maiuscula");
        if (!texto.Any(c => !char.IsLetterOrDigit(c)))
            Console.WriteLine("Nao possui caractere especial");



        return texto;
    }

    private static bool ComparaTexto(string senha, string confirmaSenha)
    {
        if (senha == confirmaSenha)
        {
            Console.WriteLine("\nSenhas conferem");
            return true;
        }
        else
        {
            Console.WriteLine("\n Senhas nao conferem");
            return false;
        }
    }

}




/* validar se tem um caractere especial e validar se a letra é maiuscula ou minuscula deixar passar ambas como corretas  */

