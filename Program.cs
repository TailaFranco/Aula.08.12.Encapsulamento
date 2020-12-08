using System;
using Aula_08_12_2020.Classes; 
namespace Aula_08_12_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            MasterCard m = new MasterCard();
            
            // int y=0;
            int Menu = 0;
            do
            {
                Console.WriteLine("Escolha uma opção válida");
                Console.WriteLine("[1] Realizar uma nova compra");
                Console.WriteLine("[2] Registros de compras salvas");
                Console.WriteLine("[0] Sair");
                Menu = int.Parse(Console.ReadLine());

                switch (Menu)
                {
                    case 1:
                    Console.WriteLine("Digite o valor da compra");
                    m.compra = float.Parse(Console.ReadLine());
                    if (y==1)
                    {Console.WriteLine("Compra permitida, limite disponível");}
                    else
                    {Console.WriteLine("Não há limite disponível");}
                    Console.WriteLine("Defina o número de parcelas");
                    m.Parcelas =int.Parse(Console.ReadLine());
                    break;
                    case 2:
                    break;
                    case 0:
                    break;
                    default:
                    Console.WriteLine("Opção inválida");
                        break;
                }
                
               
            } while (Menu!=0);
        }
    }
}
