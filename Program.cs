using System;
using System.Linq;

public class Program 
{
    public static void Main (string[] args)
    {
        //Software de validação de senha 

        String senhaCorreta = "123456";

      Console.Write("Digite sua senha:");
     string senha= Console.ReadLine();

   Console.Write("Digite sua senha novamente: ");
    string confirmasenha = Console.ReadLine();
        //faz a validação

    bool tamanhoValido = senhaUsuario.Length >= 8;
    bool contemNumero = senhaUsuario.Any(char.IsDigit); //essa função busca se o char é um digito 
    bool contemMaiuscula = senhaUsuario.Any(char.IsUpper); // verifica se dentro da senha tem uma letra maiúscula

    //testa se todos foram positivos
    if(tamanhoValido && contemMaiuscula && contemNumero){
        Console.WriteLine("Senha válida");
    }else {
        Console.WriteLine("Senha Inválida");

    }
        }


}




        
           
         